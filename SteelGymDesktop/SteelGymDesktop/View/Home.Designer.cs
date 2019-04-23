namespace SteelGymDesktop.View
{
    partial class Home
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
            this.panel_active_student = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantityActiveStudents = new System.Windows.Forms.Label();
            this.panel_late_payment = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuatityLatePayments = new System.Windows.Forms.Label();
            this.panel_late_avaliation = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantityLateAvaliations = new System.Windows.Forms.Label();
            this.panel_inative_student = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantityInativeStudents = new System.Windows.Forms.Label();
            this.panel_active_student.SuspendLayout();
            this.panel_late_payment.SuspendLayout();
            this.panel_late_avaliation.SuspendLayout();
            this.panel_inative_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_active_student
            // 
            this.panel_active_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel_active_student.Controls.Add(this.label1);
            this.panel_active_student.Controls.Add(this.txtQuantityActiveStudents);
            this.panel_active_student.Location = new System.Drawing.Point(25, 344);
            this.panel_active_student.Name = "panel_active_student";
            this.panel_active_student.Size = new System.Drawing.Size(428, 259);
            this.panel_active_student.TabIndex = 9;
            this.panel_active_student.Click += new System.EventHandler(this.Panel_active_student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alunos ativos";
            // 
            // txtQuantityActiveStudents
            // 
            this.txtQuantityActiveStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityActiveStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.txtQuantityActiveStudents.Location = new System.Drawing.Point(3, 50);
            this.txtQuantityActiveStudents.Name = "txtQuantityActiveStudents";
            this.txtQuantityActiveStudents.Size = new System.Drawing.Size(424, 120);
            this.txtQuantityActiveStudents.TabIndex = 7;
            this.txtQuantityActiveStudents.Text = "-";
            this.txtQuantityActiveStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtQuantityActiveStudents.Click += new System.EventHandler(this.TxtQuantityActiveStudents_Click);
            // 
            // panel_late_payment
            // 
            this.panel_late_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel_late_payment.Controls.Add(this.label2);
            this.panel_late_payment.Controls.Add(this.txtQuatityLatePayments);
            this.panel_late_payment.Location = new System.Drawing.Point(25, 62);
            this.panel_late_payment.Name = "panel_late_payment";
            this.panel_late_payment.Size = new System.Drawing.Size(428, 259);
            this.panel_late_payment.TabIndex = 10;
            this.panel_late_payment.Click += new System.EventHandler(this.Panel_late_payment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mensalidades atrasadas";
            // 
            // txtQuatityLatePayments
            // 
            this.txtQuatityLatePayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuatityLatePayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.txtQuatityLatePayments.Location = new System.Drawing.Point(3, 41);
            this.txtQuatityLatePayments.Name = "txtQuatityLatePayments";
            this.txtQuatityLatePayments.Size = new System.Drawing.Size(424, 120);
            this.txtQuatityLatePayments.TabIndex = 7;
            this.txtQuatityLatePayments.Text = "-";
            this.txtQuatityLatePayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtQuatityLatePayments.Click += new System.EventHandler(this.TxtQuatityLatePayments_Click);
            // 
            // panel_late_avaliation
            // 
            this.panel_late_avaliation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel_late_avaliation.Controls.Add(this.label5);
            this.panel_late_avaliation.Controls.Add(this.txtQuantityLateAvaliations);
            this.panel_late_avaliation.Location = new System.Drawing.Point(481, 62);
            this.panel_late_avaliation.Name = "panel_late_avaliation";
            this.panel_late_avaliation.Size = new System.Drawing.Size(428, 259);
            this.panel_late_avaliation.TabIndex = 12;
            this.panel_late_avaliation.Click += new System.EventHandler(this.Panel_late_avaliation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(87, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avaliações vencidas";
            // 
            // txtQuantityLateAvaliations
            // 
            this.txtQuantityLateAvaliations.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityLateAvaliations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.txtQuantityLateAvaliations.Location = new System.Drawing.Point(1, 41);
            this.txtQuantityLateAvaliations.Name = "txtQuantityLateAvaliations";
            this.txtQuantityLateAvaliations.Size = new System.Drawing.Size(424, 120);
            this.txtQuantityLateAvaliations.TabIndex = 7;
            this.txtQuantityLateAvaliations.Text = "-";
            this.txtQuantityLateAvaliations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtQuantityLateAvaliations.Click += new System.EventHandler(this.TxtQuantityLateAvaliations_Click);
            // 
            // panel_inative_student
            // 
            this.panel_inative_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel_inative_student.Controls.Add(this.label7);
            this.panel_inative_student.Controls.Add(this.txtQuantityInativeStudents);
            this.panel_inative_student.Location = new System.Drawing.Point(481, 344);
            this.panel_inative_student.Name = "panel_inative_student";
            this.panel_inative_student.Size = new System.Drawing.Size(428, 259);
            this.panel_inative_student.TabIndex = 11;
            this.panel_inative_student.Click += new System.EventHandler(this.Panel_inative_student_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(118, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alunos inativos";
            // 
            // txtQuantityInativeStudents
            // 
            this.txtQuantityInativeStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityInativeStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(21)))), ((int)(((byte)(86)))));
            this.txtQuantityInativeStudents.Location = new System.Drawing.Point(3, 41);
            this.txtQuantityInativeStudents.Name = "txtQuantityInativeStudents";
            this.txtQuantityInativeStudents.Size = new System.Drawing.Size(424, 120);
            this.txtQuantityInativeStudents.TabIndex = 7;
            this.txtQuantityInativeStudents.Text = "-";
            this.txtQuantityInativeStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtQuantityInativeStudents.Click += new System.EventHandler(this.TxtQuantityInativeStudents_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(936, 651);
            this.Controls.Add(this.panel_late_avaliation);
            this.Controls.Add(this.panel_inative_student);
            this.Controls.Add(this.panel_late_payment);
            this.Controls.Add(this.panel_active_student);
            this.Name = "Home";
            this.Text = "Home";
            this.panel_active_student.ResumeLayout(false);
            this.panel_active_student.PerformLayout();
            this.panel_late_payment.ResumeLayout(false);
            this.panel_late_payment.PerformLayout();
            this.panel_late_avaliation.ResumeLayout(false);
            this.panel_late_avaliation.PerformLayout();
            this.panel_inative_student.ResumeLayout(false);
            this.panel_inative_student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_active_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtQuantityActiveStudents;
        private System.Windows.Forms.Panel panel_late_payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtQuatityLatePayments;
        private System.Windows.Forms.Panel panel_late_avaliation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtQuantityLateAvaliations;
        private System.Windows.Forms.Panel panel_inative_student;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtQuantityInativeStudents;
    }
}