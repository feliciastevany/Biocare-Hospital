namespace ALP_rumah_sakit
{
    partial class Form_InsDoct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InsDoct));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecialis = new System.Windows.Forms.ComboBox();
            this.cbalatkelamin = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtnamaDokter = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inserttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(43, 345);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 45);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Spesialis";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Harga";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Dokter";
            // 
            // cbSpecialis
            // 
            this.cbSpecialis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbSpecialis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbSpecialis.FormattingEnabled = true;
            this.cbSpecialis.Location = new System.Drawing.Point(301, 196);
            this.cbSpecialis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSpecialis.Name = "cbSpecialis";
            this.cbSpecialis.Size = new System.Drawing.Size(346, 33);
            this.cbSpecialis.TabIndex = 13;
            // 
            // cbalatkelamin
            // 
            this.cbalatkelamin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbalatkelamin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbalatkelamin.FormattingEnabled = true;
            this.cbalatkelamin.Location = new System.Drawing.Point(301, 128);
            this.cbalatkelamin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbalatkelamin.Name = "cbalatkelamin";
            this.cbalatkelamin.Size = new System.Drawing.Size(346, 33);
            this.cbalatkelamin.TabIndex = 14;
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHarga.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtHarga.Location = new System.Drawing.Point(301, 254);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(346, 31);
            this.txtHarga.TabIndex = 11;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // txtnamaDokter
            // 
            this.txtnamaDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnamaDokter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtnamaDokter.Location = new System.Drawing.Point(301, 67);
            this.txtnamaDokter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamaDokter.Name = "txtnamaDokter";
            this.txtnamaDokter.Size = new System.Drawing.Size(346, 31);
            this.txtnamaDokter.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(16, 718);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 52);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 673);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSpecialis);
            this.panel1.Controls.Add(this.cbalatkelamin);
            this.panel1.Controls.Add(this.txtHarga);
            this.panel1.Controls.Add(this.txtnamaDokter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(375, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 430);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(418, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 798);
            this.panel2.TabIndex = 44;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(3);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserttoolStripMenuItem,
            this.removetoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(80, 20, 20, 10);
            this.menuStrip2.Size = new System.Drawing.Size(1433, 66);
            this.menuStrip2.TabIndex = 45;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // inserttoolStripMenuItem
            // 
            this.inserttoolStripMenuItem.Name = "inserttoolStripMenuItem";
            this.inserttoolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.inserttoolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.inserttoolStripMenuItem.Text = "Insert";
            this.inserttoolStripMenuItem.Click += new System.EventHandler(this.inserttoolStripMenuItem_Click_1);
            // 
            // removetoolStripMenuItem
            // 
            this.removetoolStripMenuItem.Name = "removetoolStripMenuItem";
            this.removetoolStripMenuItem.Padding = new System.Windows.Forms.Padding(100, 0, 8, 0);
            this.removetoolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.removetoolStripMenuItem.Text = "Remove";
            this.removetoolStripMenuItem.Click += new System.EventHandler(this.removetoolStripMenuItem_Click_1);
            // 
            // Form_InsDoct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1433, 958);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_InsDoct";
            this.Text = "Form_InsDoct";
            this.Load += new System.EventHandler(this.Form_InsDoct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecialis;
        private System.Windows.Forms.ComboBox cbalatkelamin;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtnamaDokter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inserttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removetoolStripMenuItem;
    }
}