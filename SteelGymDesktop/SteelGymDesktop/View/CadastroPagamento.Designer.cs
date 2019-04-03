﻿namespace SteelGymDesktop.View
{
    partial class CadastroPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPagamento));
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAlunos = new System.Windows.Forms.ComboBox();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbNaoPago = new System.Windows.Forms.RadioButton();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor (R$):";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(208, 93);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(98, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(144, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Aluno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data:";
            // 
            // cboAlunos
            // 
            this.cboAlunos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAlunos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAlunos.FormattingEnabled = true;
            this.cboAlunos.Location = new System.Drawing.Point(208, 65);
            this.cboAlunos.Name = "cboAlunos";
            this.cboAlunos.Size = new System.Drawing.Size(171, 21);
            this.cboAlunos.Sorted = true;
            this.cboAlunos.TabIndex = 3;
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.CustomFormat = "dd/MM/YYYY";
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(208, 120);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(98, 20);
            this.dtpDataPagamento.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.rbNaoPago);
            this.panel1.Controls.Add(this.rbPago);
            this.panel1.Controls.Add(this.dtpDataPagamento);
            this.panel1.Controls.Add(this.cboAlunos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(191, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 281);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Foi Pago?";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(338, 227);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(155, 30);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // rbNaoPago
            // 
            this.rbNaoPago.AutoSize = true;
            this.rbNaoPago.ForeColor = System.Drawing.Color.White;
            this.rbNaoPago.Location = new System.Drawing.Point(275, 167);
            this.rbNaoPago.Name = "rbNaoPago";
            this.rbNaoPago.Size = new System.Drawing.Size(73, 17);
            this.rbNaoPago.TabIndex = 6;
            this.rbNaoPago.TabStop = true;
            this.rbNaoPago.Text = "Não Pago";
            this.rbNaoPago.UseVisualStyleBackColor = true;
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.ForeColor = System.Drawing.Color.White;
            this.rbPago.Location = new System.Drawing.Point(208, 167);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(50, 17);
            this.rbPago.TabIndex = 5;
            this.rbPago.TabStop = true;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            // 
            // CadastroPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(899, 651);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroPagamento";
            this.Text = "Cadastro de Movimentacao";
            this.Load += new System.EventHandler(this.CadastroPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAlunos;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rbNaoPago;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.Label label1;
    }
}