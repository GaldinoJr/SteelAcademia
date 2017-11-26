namespace SteelGymDesktop.View
{
    partial class PesquisarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarAluno));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDAluno = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.IDAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id do Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome de Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // txtIDAluno
            // 
            this.txtIDAluno.Location = new System.Drawing.Point(156, 50);
            this.txtIDAluno.Name = "txtIDAluno";
            this.txtIDAluno.Size = new System.Drawing.Size(134, 20);
            this.txtIDAluno.TabIndex = 1;
            this.txtIDAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIDAluno_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(12, 168);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(155, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(173, 168);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.AllowUserToAddRows = false;
            this.dtgAlunos.AllowUserToDeleteRows = false;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAluno,
            this.Nome,
            this.Rg,
            this.CPF,
            this.Ativo,
            this.DataPagamento});
            this.dtgAlunos.Location = new System.Drawing.Point(12, 222);
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.ReadOnly = true;
            this.dtgAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgAlunos.Size = new System.Drawing.Size(802, 330);
            this.dtgAlunos.TabIndex = 12;
            this.dtgAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAlunos_CellDoubleClick);
            // 
            // IDAluno
            // 
            this.IDAluno.HeaderText = "ID Aluno";
            this.IDAluno.Name = "IDAluno";
            this.IDAluno.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 315;
            // 
            // Rg
            // 
            this.Rg.HeaderText = "RG";
            this.Rg.Name = "Rg";
            this.Rg.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 40;
            // 
            // DataPagamento
            // 
            this.DataPagamento.HeaderText = "Data de Pagamento";
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(156, 132);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(89, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(156, 106);
            this.txtRG.Mask = "99.999.999-9";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(82, 20);
            this.txtRG.TabIndex = 3;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(12, 29);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(63, 21);
            this.chkAtivo.TabIndex = 26;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // PesquisarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dtgAlunos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIDAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarAluno";
            this.Text = "Pesquisa de Alunos";
            this.Load += new System.EventHandler(this.PesquisarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dtgAlunos;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
    }
}