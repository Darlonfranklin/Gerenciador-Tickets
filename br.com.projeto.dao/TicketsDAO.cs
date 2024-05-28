using Gerenciamento_de_tickets.br.com.projeto.connection;
using Gerenciamento_de_tickets.br.com.projeto.model;
using Npgsql;
using System.Data;

namespace Gerenciamento_de_tickets.br.com.projeto.dao
{
    public class TicketsDAO
    {
        private readonly string conexao;

        public TicketsDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection().ConnectionString;
        }

        NpgsqlConnection? con = null;


        public void CadastrarTickets(Tickets tickets)
        {
            string sql = @"INSERT INTO tickets (funcionarioId, quantidade, status, data_entrega) 
                                    VALUES (@funcionarioId, @quantidade, @status, @data_entrega)";

            DateTime dataHora = DateTime.Now;
            string formatoDataHora = dataHora.ToString("dd/MM/yyyy HH:mm");

            try
            {
                {
                    using (var con = new NpgsqlConnection(conexao))
                    {
                        using (var queryCommand = new NpgsqlCommand(sql, con))
                        {
                            queryCommand.Parameters.AddWithValue("@funcionarioId", tickets.funcionarioId);
                            queryCommand.Parameters.AddWithValue("@quantidade", tickets.quantidade);
                            queryCommand.Parameters.AddWithValue("@status", tickets.status);
                            queryCommand.Parameters.AddWithValue("@data_entrega", formatoDataHora);
                            con.Open();
                            queryCommand.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Tickets cadastrado com sucesso", "Mensagem do sistema!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o funcionário", "Mensagem do sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (con?.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void AlterarTickets(Tickets tickets)
        {
            string sql = @"UPDATE tickets 
                SET 
                    funcionarioId=@funcionarioId, 
                    quantidade=@quantidade, 
                    status=@status, 
                    data_entrega=@data_entrega 
                WHERE 
                    id=@id";

            DateTime dataHora = DateTime.Now;
            string formatoDataHora = dataHora.ToString("dd/MM/yyyy HH:mm");

            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {

                    using (var queryCommand = new NpgsqlCommand(sql, con))
                    {
                        queryCommand.Parameters.AddWithValue("@id", tickets.id);
                        queryCommand.Parameters.AddWithValue("@funcionarioId", tickets.funcionarioId);
                        queryCommand.Parameters.AddWithValue("@quantidade", tickets.quantidade);
                        queryCommand.Parameters.AddWithValue("@status", tickets.status);
                        queryCommand.Parameters.AddWithValue("@data_entrega", formatoDataHora);

                        con.Open();
                        queryCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ticket alterado com sucesso!", "Mensagem do sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao ataualizar ticket: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Mensagem do sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        public DataTable ListarTicketsPorNomeFuncionario(string nome)
        {
            DataTable tabelaTickets = new DataTable();

            string sql = @"
                        SELECT 
                            tickets.id,
                            funcionarios.nome AS ""Nome"",
                            tickets.quantidade AS ""Quantidade"",
                            tickets.status AS ""Status"",
                            tickets.data_entrega AS ""Data de entrega""
                        FROM 
                            tickets
                        INNER JOIN
                            funcionarios
                        ON 
                            tickets.funcionarioid = funcionarios.id
                        WHERE 
                            funcionarios.nome LIKE @nome";

            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    using (var queryCommand = new NpgsqlCommand(sql, con))
                    {
                        queryCommand.Parameters.AddWithValue("@nome", nome);
                        con.Open();
                        queryCommand.ExecuteNonQuery();
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
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return tabelaTickets;
        }

        public DataTable BuscarTicketsPorNomeFuncionario(string nome)
        {
            DataTable tabelaTickets = new DataTable();

            string sql = @"
                            SELECT 
                                tickets.id,
                                funcionarios.nome AS ""Nome"",
                                tickets.quantidade AS ""Quantidade"",
                                tickets.status AS ""Status"",
                                tickets.data_entrega AS ""Data de entrega""
                            FROM 
                                tickets
                            INNER JOIN
                                funcionarios
                            ON 
                                tickets.funcionarioid = funcionarios.id
                            WHERE funcionarios.nome = @nome";
            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    using (var queryCommand = new NpgsqlCommand(sql, con))
                    {
                        queryCommand.Parameters.AddWithValue("@nome", nome);
                        con.Open();
                        queryCommand.ExecuteNonQuery();
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryCommand))
                        {
                            da.Fill(tabelaTickets);
                        }
                    }
                }
            }

            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar tickets por funcionário: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return tabelaTickets;
        }

        public DataTable ListarTickets()
        {
            DataTable tabelaTickets = new DataTable();

            string sql = @"
                            SELECT 
                                tickets.id,
                                funcionarios.nome AS ""Nome"",
                                tickets.quantidade AS ""Quantidade"",
                                tickets.status AS ""Status"",
                                tickets.data_entrega AS ""Data de entrega""
                            FROM 
                                tickets
                            INNER JOIN
                                funcionarios
                            ON 
                                tickets.funcionarioid = funcionarios.id";
            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        con.Open();
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(tabelaTickets);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar os tickets: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }

            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return tabelaTickets;
        }
    }
}

