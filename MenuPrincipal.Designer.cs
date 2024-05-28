namespace Gerenciamento_de_tickets
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeTicketsToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeTicketsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatórioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeFuncionáriosToolStripMenuItem, cadastroDeTicketsToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            cadastroDeFuncionáriosToolStripMenuItem.DoubleClickEnabled = true;
            cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            cadastroDeFuncionáriosToolStripMenuItem.Size = new Size(208, 22);
            cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários";
            cadastroDeFuncionáriosToolStripMenuItem.Click += cadastroDeFuncionáriosToolStripMenuItem_Click;
            // 
            // cadastroDeTicketsToolStripMenuItem
            // 
            cadastroDeTicketsToolStripMenuItem.Name = "cadastroDeTicketsToolStripMenuItem";
            cadastroDeTicketsToolStripMenuItem.Size = new Size(208, 22);
            cadastroDeTicketsToolStripMenuItem.Text = "Cadastro de Tickets";
            cadastroDeTicketsToolStripMenuItem.Click += cadastroDeTicketsToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeTicketsToolStripMenuItem });
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // relatórioDeTicketsToolStripMenuItem
            // 
            relatórioDeTicketsToolStripMenuItem.Name = "relatórioDeTicketsToolStripMenuItem";
            relatórioDeTicketsToolStripMenuItem.Size = new Size(176, 22);
            relatórioDeTicketsToolStripMenuItem.Text = "Relatório de Tickets";
            relatórioDeTicketsToolStripMenuItem.Click += relatórioDeTicketsToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 491);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeTicketsToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem relatórioDeTicketsToolStripMenuItem;
    }
}
