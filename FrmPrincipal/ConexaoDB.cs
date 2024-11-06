using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FrmPrincipal
{
    internal class ConexaoDB : IDisposable
    {
        private SqlConnection conn;
        private bool _disposed = false;
        string strConexao;

        public ConexaoDB()
        {
            strConexao = ConfigurationManager.ConnectionStrings["Conexaofazenda"].ConnectionString;
            conn = new SqlConnection(strConexao);
        }

        public SqlConnection AbrirConexao()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void FecharConexao()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    FecharConexao();
                    conn?.Dispose();
                }

                _disposed = true;
            }
        }

        ~ConexaoDB()
        {
            Dispose(false);
        }

        public void ExecutarComando(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao executar comando: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão após a execução
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable ExecutarConsulta(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd.Connection = AbrirConexao();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao executar consulta: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

            return dt;
        }
        public bool UsuarioJaExiste(string usuario, int? idAtual = null)
        {
            using (ConexaoDB conexao = new ConexaoDB())
            {
                string sqlCheckUser = "SELECT COUNT(*) FROM tbUsuarios WHERE Usuario = @Usuario";

                if (idAtual != null)
                {
                    sqlCheckUser += " AND ID != @IDAtual";
                }

                using (SqlCommand cmd = new SqlCommand(sqlCheckUser, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    if (idAtual != null)
                    {
                        cmd.Parameters.AddWithValue("@IDAtual", idAtual);
                    }

                    var count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool DocumentoJaExiste(string documento, int? idAtual = null)
        {
            using (ConexaoDB conexao = new ConexaoDB())
            {
                string sqlSelect = "SELECT COUNT(*) FROM tbFornecedor WHERE CNPJ_CPF = @Documento";

                if (idAtual != null)
                {
                    sqlSelect += " AND FornecedorId != @IDAtual";
                }

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@Documento", documento);

                    if (idAtual != null)
                    {
                        cmd.Parameters.AddWithValue("@IDAtual", idAtual);
                    }

                    var count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }

            }
        }

       
    }
}
