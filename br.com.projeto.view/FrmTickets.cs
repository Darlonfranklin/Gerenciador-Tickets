using Gerenciamento_de_tickets.br.com.projeto.dao;
using Gerenciamento_de_tickets.br.com.projeto.model;

namespace Gerenciamento_de_tickets.br.com.projeto.view
{
    public partial class FrmTickets : Form
    {
        public FrmTickets()
        {
            InitializeComponent();
        }

        private void FrmTickets_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            textId.Enabled = false;
            btnEditar.Enabled = false;
            comboFuncionario.DataSource = funcionario.ListarFuncionarios();
            comboFuncionario.DisplayMember = "nome";
            comboFuncionario.ValueMember = "id";
            TicketsDAO dao = new TicketsDAO();
            tabelaTickets.DataSource = dao.ListarTickets();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool funcionario = (string.IsNullOrWhiteSpace(comboFuncionario.Text));
            bool quantidade = (string.IsNullOrWhiteSpace(textQuantidade.Text));
            bool status = (string.IsNullOrWhiteSpace(comboStatus.Text));
            bool valida_status = comboStatus.SelectedItem != null && comboStatus.SelectedItem.ToString() == "I";
            var validarCampos = funcionario || quantidade || status;

            if (validarCampos)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (valida_status)
            {
                MessageBox.Show("Não é permitido salvar como 'Inativo'. Novo cadastro somente 'Ativo'", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textData.Text = DateTime.Now.ToString();
            Tickets tickets = new Tickets();
            tickets.funcionarioId = int.Parse(comboFuncionario.SelectedValue.ToString());
            tickets.quantidade = int.Parse(textQuantidade.Text);
            tickets.status = comboStatus.Text;
            tickets.data_entrega = DateTime.Now;
            TicketsDAO dao = new TicketsDAO();
            dao.CadastrarTickets(tickets);
            tabelaTickets.DataSource = dao.ListarTickets();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = textPesquisa.Text;
            TicketsDAO dao = new TicketsDAO();
            tabelaTickets.DataSource = dao.BuscarTicketsPorNomeFuncionario(nome);

            if (tabelaTickets.Rows.Count == 0)
            {
                tabelaTickets.DataSource = dao.ListarTickets();
            }
        }

        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textPesquisa.Text + "%";
            TicketsDAO dao = new TicketsDAO();
            tabelaTickets.DataSource = dao.ListarTicketsPorNomeFuncionario(nome);
        }

        private void tabelaTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            textId.Text = tabelaTickets.CurrentRow.Cells[0].Value.ToString();
            comboFuncionario.Text = tabelaTickets.CurrentRow.Cells[1].Value.ToString();
            textQuantidade.Text = tabelaTickets.CurrentRow.Cells[2].Value.ToString();
            comboStatus.Text = tabelaTickets.CurrentRow.Cells[3].Value.ToString();
            textData.Text = tabelaTickets.CurrentRow.Cells[4].Value.ToString();
            tabControlTickets.SelectedTab = tabTickets;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool funcionario = (string.IsNullOrWhiteSpace(comboFuncionario.Text));
            bool quantidade = (string.IsNullOrWhiteSpace(textQuantidade.Text));
            bool status = (string.IsNullOrWhiteSpace(comboStatus.Text));
            bool valida_status = comboStatus.SelectedItem != null && comboStatus.SelectedItem.ToString() == "I";
            var validarCampos = funcionario || quantidade || status;

            if (validarCampos)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (valida_status)
            {
                MessageBox.Show("Não é permitido salvar como 'Inativo'. Novo cadastro somente 'Ativo'", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tickets tickets = new Tickets();
            tickets.funcionarioId = int.Parse(comboFuncionario.SelectedValue.ToString());
            tickets.quantidade = int.Parse(textQuantidade.Text);
            tickets.id = int.Parse(textId.Text);
            tickets.status = comboStatus.Text;
            tickets.data_entrega = DateTime.Now;
            TicketsDAO dao = new TicketsDAO();
            dao.AlterarTickets(tickets);
            tabelaTickets.DataSource = dao.ListarTickets();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void FrmTickets_Shown(object sender, EventArgs e)
        {
            comboFuncionario.Focus();
        }
    }
}
