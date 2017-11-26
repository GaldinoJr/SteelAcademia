namespace SteelGymDesktop.View
{
    partial class Principal
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
            System.Windows.Forms.MenuStrip Menu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprovantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolbar = new System.Windows.Forms.Panel();
            this.txtNomeModulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            Menu = new System.Windows.Forms.MenuStrip();
            Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Menu.Dock = System.Windows.Forms.DockStyle.Left;
            Menu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            Menu.GripMargin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.pagamentoToolStripMenuItem,
            this.comprovantesToolStripMenuItem,
            this.cadastroDeUsuarioToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.fecharToolStripMenuItem});
            Menu.Location = new System.Drawing.Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new System.Windows.Forms.Padding(10, 58, 0, 2);
            Menu.Size = new System.Drawing.Size(147, 641);
            Menu.TabIndex = 5;
            Menu.Text = "Home";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.alunoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cadastroToolStripMenuItem.Text = "Incluir";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.PesquisarToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.pagamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pagamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagamentoToolStripMenuItem.Image")));
            this.pagamentoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            this.pagamentoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagamentoToolStripMenuItem.Click += new System.EventHandler(this.PagamentoToolStripMenuItem_Click);
            // 
            // comprovantesToolStripMenuItem
            // 
            this.comprovantesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.comprovantesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comprovantesToolStripMenuItem.Image = global::SteelGymDesktop.Properties.Resources.ic_comprovante;
            this.comprovantesToolStripMenuItem.Name = "comprovantesToolStripMenuItem";
            this.comprovantesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.comprovantesToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.comprovantesToolStripMenuItem.Text = "Comprovantes";
            this.comprovantesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprovantesToolStripMenuItem.Click += new System.EventHandler(this.ComprovantesToolStripMenuItem_Click);
            // 
            // cadastroDeUsuarioToolStripMenuItem
            // 
            this.cadastroDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.cadastroDeUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.pesquisarToolStripMenuItem1});
            this.cadastroDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroDeUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeUsuarioToolStripMenuItem.Image")));
            this.cadastroDeUsuarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastroDeUsuarioToolStripMenuItem.Name = "cadastroDeUsuarioToolStripMenuItem";
            this.cadastroDeUsuarioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.cadastroDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.cadastroDeUsuarioToolStripMenuItem.Text = "Usuário";
            this.cadastroDeUsuarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.IncluirToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.PesquisarToolStripMenuItem1_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclusãoToolStripMenuItem,
            this.pesquisaToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.movimentaçõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("movimentaçõesToolStripMenuItem.Image")));
            this.movimentaçõesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentação";
            this.movimentaçõesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inclusãoToolStripMenuItem
            // 
            this.inclusãoToolStripMenuItem.Name = "inclusãoToolStripMenuItem";
            this.inclusãoToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.inclusãoToolStripMenuItem.Text = "Inclusão";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.fecharToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fecharToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharToolStripMenuItem.Image")));
            this.fecharToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 30, 4, 30);
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(126, 83);
            this.fecharToolStripMenuItem.Text = "Sair";
            this.fecharToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.panel1.Location = new System.Drawing.Point(144, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 611);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 83);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 83);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Location = new System.Drawing.Point(1, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 83);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, 81);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 83);
            this.panel10.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(0, 86);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 83);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(0, 86);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 83);
            this.panel12.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(0, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 83);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(0, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 83);
            this.panel8.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 83);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 83);
            this.panel4.TabIndex = 1;
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(70)))));
            this.toolbar.Controls.Add(this.txtNomeModulo);
            this.toolbar.Controls.Add(this.label1);
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(5084, 58);
            this.toolbar.TabIndex = 0;
            // 
            // txtNomeModulo
            // 
            this.txtNomeModulo.AutoSize = true;
            this.txtNomeModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeModulo.ForeColor = System.Drawing.Color.White;
            this.txtNomeModulo.Location = new System.Drawing.Point(560, 14);
            this.txtNomeModulo.Name = "txtNomeModulo";
            this.txtNomeModulo.Size = new System.Drawing.Size(68, 25);
            this.txtNomeModulo.TabIndex = 1;
            this.txtNomeModulo.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academia Steel";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1076, 641);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = Menu;
            this.Name = "Principal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Index_Load);
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprovantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inclusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNomeModulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
    }
}