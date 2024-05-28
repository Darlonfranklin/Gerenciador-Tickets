using Npgsql;
using System.Configuration;

namespace Gerenciamento_de_tickets.br.com.projeto.connection
{
    public class ConnectionFactory
    {
        public NpgsqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["dbtickets"].ConnectionString;
            return new NpgsqlConnection(conexao);
        }
    }
}
