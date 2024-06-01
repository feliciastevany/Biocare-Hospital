namespace ALP_rumah_sakit
{
    partial class Form_Nota
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
            this.cbxnamaPasien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl88 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataharga = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idpas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelpasien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idnota = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.alamatpas = new System.Windows.Forms.Label();
            this.notelppas = new System.Windows.Forms.Label();
            this.namadokter = new System.Windows.Forms.Label();
            this.tanggallahir = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataharga)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxnamaPasien
            // 
            this.cbxnamaPasien.FormattingEnabled = true;
            this.cbxnamaPasien.Location = new System.Drawing.Point(229, 206);
            this.cbxnamaPasien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxnamaPasien.Name = "cbxnamaPasien";
            this.cbxnamaPasien.Size = new System.Drawing.Size(264, 33);
            this.cbxnamaPasien.TabIndex = 35;
            this.cbxnamaPasien.SelectionChangeCommitted += new System.EventHandler(this.cbxnamaPasien_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(628, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "PERSCRIBING PHYSICIANS\'S INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "PATIENT INFORMATION";
            // 
            // lbl88
            // 
            this.lbl88.AutoSize = true;
            this.lbl88.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl88.Location = new System.Drawing.Point(35, 67);
            this.lbl88.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl88.Name = "lbl88";
            this.lbl88.Size = new System.Drawing.Size(578, 54);
            this.lbl88.TabIndex = 32;
            this.lbl88.Text = "MEDICAL BILLING INVOICE";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(44, 1238);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(171, 61);
            this.buttonPrint.TabIndex = 47;
            this.buttonPrint.Text = "PRINT";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click_1);
            // 
            // dataharga
            // 
            this.dataharga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataharga.Location = new System.Drawing.Point(34, 622);
            this.dataharga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataharga.Name = "dataharga";
            this.dataharga.RowHeadersWidth = 51;
            this.dataharga.RowTemplate.Height = 24;
            this.dataharga.Size = new System.Drawing.Size(1088, 405);
            this.dataharga.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(991, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Invoice ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(525, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "DATE";
            // 
            // idpas
            // 
            this.idpas.AutoSize = true;
            this.idpas.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.idpas.Location = new System.Drawing.Point(41, 504);
            this.idpas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idpas.Name = "idpas";
            this.idpas.Size = new System.Drawing.Size(0, 29);
            this.idpas.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(40, 450);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "PATIENT ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(34, 555);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1092, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(34, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1092, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // labelpasien
            // 
            this.labelpasien.AutoSize = true;
            this.labelpasien.Location = new System.Drawing.Point(47, 209);
            this.labelpasien.Name = "labelpasien";
            this.labelpasien.Size = new System.Drawing.Size(147, 25);
            this.labelpasien.TabIndex = 50;
            this.labelpasien.Text = "Patient Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "Phone Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "Doctors Name:";
            // 
            // idnota
            // 
            this.idnota.AutoSize = true;
            this.idnota.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnota.ForeColor = System.Drawing.SystemColors.InfoText;
            this.idnota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idnota.Location = new System.Drawing.Point(1059, 504);
            this.idnota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idnota.Name = "idnota";
            this.idnota.Size = new System.Drawing.Size(0, 29);
            this.idnota.TabIndex = 55;
            this.idnota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.InfoText;
            this.date.Location = new System.Drawing.Point(477, 504);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 29);
            this.date.TabIndex = 56;
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // alamatpas
            // 
            this.alamatpas.AutoSize = true;
            this.alamatpas.Location = new System.Drawing.Point(224, 306);
            this.alamatpas.Name = "alamatpas";
            this.alamatpas.Size = new System.Drawing.Size(0, 25);
            this.alamatpas.TabIndex = 57;
            // 
            // notelppas
            // 
            this.notelppas.AutoSize = true;
            this.notelppas.Location = new System.Drawing.Point(224, 351);
            this.notelppas.Name = "notelppas";
            this.notelppas.Size = new System.Drawing.Size(0, 25);
            this.notelppas.TabIndex = 58;
            // 
            // namadokter
            // 
            this.namadokter.AutoSize = true;
            this.namadokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namadokter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.namadokter.Location = new System.Drawing.Point(799, 204);
            this.namadokter.Name = "namadokter";
            this.namadokter.Size = new System.Drawing.Size(0, 29);
            this.namadokter.TabIndex = 59;
            this.namadokter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tanggallahir
            // 
            this.tanggallahir.AutoSize = true;
            this.tanggallahir.Location = new System.Drawing.Point(224, 256);
            this.tanggallahir.Name = "tanggallahir";
            this.tanggallahir.Size = new System.Drawing.Size(0, 25);
            this.tanggallahir.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(780, 1175);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 35);
            this.label15.TabIndex = 98;
            this.label15.Text = "Total:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbltotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbltotal.Location = new System.Drawing.Point(964, 1175);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(150, 33);
            this.lbltotal.TabIndex = 97;
            this.lbltotal.Text = "Sub-Total";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbltax.Location = new System.Drawing.Point(964, 1107);
            this.lbltax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(62, 31);
            this.lbltax.TabIndex = 96;
            this.lbltax.Text = "Tax";
            this.lbltax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblsub.Location = new System.Drawing.Point(964, 1056);
            this.lblsub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(150, 33);
            this.lblsub.TabIndex = 95;
            this.lblsub.Text = "Sub-Total";
            this.lblsub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(723, 1103);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 35);
            this.label13.TabIndex = 93;
            this.label13.Text = "Tax (10%):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(716, 1054);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 35);
            this.label12.TabIndex = 92;
            this.label12.Text = "Sub-Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(707, 1138);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(415, 25);
            this.label14.TabIndex = 94;
            this.label14.Text = "_______________________________";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.LightYellow;
            this.buttonPay.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPay.Location = new System.Drawing.Point(940, 1251);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(171, 48);
            this.buttonPay.TabIndex = 99;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // Form_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1156, 1329);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tanggallahir);
            this.Controls.Add(this.namadokter);
            this.Controls.Add(this.notelppas);
            this.Controls.Add(this.alamatpas);
            this.Controls.Add(this.date);
            this.Controls.Add(this.idnota);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelpasien);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataharga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idpas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxnamaPasien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl88);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Nota";
            this.Text = "Form_Nota";
            this.Load += new System.EventHandler(this.Form_Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataharga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxnamaPasien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl88;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataharga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idpas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpasien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label idnota;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label alamatpas;
        private System.Windows.Forms.Label notelppas;
        private System.Windows.Forms.Label namadokter;
        private System.Windows.Forms.Label tanggallahir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonPay;
    }
}