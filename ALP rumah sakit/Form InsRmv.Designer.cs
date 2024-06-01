namespace ALP_rumah_sakit
{
    partial class Form_InsRmv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InsRmv));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDokter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtptglkluar = new System.Windows.Forms.DateTimePicker();
            this.dtptglmsk = new System.Windows.Forms.DateTimePicker();
            this.cbhub = new System.Windows.Forms.ComboBox();
            this.cbJnsKmr = new System.Windows.Forms.ComboBox();
            this.cbDokter = new System.Windows.Forms.ComboBox();
            this.cbalatkelamin = new System.Windows.Forms.ComboBox();
            this.txtkota = new System.Windows.Forms.TextBox();
            this.txtnopj = new System.Windows.Forms.TextBox();
            this.txtnotelp = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.dtptgllahir = new System.Windows.Forms.DateTimePicker();
            this.txtnamapj = new System.Windows.Forms.TextBox();
            this.txtnamapasien = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelremove = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelremove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(305, 784);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 48);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(46, 379);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(46, 606);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Jenis Kamar";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(49, 712);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "Hubungan";
            // 
            // lblDokter
            // 
            this.lblDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDokter.AutoSize = true;
            this.lblDokter.BackColor = System.Drawing.Color.Transparent;
            this.lblDokter.Location = new System.Drawing.Point(46, 559);
            this.lblDokter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDokter.Name = "lblDokter";
            this.lblDokter.Size = new System.Drawing.Size(75, 25);
            this.lblDokter.TabIndex = 32;
            this.lblDokter.Text = "Dokter";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(46, 504);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tanggal Keluar";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(46, 440);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tanggal Masuk";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(46, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kota";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(46, 659);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "No.Telp PJ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(46, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "No.Telp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(46, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nama Penanggung Jawab";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nama Pasien";
            // 
            // dtptglkluar
            // 
            this.dtptglkluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtptglkluar.Location = new System.Drawing.Point(346, 488);
            this.dtptglkluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtptglkluar.Name = "dtptglkluar";
            this.dtptglkluar.Size = new System.Drawing.Size(356, 31);
            this.dtptglkluar.TabIndex = 22;
            // 
            // dtptglmsk
            // 
            this.dtptglmsk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtptglmsk.Location = new System.Drawing.Point(346, 432);
            this.dtptglmsk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtptglmsk.Name = "dtptglmsk";
            this.dtptglmsk.Size = new System.Drawing.Size(356, 31);
            this.dtptglmsk.TabIndex = 23;
            // 
            // cbhub
            // 
            this.cbhub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbhub.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbhub.FormattingEnabled = true;
            this.cbhub.Location = new System.Drawing.Point(346, 706);
            this.cbhub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbhub.Name = "cbhub";
            this.cbhub.Size = new System.Drawing.Size(356, 33);
            this.cbhub.TabIndex = 21;
            // 
            // cbJnsKmr
            // 
            this.cbJnsKmr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbJnsKmr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbJnsKmr.FormattingEnabled = true;
            this.cbJnsKmr.Location = new System.Drawing.Point(346, 596);
            this.cbJnsKmr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbJnsKmr.Name = "cbJnsKmr";
            this.cbJnsKmr.Size = new System.Drawing.Size(356, 33);
            this.cbJnsKmr.TabIndex = 20;
            // 
            // cbDokter
            // 
            this.cbDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbDokter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbDokter.FormattingEnabled = true;
            this.cbDokter.Location = new System.Drawing.Point(346, 542);
            this.cbDokter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDokter.Name = "cbDokter";
            this.cbDokter.Size = new System.Drawing.Size(356, 33);
            this.cbDokter.TabIndex = 19;
            // 
            // cbalatkelamin
            // 
            this.cbalatkelamin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbalatkelamin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbalatkelamin.FormattingEnabled = true;
            this.cbalatkelamin.Location = new System.Drawing.Point(346, 374);
            this.cbalatkelamin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbalatkelamin.Name = "cbalatkelamin";
            this.cbalatkelamin.Size = new System.Drawing.Size(356, 33);
            this.cbalatkelamin.TabIndex = 18;
            // 
            // txtkota
            // 
            this.txtkota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtkota.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtkota.Location = new System.Drawing.Point(346, 263);
            this.txtkota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkota.Name = "txtkota";
            this.txtkota.Size = new System.Drawing.Size(356, 31);
            this.txtkota.TabIndex = 17;
            // 
            // txtnopj
            // 
            this.txtnopj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnopj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtnopj.Location = new System.Drawing.Point(346, 654);
            this.txtnopj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnopj.Name = "txtnopj";
            this.txtnopj.Size = new System.Drawing.Size(356, 31);
            this.txtnopj.TabIndex = 16;
            this.txtnopj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotelp_KeyPress);
            // 
            // txtnotelp
            // 
            this.txtnotelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnotelp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtnotelp.Location = new System.Drawing.Point(346, 317);
            this.txtnotelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.Size = new System.Drawing.Size(356, 31);
            this.txtnotelp.TabIndex = 15;
            this.txtnotelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotelp_KeyPress);
            // 
            // txtalamat
            // 
            this.txtalamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtalamat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtalamat.Location = new System.Drawing.Point(346, 204);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(356, 31);
            this.txtalamat.TabIndex = 14;
            // 
            // dtptgllahir
            // 
            this.dtptgllahir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtptgllahir.Location = new System.Drawing.Point(346, 140);
            this.dtptgllahir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtptgllahir.Name = "dtptgllahir";
            this.dtptgllahir.Size = new System.Drawing.Size(356, 31);
            this.dtptgllahir.TabIndex = 13;
            // 
            // txtnamapj
            // 
            this.txtnamapj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnamapj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtnamapj.Location = new System.Drawing.Point(346, 82);
            this.txtnamapj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamapj.Name = "txtnamapj";
            this.txtnamapj.Size = new System.Drawing.Size(356, 31);
            this.txtnamapj.TabIndex = 12;
            // 
            // txtnamapasien
            // 
            this.txtnamapasien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnamapasien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtnamapasien.Location = new System.Drawing.Point(346, 23);
            this.txtnamapasien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamapasien.Name = "txtnamapasien";
            this.txtnamapasien.Size = new System.Drawing.Size(356, 31);
            this.txtnamapasien.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(38, 748);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 48);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(80, 20, 20, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1475, 66);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(100, 0, 8, 0);
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblDokter);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtptglkluar);
            this.panel1.Controls.Add(this.dtptglmsk);
            this.panel1.Controls.Add(this.cbhub);
            this.panel1.Controls.Add(this.cbJnsKmr);
            this.panel1.Controls.Add(this.cbDokter);
            this.panel1.Controls.Add(this.cbalatkelamin);
            this.panel1.Controls.Add(this.txtkota);
            this.panel1.Controls.Add(this.txtnopj);
            this.panel1.Controls.Add(this.txtnotelp);
            this.panel1.Controls.Add(this.txtalamat);
            this.panel1.Controls.Add(this.dtptgllahir);
            this.panel1.Controls.Add(this.txtnamapj);
            this.panel1.Controls.Add(this.txtnamapasien);
            this.panel1.Location = new System.Drawing.Point(345, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 848);
            this.panel1.TabIndex = 42;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelremove
            // 
            this.panelremove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelremove.BackColor = System.Drawing.Color.Transparent;
            this.panelremove.Controls.Add(this.dataGridView1);
            this.panelremove.Controls.Add(this.btnDelete);
            this.panelremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelremove.Location = new System.Drawing.Point(331, 88);
            this.panelremove.Name = "panelremove";
            this.panelremove.Size = new System.Drawing.Size(837, 879);
            this.panelremove.TabIndex = 43;
            this.panelremove.Visible = false;
            this.panelremove.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(653, 673);
            this.dataGridView1.TabIndex = 41;
            // 
            // Form_InsRmv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1475, 992);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelremove);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_InsRmv";
            this.Text = "Form_InsRmv";
            this.Load += new System.EventHandler(this.Form_InsRmv_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelremove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDokter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtptglkluar;
        private System.Windows.Forms.DateTimePicker dtptglmsk;
        private System.Windows.Forms.ComboBox cbhub;
        private System.Windows.Forms.ComboBox cbJnsKmr;
        private System.Windows.Forms.ComboBox cbDokter;
        private System.Windows.Forms.ComboBox cbalatkelamin;
        private System.Windows.Forms.TextBox txtkota;
        private System.Windows.Forms.TextBox txtnopj;
        private System.Windows.Forms.TextBox txtnotelp;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.DateTimePicker dtptgllahir;
        private System.Windows.Forms.TextBox txtnamapj;
        private System.Windows.Forms.TextBox txtnamapasien;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelremove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}