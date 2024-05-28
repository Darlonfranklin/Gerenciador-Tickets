namespace Gerenciamento_de_tickets.br.com.projeto.view
{
    partial class FrmRelatorio
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
            groupBox1 = new GroupBox();
            comboFuncionario = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            tabelaHistorico = new DataGridView();
            btnBuscar = new Button();
            label1 = new Label();
            label3 = new Label();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaHistorico).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 110);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(422, 40);
            label2.TabIndex = 0;
            label2.Text = "Histórico de Tickets / Periodo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboFuncionario);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tabelaHistorico);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtFim);
            groupBox1.Controls.Add(dtInicio);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 383);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar";
            // 
            // comboFuncionario
            // 
            comboFuncionario.FormattingEnabled = true;
            comboFuncionario.Location = new Point(12, 43);
            comboFuncionario.Name = "comboFuncionario";
            comboFuncionario.Size = new Size(233, 23);
            comboFuncionario.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(92, 27);
            label8.Name = "label8";
            label8.Size = new Size(56, 12);
            label8.TabIndex = 60;
            label8.Text = "(Obrigatório)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 25);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 59;
            label4.Text = "Funcionário:";
            // 
            // tabelaHistorico
            // 
            tabelaHistorico.AllowUserToAddRows = false;
            tabelaHistorico.AllowUserToDeleteRows = false;
            tabelaHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaHistorico.Location = new Point(6, 106);
            tabelaHistorico.Name = "tabelaHistorico";
            tabelaHistorico.ReadOnly = true;
            tabelaHistorico.Size = new Size(810, 271);
            tabelaHistorico.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(192, 0, 0);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Transparent;
            btnBuscar.Location = new Point(663, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 32);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(457, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 15;
            label1.Text = "Data / Fim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(251, 25);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 14;
            label3.Text = "Data / Inicio:";
            // 
            // dtFim
            // 
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(457, 43);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(200, 23);
            dtFim.TabIndex = 1;
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(251, 43);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(200, 23);
            dtInicio.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(334, 27);
            label5.Name = "label5";
            label5.Size = new Size(56, 12);
            label5.TabIndex = 62;
            label5.Text = "(Obrigatório)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(530, 27);
            label6.Name = "label6";
            label6.Size = new Size(56, 12);
            label6.TabIndex = 63;
            label6.Text = "(Obrigatório)";
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 493);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FrmRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório";
            Load += FrmRelatorio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
        private Label label3;
        private Label label1;
        private Button btnBuscar;
        private DataGridView tabelaHistorico;
        private ComboBox comboFuncionario;
        private Label label8;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}