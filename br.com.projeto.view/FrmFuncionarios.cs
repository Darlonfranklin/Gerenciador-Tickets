using Gerenciamento_de_tickets.br.com.projeto.dao;
using Gerenciamento_de_tickets.br.com.projeto.model;

namespace Gerenciamento_de_tickets.br.com.projeto.view
{
    public partial class FrmFuncionarios : Form

    {
        public FrmFuncionarios()
        {
            InitializeComponent();

        }
        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            textId.Enabled = false;
            btnEditar.Enabled = false;
            tabelaFuncionario.DefaultCellStyle.ForeColor = Color.Black;
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.ListarFuncionarios();
        }

        private void FrmFuncionarios_Shown(object sender, EventArgs e)
        {
            textNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool nome = (string.IsNullOrWhiteSpace(textNome.Text));
            bool cpf = (string.IsNullOrWhiteSpace(maskedCPF.Text));
            bool status = (string.IsNullOrWhiteSpace(comboStatus.Text));
            bool valida_status = comboStatus.SelectedItem != null && comboStatus.SelectedItem.ToString() == "I";
            bool validarCPF = maskedCPF.Text.Length < 14;
            var validarCampos = nome || cpf || status;

            if (validarCampos)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (validarCPF)
            {
                MessageBox.Show("O CPF digitado está incorreto!", "Atenção!",
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
            Funcionario funcionario = new Funcionario();
            funcionario.nome = textNome.Text;
            funcionario.cpf = maskedCPF.Text;
            funcionario.status = comboStatus.Text;
            funcionario.data_alteracao = DateTime.Now;
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(funcionario);
            tabelaFuncionario.DataSource = dao.ListarFuncionarios();
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            textId.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            textNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            maskedCPF.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            comboStatus.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            textData.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool nome = (string.IsNullOrWhiteSpace(textNome.Text));
            bool cpf = (string.IsNullOrWhiteSpace(maskedCPF.Text));
            bool status = (string.IsNullOrWhiteSpace(comboStatus.Text));
            bool validarCPF = maskedCPF.Text.Length < 14;
            var validarCampos = nome || cpf || status;

            if (validarCampos)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (validarCPF)
            {
                MessageBox.Show("O CPF digitado está incorreto!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario funcionario = new Funcionario();
            funcionario.nome = textNome.Text;
            funcionario.cpf = maskedCPF.Text;
            funcionario.status = comboStatus.Text;
            funcionario.id = int.Parse(textId.Text);
            funcionario.data_alteracao = DateTime.Now;
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(funcionario);
            tabelaFuncionario.DataSource = dao.ListarFuncionarios();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = textPesquisa.Text;
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.BuscarFuncionariosPorNome(nome);

            if (tabelaFuncionario.Rows.Count == 0)
            {
                tabelaFuncionario.DataSource = dao.ListarFuncionarios();
            }
        }

        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textPesquisa.Text + "%";
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.ListarFuncionariosPorNome(nome);
        }
    }
}


