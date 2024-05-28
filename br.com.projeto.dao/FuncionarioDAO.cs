using Gerenciamento_de_tickets.br.com.projeto.connection;
using Gerenciamento_de_tickets.br.com.projeto.model;
using Npgsql;
using System.Data;

namespace Gerenciamento_de_tickets.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private readonly string conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection().ConnectionString;
        }

        NpgsqlConnection? con = null;

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            string sql = @"INSERT INTO funcionarios (nome, cpf, status, data_alteracao) 
                                    VALUES (@nome, @cpf, @status, @data_alteracao)";

            DateTime dataHora = DateTime.Now;
            string formatoDataHora = dataHora.ToString("dd/MM/yyyy HH:mm");

            try
            {
                {
                    using (var con = new NpgsqlConnection(conexao))
                    {
                        using (var queryCommand = new NpgsqlCommand(sql, con))
                        {
                            queryCommand.Parameters.AddWithValue("@nome", funcionario.nome);
                            queryCommand.Parameters.AddWithValue("@cpf", funcionario.cpf);
                            queryCommand.Parameters.AddWithValue("@status", funcionario.status);
                            queryCommand.Parameters.AddWithValue("@data_alteracao", formatoDataHora);
                            con.Open();
                            queryCommand.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Funcionário cadastrado com sucesso", "Mensagem do sistema!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (NpgsqlException ex)
            {
                if (ex.SqlState == "23505")
                {
                    MessageBox.Show("Já existe um funcionário cadastrado com este CPF. Por favor, insira um CPF único.",
                                    "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        public void AlterarFuncionario(Funcionario funcionario)
        {
            string sql = @"UPDATE funcionarios 
                            SET nome=@nome, cpf=@cpf, status=@status, data_alteracao=@data_alteracao WHERE id = @id";

            DateTime dataHora = DateTime.Now;
            string formatoDataHora = dataHora.ToString("dd/MM/yyyy HH:mm");

            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    using (var queryCommand = new NpgsqlCommand(sql, con))
                    {
                        queryCommand.Parameters.AddWithValue("@id", funcionario.id);
                        queryCommand.Parameters.AddWithValue("@nome", funcionario.nome);
                        queryCommand.Parameters.AddWithValue("@cpf", funcionario.cpf);
                        queryCommand.Parameters.AddWithValue("@status", funcionario.status);
                        queryCommand.Parameters.AddWithValue("@data_alteracao", formatoDataHora);

                        con.Open();
                        queryCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionário alterado com sucesso!", "Mensagem do sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                if (ex.SqlState == "23505")
                {
                    MessageBox.Show("Este CPF já pertence a uma pessoa física. Por favor, insira um CPF válido.",
                                    "Mensagem do sistema", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado", "Mensagem do sistema" + ex.Message);

            }
            finally
            {
                if (con?.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public DataTable BuscarFuncionariosPorNome(string nome)
        {
            DataTable tabelaFuncionario = new DataTable();

            string sql = "SELECT * FROM funcionarios WHERE nome = @nome";

            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    {
                        using (var queryCommand = new NpgsqlCommand(sql, con))
                        {
                            queryCommand.Parameters.AddWithValue("@nome", nome);
                            con.Open();
                            queryCommand.ExecuteNonQuery();
                            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryCommand))
                            {
                                da.Fill(tabelaFuncionario);
                            }
                        }
                    }
                }
            }

            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar funcionário: " + ex.Message);
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
            return tabelaFuncionario;
        }

        public DataTable ListarFuncionariosPorNome(string nome)
        {
            DataTable tabelaFuncionario = new DataTable();

            string sql = @"
                            SELECT 
                                id,
                                nome AS ""Nome"", 
                                        cpf AS ""CPF"", 
                                            status AS ""Status"", 
                                                 data_alteracao AS ""Data de alteração""
                                FROM 
                                     funcionarios
                                WHERE nome
                                LIKE @nome";
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
                            da.Fill(tabelaFuncionario);
                        }
                    }
                }
            }

            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar funcionário: " + ex.Message);
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
            return tabelaFuncionario;
        }

        public DataTable ListarFuncionarios()
        {
            DataTable tablelaFuncionario = new DataTable();

            string sql = @"
                            SELECT 
                                id,
                                nome AS ""Nome"", 
                                        cpf AS ""CPF"", 
                                            status AS ""Status"", 
                                                 data_alteracao AS ""Data de alteração""
                                FROM 
                                     funcionarios";
            try
            {
                using (var con = new NpgsqlConnection(conexao))
                {
                    {
                        using (var cmd = new NpgsqlCommand(sql, con))
                        {
                            con.Open();
                            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                            {
                                da.Fill(tablelaFuncionario);
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar os funcionários: " + ex.Message);
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
            return tablelaFuncionario;
        }
    }
}