using Gerenciamento_de_tickets.br.com.projeto.connection;
using Npgsql;
using System.Data;

namespace Gerenciamento_de_tickets.br.com.projeto.dao
{
    public class RelatorioTicketsDAO
    {

        private readonly string conexao;

        public RelatorioTicketsDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection().ConnectionString;
        }

        NpgsqlConnection? con = null;
        public DataTable ListarTicketsPorPeriodo(DateTime dataInicio, DateTime dataFim, string nomeFuncionario)
        {
            DataTable tabelaTickets = new DataTable();

            string sql = @"
                    SELECT 
                        funcionarios.id,
                        funcionarios.nome AS ""Nome"",
                        SUM(tickets.quantidade) AS ""Quantidade Total""
                    FROM 
                        tickets
                    INNER JOIN 
                        funcionarios ON tickets.funcionarioId = funcionarios.id
                    WHERE 
                        DATE(tickets.data_entrega) >= @dataInicio
                        AND DATE(tickets.data_entrega) <= @dataFim
                        AND funcionarios.nome LIKE @nome
                    GROUP BY 
                        funcionarios.id,
                        funcionarios.nome
                    ORDER BY 
                        funcionarios.nome";

            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    using (var queryCommand = new NpgsqlCommand(sql, con))
                    {
                        queryCommand.Parameters.AddWithValue("@dataInicio", dataInicio);
                        queryCommand.Parameters.AddWithValue("@dataFim", dataFim);
                        queryCommand.Parameters.AddWithValue("@nome", "%" + nomeFuncionario + "%");

                        con.Open();
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryCommand))
                        {
                            da.Fill(tabelaTickets);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar tickets por funcionário: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
            return tabelaTickets;
        }
    }
}
