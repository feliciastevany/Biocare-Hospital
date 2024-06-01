namespace ALP_rumah_sakit
{
    partial class Form_Pasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pasien));
            this.dgvPasien = new System.Windows.Forms.DataGridView();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasien
            // 
            this.dgvPasien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPasien.ColumnHeadersHeight = 46;
            this.dgvPasien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPasien.Location = new System.Drawing.Point(90, 140);
            this.dgvPasien.Name = "dgvPasien";
            this.dgvPasien.RowHeadersWidth = 82;
            this.dgvPasien.Size = new System.Drawing.Size(914, 603);
            this.dgvPasien.TabIndex = 0;
            // 
            // cbxName
            // 
            this.cbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxName.BackColor = System.Drawing.Color.SlateGray;
            this.cbxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxName.ForeColor = System.Drawing.SystemColors.Window;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(41, 60);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(826, 33);
            this.cbxName.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(878, 57);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 43);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Location = new System.Drawing.Point(997, 57);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(73, 42);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // Form_Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 786);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.dgvPasien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pasien";
            this.Text = "Form_Pasien";
            this.Load += new System.EventHandler(this.Form_Pasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasien;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAll;
    }
}