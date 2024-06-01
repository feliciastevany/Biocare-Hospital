namespace ALP_rumah_sakit
{
    partial class Form_InsNurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InsNurse));
            this.txtnamaperawat = new System.Windows.Forms.TextBox();
            this.cbalatkelamin = new System.Windows.Forms.ComboBox();
            this.cbLantai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inserttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnamaperawat
            // 
            this.txtnamaperawat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnamaperawat.Location = new System.Drawing.Point(307, 43);
            this.txtnamaperawat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamaperawat.Name = "txtnamaperawat";
            this.txtnamaperawat.Size = new System.Drawing.Size(346, 31);
            this.txtnamaperawat.TabIndex = 11;
            // 
            // cbalatkelamin
            // 
            this.cbalatkelamin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbalatkelamin.FormattingEnabled = true;
            this.cbalatkelamin.Location = new System.Drawing.Point(307, 104);
            this.cbalatkelamin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbalatkelamin.Name = "cbalatkelamin";
            this.cbalatkelamin.Size = new System.Drawing.Size(346, 33);
            this.cbalatkelamin.TabIndex = 13;
            // 
            // cbLantai
            // 
            this.cbLantai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbLantai.FormattingEnabled = true;
            this.cbLantai.Location = new System.Drawing.Point(307, 172);
            this.cbLantai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLantai.Name = "cbLantai";
            this.cbLantai.Size = new System.Drawing.Size(346, 33);
            this.cbLantai.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nama Perawat";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lantai Perawat";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(49, 321);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbLantai);
            this.panel1.Controls.Add(this.cbalatkelamin);
            this.panel1.Controls.Add(this.txtnamaperawat);
            this.panel1.Location = new System.Drawing.Point(375, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 450);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(40, 711);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 52);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 673);
            this.dataGridView1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(378, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 791);
            this.panel2.TabIndex = 47;
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
            this.menuStrip2.TabIndex = 48;
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
            // Form_InsNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1433, 922);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_InsNurse";
            this.Text = "Form_InsNurse";
            this.Load += new System.EventHandler(this.Form_InsNurse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnamaperawat;
        private System.Windows.Forms.ComboBox cbalatkelamin;
        private System.Windows.Forms.ComboBox cbLantai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inserttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removetoolStripMenuItem;
    }
}