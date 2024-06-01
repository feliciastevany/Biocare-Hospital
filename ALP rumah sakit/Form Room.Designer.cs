namespace ALP_rumah_sakit
{
    partial class Form_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Room));
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.labelChoose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.BackColor = System.Drawing.Color.Teal;
            this.comboBoxChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxChoose.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(354, 61);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(363, 33);
            this.comboBoxChoose.TabIndex = 0;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(80, 208);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersWidth = 82;
            this.dataGridViewRoom.RowTemplate.Height = 33;
            this.dataGridViewRoom.Size = new System.Drawing.Size(912, 475);
            this.dataGridViewRoom.TabIndex = 3;
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.BackColor = System.Drawing.Color.Transparent;
            this.labelChoose.Font = new System.Drawing.Font("Rockwell", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.ForeColor = System.Drawing.Color.MintCream;
            this.labelChoose.Location = new System.Drawing.Point(226, 61);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(122, 33);
            this.labelChoose.TabIndex = 5;
            this.labelChoose.Text = "Choose:";
            // 
            // Form_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 760);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChoose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Room";
            this.Text = "Form_Room";
            this.Load += new System.EventHandler(this.Form_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Label labelChoose;
    }
}