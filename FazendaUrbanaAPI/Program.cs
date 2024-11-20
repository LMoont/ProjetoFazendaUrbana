using FazendaUrbanaAPI.Data;
using FazendaUrbanaAPI.Repositorios;
using FazendaUrbanaAPI.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbanaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adiciona serviços ao contêiner.
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                });

            // Configura o Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configura o DbContext com a string de conexão do appsettings.json
            builder.Services.AddDbContext<SistemaTarefasDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoFazenda")));

            // Registro dos repositórios
            builder.Services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();
            builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

            // Configura o CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowEmulator", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configuração do pipeline HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            // Ativa o CORS configurado
            app.UseCors("AllowEmulator");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
