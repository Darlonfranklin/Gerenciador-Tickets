namespace Gerenciamento_de_tickets.br.com.projeto.view
{
    partial class FrmTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            tabControlTickets = new TabControl();
            tabTickets = new TabPage();
            label11 = new Label();
            label7 = new Label();
            textQuantidade = new TextBox();
            comboFuncionario = new ComboBox();
            btnNovo = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnEditar = new Button();
            btnSalvar = new Button();
            textData = new TextBox();
            label6 = new Label();
            comboStatus = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textId = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            label12 = new Label();
            btnPesquisar = new Button();
            textPesquisa = new TextBox();
            tabelaTickets = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabControlTickets.SuspendLayout();
            tabTickets.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaTickets).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 110);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(917, 381);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(909, 353);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(909, 353);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(416, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Tickets Entregue";
            // 
            // tabControlTickets
            // 
            tabControlTickets.Controls.Add(tabTickets);
            tabControlTickets.Controls.Add(tabPage4);
            tabControlTickets.Dock = DockStyle.Fill;
            tabControlTickets.Location = new Point(0, 110);
            tabControlTickets.Name = "tabControlTickets";
            tabControlTickets.SelectedIndex = 0;
            tabControlTickets.Size = new Size(929, 399);
            tabControlTickets.TabIndex = 1;
            // 
            // tabTickets
            // 
            tabTickets.Controls.Add(label11);
            tabTickets.Controls.Add(label7);
            tabTickets.Controls.Add(textQuantidade);
            tabTickets.Controls.Add(comboFuncionario);
            tabTickets.Controls.Add(btnNovo);
            tabTickets.Controls.Add(label10);
            tabTickets.Controls.Add(label9);
            tabTickets.Controls.Add(label8);
            tabTickets.Controls.Add(btnEditar);
            tabTickets.Controls.Add(btnSalvar);
            tabTickets.Controls.Add(textData);
            tabTickets.Controls.Add(label6);
            tabTickets.Controls.Add(comboStatus);
            tabTickets.Controls.Add(label5);
            tabTickets.Controls.Add(label4);
            tabTickets.Controls.Add(label3);
            tabTickets.Controls.Add(textId);
            tabTickets.Controls.Add(label2);
            tabTickets.Location = new Point(4, 24);
            tabTickets.Name = "tabTickets";
            tabTickets.Padding = new Padding(3);
            tabTickets.Size = new Size(921, 371);
            tabTickets.TabIndex = 0;
            tabTickets.Text = "Cadastrar Tickets";
            tabTickets.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(125, 23);
            label11.Name = "label11";
            label11.Size = new Size(56, 12);
            label11.TabIndex = 61;
            label11.Text = "(Obrigatório)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(513, 169);
            label7.Name = "label7";
            label7.Size = new Size(56, 12);
            label7.TabIndex = 60;
            label7.Text = "(Obrigatório)";
            // 
            // textQuantidade
            // 
            textQuantidade.Location = new Point(101, 185);
            textQuantidade.Name = "textQuantidade";
            textQuantidade.Size = new Size(154, 23);
            textQuantidade.TabIndex = 59;
            // 
            // comboFuncionario
            // 
            comboFuncionario.FormattingEnabled = true;
            comboFuncionario.Location = new Point(101, 111);
            comboFuncionario.Name = "comboFuncionario";
            comboFuncionario.Size = new Size(587, 23);
            comboFuncionario.TabIndex = 58;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = SystemColors.ActiveCaptionText;
            btnNovo.Location = new Point(327, 245);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(107, 37);
            btnNovo.TabIndex = 57;
            btnNovo.Text = "Novo Cadastro";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(324, 170);
            label10.Name = "label10";
            label10.Size = new Size(56, 12);
            label10.TabIndex = 56;
            label10.Text = "(Obrigatório)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(181, 169);
            label9.Name = "label9";
            label9.Size = new Size(56, 12);
            label9.TabIndex = 55;
            label9.Text = "(Obrigatório)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(181, 95);
            label8.Name = "label8";
            label8.Size = new Size(56, 12);
            label8.TabIndex = 54;
            label8.Text = "(Obrigatório)";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(214, 245);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 37);
            btnEditar.TabIndex = 46;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(101, 245);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 37);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // textData
            // 
            textData.Enabled = false;
            textData.Location = new Point(408, 185);
            textData.Name = "textData";
            textData.Size = new Size(280, 23);
            textData.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(408, 167);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 52;
            label6.Text = "Data de Entrega:";
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "A", "I" });
            comboStatus.Location = new Point(261, 185);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(142, 23);
            comboStatus.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(261, 167);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 51;
            label5.Text = "Situação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(101, 167);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 50;
            label4.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(101, 93);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 49;
            label3.Text = "Funcionário:";
            // 
            // textId
            // 
            textId.Enabled = false;
            textId.Location = new Point(101, 39);
            textId.Name = "textId";
            textId.Size = new Size(80, 23);
            textId.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(101, 21);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 47;
            label2.Text = "Id:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(btnPesquisar);
            tabPage4.Controls.Add(textPesquisa);
            tabPage4.Controls.Add(tabelaTickets);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(921, 371);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Buscar Tickets";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(100, 23);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 7;
            label12.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPesquisar.ForeColor = SystemColors.ActiveCaptionText;
            btnPesquisar.Location = new Point(712, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(81, 23);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(149, 19);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(557, 23);
            textPesquisa.TabIndex = 5;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // tabelaTickets
            // 
            tabelaTickets.AllowUserToAddRows = false;
            tabelaTickets.AllowUserToDeleteRows = false;
            tabelaTickets.BackgroundColor = SystemColors.Control;
            tabelaTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaTickets.Location = new Point(7, 75);
            tabelaTickets.Name = "tabelaTickets";
            tabelaTickets.ReadOnly = true;
            tabelaTickets.Size = new Size(907, 277);
            tabelaTickets.TabIndex = 4;
            tabelaTickets.CellClick += tabelaTickets_CellClick;
            // 
            // FrmTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 509);
            Controls.Add(tabControlTickets);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmTickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Ticket Entregue";
            Load += FrmTickets_Load;
            Shown += FrmTickets_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabControlTickets.ResumeLayout(false);
            tabTickets.ResumeLayout(false);
            tabTickets.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControlTickets;
        private TabPage tabTickets;
        private TabPage tabPage4;
        private TextBox textQuantidade;
        private ComboBox comboFuncionario;
        private Button btnNovo;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox textData;
        private Label label6;
        private ComboBox comboStatus;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textId;
        private Label label2;
        private Label label7;
        private Label label11;
        private Label label12;
        private Button btnPesquisar;
        private TextBox textPesquisa;
        private DataGridView tabelaTickets;
    }
}