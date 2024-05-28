namespace Gerenciamento_de_tickets.br.com.projeto.view
{
    partial class FrmFuncionarios
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
            label2 = new Label();
            tabFuncionarios = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            label11 = new Label();
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
            maskedCPF = new MaskedTextBox();
            label4 = new Label();
            textNome = new TextBox();
            label3 = new Label();
            textId = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            btnPesquisar = new Button();
            textPesquisa = new TextBox();
            tabelaFuncionario = new DataGridView();
            panel1.SuspendLayout();
            tabFuncionarios.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 110);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(416, 40);
            label2.TabIndex = 0;
            label2.Text = "Manutenção de Funcionários";
            // 
            // tabFuncionarios
            // 
            tabFuncionarios.Controls.Add(tabPage1);
            tabFuncionarios.Controls.Add(tabPage2);
            tabFuncionarios.Dock = DockStyle.Fill;
            tabFuncionarios.Location = new Point(0, 110);
            tabFuncionarios.Name = "tabFuncionarios";
            tabFuncionarios.SelectedIndex = 0;
            tabFuncionarios.Size = new Size(929, 399);
            tabFuncionarios.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(btnNovo);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(textData);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(comboStatus);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(maskedCPF);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textNome);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textId);
            tabPage1.Controls.Add(label1);
            tabPage1.Cursor = Cursors.Hand;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(921, 371);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados do Funcionário";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(129, 21);
            label12.Name = "label12";
            label12.Size = new Size(56, 12);
            label12.TabIndex = 56;
            label12.Text = "(Obrigatório)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(522, 167);
            label11.Name = "label11";
            label11.Size = new Size(56, 12);
            label11.TabIndex = 55;
            label11.Text = "(Obrigatório)";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = SystemColors.ActiveCaptionText;
            btnNovo.Location = new Point(328, 243);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(107, 37);
            btnNovo.TabIndex = 25;
            btnNovo.Text = "Novo Cadastro";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(325, 168);
            label10.Name = "label10";
            label10.Size = new Size(56, 12);
            label10.TabIndex = 24;
            label10.Text = "(Obrigatório)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(138, 167);
            label9.Name = "label9";
            label9.Size = new Size(56, 12);
            label9.TabIndex = 23;
            label9.Text = "(Obrigatório)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(152, 93);
            label8.Name = "label8";
            label8.Size = new Size(56, 12);
            label8.TabIndex = 22;
            label8.Text = "(Obrigatório)";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(215, 243);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 37);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(102, 243);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 37);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // textData
            // 
            textData.Enabled = false;
            textData.Location = new Point(409, 183);
            textData.Name = "textData";
            textData.Size = new Size(280, 23);
            textData.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(409, 165);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 20;
            label6.Text = "Data de alteração:";
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "A", "I" });
            comboStatus.Location = new Point(262, 183);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(142, 23);
            comboStatus.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(262, 165);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 17;
            label5.Text = "Situação:";
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(102, 183);
            maskedCPF.Mask = "###,###,###-##";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(154, 23);
            maskedCPF.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(102, 165);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 15;
            label4.Text = "CPF:";
            // 
            // textNome
            // 
            textNome.Location = new Point(102, 109);
            textNome.Name = "textNome";
            textNome.Size = new Size(587, 23);
            textNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(102, 91);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Nome:";
            // 
            // textId
            // 
            textId.Enabled = false;
            textId.Location = new Point(102, 37);
            textId.Name = "textId";
            textId.Size = new Size(83, 23);
            textId.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(102, 19);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 11;
            label1.Text = "Id:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnPesquisar);
            tabPage2.Controls.Add(textPesquisa);
            tabPage2.Controls.Add(tabelaFuncionario);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(921, 371);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar Funcionários";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(101, 34);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 3;
            label7.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPesquisar.ForeColor = SystemColors.ActiveCaptionText;
            btnPesquisar.Location = new Point(713, 30);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(81, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(150, 30);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(557, 23);
            textPesquisa.TabIndex = 1;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // tabelaFuncionario
            // 
            tabelaFuncionario.AllowUserToAddRows = false;
            tabelaFuncionario.AllowUserToDeleteRows = false;
            tabelaFuncionario.BackgroundColor = SystemColors.Control;
            tabelaFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFuncionario.Location = new Point(8, 86);
            tabelaFuncionario.Name = "tabelaFuncionario";
            tabelaFuncionario.ReadOnly = true;
            tabelaFuncionario.Size = new Size(907, 277);
            tabelaFuncionario.TabIndex = 0;
            tabelaFuncionario.CellClick += tabelaFuncionario_CellClick;
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 509);
            Controls.Add(tabFuncionarios);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonFace;
            MaximizeBox = false;
            Name = "FrmFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manutenção de Funcionários";
            Load += FrmFuncionarios_Load;
            Shown += FrmFuncionarios_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabFuncionarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TabControl tabFuncionarios;
        private TabPage tabPage1;
        private Label label6;
        private ComboBox comboStatus;
        private Label label5;
        private MaskedTextBox maskedCPF;
        private Label label4;
        private TextBox textNome;
        private Label label3;
        private TextBox textId;
        private Label label1;
        private TabPage tabPage2;
        private TextBox textData;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox textPesquisa;
        private Button btnPesquisar;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView tabelaFuncionario;
        private Button btnNovo;
        private Label label11;
        private Label label12;
    }
}