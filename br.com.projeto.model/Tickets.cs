namespace Gerenciamento_de_tickets.br.com.projeto.model
{
    public class Tickets
    {
        public int id { get; set; }
        public int funcionarioId { get; set; }
        public int quantidade { get; set; }
        public string status { get; set; }
        public DateTime data_entrega { get; set; }


    }
}
