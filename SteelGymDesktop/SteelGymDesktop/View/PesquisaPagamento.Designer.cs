namespace SteelGymDesktop.View
{
    partial class PesquisaPagamento
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
            this.dtgPagamentos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbNaoPago = new System.Windows.Forms.RadioButton();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.lblTotalSaida = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.IDMovimentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDe
            // 
            this.dtpDe.CustomFormat = "dd/MM/YYYY";
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(126, 121);
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
            this.dtpAte.Location = new System.Drawing.Point(287, 121);
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
            // dtgPagamentos
            // 
            this.dtgPagamentos.AllowUserToAddRows = false;
            this.dtgPagamentos.AllowUserToDeleteRows = false;
            this.dtgPagamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.dtgPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMovimentation,
            this.Nome,
            this.Rg,
            this.TipoPagamento,
            this.Ativo});
            this.dtgPagamentos.Location = new System.Drawing.Point(86, 243);
            this.dtgPagamentos.Name = "dtgPagamentos";
            this.dtgPagamentos.ReadOnly = true;
            this.dtgPagamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgPagamentos.Size = new System.Drawing.Size(698, 330);
            this.dtgPagamentos.TabIndex = 22;
            this.dtgPagamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPagamentos_CellContentClick);
            this.dtgPagamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPagamentos_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
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
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
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
            // rbNaoPago
            // 
            this.rbNaoPago.AutoSize = true;
            this.rbNaoPago.ForeColor = System.Drawing.Color.White;
            this.rbNaoPago.Location = new System.Drawing.Point(183, 160);
            this.rbNaoPago.Name = "rbNaoPago";
            this.rbNaoPago.Size = new System.Drawing.Size(73, 17);
            this.rbNaoPago.TabIndex = 24;
            this.rbNaoPago.TabStop = true;
            this.rbNaoPago.Text = "Não Pago";
            this.rbNaoPago.UseVisualStyleBackColor = true;
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.ForeColor = System.Drawing.Color.White;
            this.rbPago.Location = new System.Drawing.Point(90, 160);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(50, 17);
            this.rbPago.TabIndex = 23;
            this.rbPago.TabStop = true;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
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
            // IDMovimentation
            // 
            this.IDMovimentation.HeaderText = "ID";
            this.IDMovimentation.Name = "IDMovimentation";
            this.IDMovimentation.ReadOnly = true;
            this.IDMovimentation.Width = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Aluno";
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
            this.TipoPagamento.HeaderText = "Pago?";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Data";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // PesquisaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(899, 651);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotalSaida);
            this.Controls.Add(this.lblTotalEntrada);
            this.Controls.Add(this.rbNaoPago);
            this.Controls.Add(this.rbPago);
            this.Controls.Add(this.dtgPagamentos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.label5);
            this.Name = "PesquisaPagamento";
            this.Text = "PesquisaPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPagamentos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbNaoPago;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.Label lblTotalEntrada;
        private System.Windows.Forms.Label lblTotalSaida;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMovimentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}