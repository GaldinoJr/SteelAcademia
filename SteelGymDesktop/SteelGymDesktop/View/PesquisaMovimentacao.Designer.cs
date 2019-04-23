namespace SteelGymDesktop.View
{
    partial class PesquisaMovimentacao
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
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMovimentacoes = new System.Windows.Forms.DataGridView();
            this.IDMovimentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalSaida = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimentacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDe
            // 
            this.dtpDe.CustomFormat = "dd/MM/YYYY";
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(126, 117);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(103, 20);
            this.dtpDe.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(87, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "De:";
            // 
            // dtpAte
            // 
            this.dtpAte.CustomFormat = "dd/MM/YYYY";
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(287, 117);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(103, 20);
            this.dtpAte.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Até:";
            // 
            // dtgMovimentacoes
            // 
            this.dtgMovimentacoes.AllowUserToAddRows = false;
            this.dtgMovimentacoes.AllowUserToDeleteRows = false;
            this.dtgMovimentacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.dtgMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMovimentation,
            this.Nome,
            this.Rg,
            this.TipoPagamento,
            this.CPF,
            this.Ativo});
            this.dtgMovimentacoes.Location = new System.Drawing.Point(86, 243);
            this.dtgMovimentacoes.Name = "dtgMovimentacoes";
            this.dtgMovimentacoes.ReadOnly = true;
            this.dtgMovimentacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgMovimentacoes.Size = new System.Drawing.Size(761, 330);
            this.dtgMovimentacoes.TabIndex = 22;
            this.dtgMovimentacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMovimentacoes_CellContentClick);
            this.dtgMovimentacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMovimentacoes_CellDoubleClick);
            // 
            // IDMovimentation
            // 
            this.IDMovimentation.HeaderText = "ID";
            this.IDMovimentation.Name = "IDMovimentation";
            this.IDMovimentation.ReadOnly = true;
            this.IDMovimentation.Width = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Origem";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 315;
            // 
            // Rg
            // 
            this.Rg.HeaderText = "Valor";
            this.Rg.Name = "Rg";
            this.Rg.ReadOnly = true;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.HeaderText = "Tipo";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "Entrada/Saida";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Data";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(247, 194);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 30);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(86, 194);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(155, 30);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.ForeColor = System.Drawing.Color.White;
            this.rbSaida.Location = new System.Drawing.Point(183, 160);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(52, 17);
            this.rbSaida.TabIndex = 24;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saida";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.ForeColor = System.Drawing.Color.White;
            this.rbEntrada.Location = new System.Drawing.Point(90, 160);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 23;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(502, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Valor total entrada (R$):";
            // 
            // lblTotalEntrada
            // 
            this.lblTotalEntrada.AutoSize = true;
            this.lblTotalEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntrada.ForeColor = System.Drawing.Color.White;
            this.lblTotalEntrada.Location = new System.Drawing.Point(702, 122);
            this.lblTotalEntrada.Name = "lblTotalEntrada";
            this.lblTotalEntrada.Size = new System.Drawing.Size(0, 17);
            this.lblTotalEntrada.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(502, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Valor total saida (R$):";
            // 
            // lblTotalSaida
            // 
            this.lblTotalSaida.AutoSize = true;
            this.lblTotalSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaida.ForeColor = System.Drawing.Color.White;
            this.lblTotalSaida.Location = new System.Drawing.Point(702, 150);
            this.lblTotalSaida.Name = "lblTotalSaida";
            this.lblTotalSaida.Size = new System.Drawing.Size(0, 17);
            this.lblTotalSaida.TabIndex = 28;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(702, 176);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(502, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Resultado:";
            // 
            // PesquisaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(899, 651);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotalSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSaida);
            this.Controls.Add(this.rbEntrada);
            this.Controls.Add(this.dtgMovimentacoes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.label5);
            this.Name = "PesquisaMovimentacao";
            this.Text = "PesquisaMovimentacao";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimentacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMovimentacoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalSaida;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMovimentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}