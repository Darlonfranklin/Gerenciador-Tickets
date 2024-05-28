using Gerenciamento_de_tickets.br.com.projeto.view;

namespace Gerenciamento_de_tickets
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frm = new FrmFuncionarios();
            frm.ShowDialog();
        }

        private void cadastroDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTickets frm = new FrmTickets();
            frm.ShowDialog();
        }

        private void relatórioDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio frm = new FrmRelatorio();
            frm.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
