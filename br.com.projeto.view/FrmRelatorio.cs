using Gerenciamento_de_tickets.br.com.projeto.dao;

namespace Gerenciamento_de_tickets.br.com.projeto.view
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            comboFuncionario.DisplayMember = "nome";
            comboFuncionario.ValueMember = "id";
            comboFuncionario.DataSource = funcionario.ListarFuncionarios();
            dtInicio.Value = DateTime.Today.AddDays(-1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today.AddDays(-1);
            DateTime dataFim = dtFim.Value;
            string nomeFuncionario = comboFuncionario.Text.Trim();

            if (string.IsNullOrWhiteSpace(comboFuncionario.Text)) {
                MessageBox.Show("O campo funcionário é obrigatório!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RelatorioTicketsDAO dao = new RelatorioTicketsDAO();
            tabelaHistorico.DataSource = dao.ListarTicketsPorPeriodo(dataInicio, dataFim, nomeFuncionario);
        }
    }
}
