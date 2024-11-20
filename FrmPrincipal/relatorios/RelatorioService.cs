using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    internal class RelatorioService
    {
        public void GerarRelatorioVendasExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Vendas");

                worksheet.Cells[1, 1].Value = "ID Venda";
                worksheet.Cells[1, 2].Value = "Cliente";
                worksheet.Cells[1, 3].Value = "Produto";
                worksheet.Cells[1, 4].Value = "Quantidade";
                worksheet.Cells[1, 5].Value = "Unidade de Medida";
                worksheet.Cells[1, 6].Value = "Preço Unitário";
                worksheet.Cells[1, 7].Value = "Valor Total";
                worksheet.Cells[1, 8].Value = "Data";

                using (var cabecalho = worksheet.Cells["A1:H1"])
                {
                    cabecalho.Style.Font.Bold = true;
                    cabecalho.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cabecalho.Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                    cabecalho.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cabecalho.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                string query = @"
            SELECT v.VendaId, c.Nome AS Cliente, p.Nome AS Produto, v.Quantidade, p.UnidadeDeMedida, v.PrecoVenda, v.TotalVenda, v.DataVenda 
            FROM dbo.tbVenda v
            INNER JOIN dbo.tbCliente c ON v.ClienteId = c.ClienteId
            INNER JOIN dbo.tbProdutoColhido p ON v.ProdutoColhidoId = p.ProdutoColhidoId";

                using (ConexaoDB conexao = new ConexaoDB())
                {
                    SqlCommand command = new SqlCommand(query, conexao.AbrirConexao());
                    SqlDataReader reader = command.ExecuteReader();

                    int row = 2;
                    while (reader.Read())
                    {
                        worksheet.Cells[row, 1].Value = reader["VendaId"];
                        worksheet.Cells[row, 2].Value = reader["Cliente"];
                        worksheet.Cells[row, 3].Value = reader["Produto"];
                        worksheet.Cells[row, 4].Value = reader["Quantidade"];
                        worksheet.Cells[row, 5].Value = reader["UnidadeDeMedida"];
                        worksheet.Cells[row, 6].Value = reader["PrecoVenda"];
                        worksheet.Cells[row, 7].Value = reader["TotalVenda"];
                        worksheet.Cells[row, 8].Value = reader["DataVenda"];
                        worksheet.Cells[row, 8].Style.Numberformat.Format = "dd/MM/yyyy";
                        row++;
                    }
                }

                using (var range = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column])
                {
                    range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                string filePath = "C:\\Users\\lucas\\OneDrive\\Documentos\\ADS\\4° Semestre\\PIM\\Aplicação Desktop\\Relatórios\\relatorio_vendas.xlsx";
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void GerarRelatorioMovimentacaoInsumoExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (var package = new ExcelPackage())
                {
                    // Adiciona uma planilha chamada "Movimentacao de Insumos"
                    var worksheet = package.Workbook.Worksheets.Add("Movimentacao de Insumos");

                    // Definindo os cabeçalhos da tabela (colunas)
                    worksheet.Cells[1, 1].Value = "ID Movimentação";
                    worksheet.Cells[1, 2].Value = "Nome do Insumo";
                    worksheet.Cells[1, 3].Value = "Tipo de Movimentação";
                    worksheet.Cells[1, 4].Value = "Quantidade";
                    worksheet.Cells[1, 5].Value = "Data da Movimentação";

                    string query = "SELECT m.MovimentacaoId, i.Nome AS NomeInsumo, m.TipoMovimentacao, m.Quantidade, m.DataMovimentacao " +
                   "FROM tbMovimentacaoInsumo m " +
                   "INNER JOIN tbInsumo i ON m.InsumoId = i.InsumoId";

                    using (ConexaoDB conexao = new ConexaoDB())
                    {
                        SqlCommand command = new SqlCommand(query, conexao.AbrirConexao());

                        SqlDataReader reader = command.ExecuteReader();

                        int row = 2;
                        while (reader.Read())
                        {
                            worksheet.Cells[row, 1].Value = reader["MovimentacaoId"];
                            worksheet.Cells[row, 2].Value = reader["NomeInsumo"];
                            worksheet.Cells[row, 3].Value = reader["TipoMovimentacao"];
                            worksheet.Cells[row, 4].Value = reader["Quantidade"];
                            worksheet.Cells[row, 5].Value = reader["DataMovimentacao"];
                            worksheet.Cells[row, 5].Style.Numberformat.Format = "dd/MM/yyyy";

                            row++;
                        }
                    }

                    string filePath = "C:\\Users\\lucas\\OneDrive\\Documentos\\ADS\\4° Semestre\\PIM\\Aplicação Desktop\\Relatórios\\relatorio_movimentacao_insumo.xlsx";
                    FileInfo fileInfo = new FileInfo(filePath);
                    package.SaveAs(fileInfo);

                    MessageBox.Show("Relatório de movimentação de insumos gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

    }
}

