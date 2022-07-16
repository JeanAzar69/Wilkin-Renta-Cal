namespace RentaCal
{
    partial class Ver
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
            this.dgvVer = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBfilt = new System.Windows.Forms.Button();
            this.cbBfilt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVer
            // 
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Location = new System.Drawing.Point(219, 15);
            this.dgvVer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.RowHeadersWidth = 51;
            this.dgvVer.Size = new System.Drawing.Size(832, 524);
            this.dgvVer.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBfilt
            // 
            this.txtBfilt.Location = new System.Drawing.Point(16, 47);
            this.txtBfilt.Margin = new System.Windows.Forms.Padding(4);
            this.txtBfilt.Name = "txtBfilt";
            this.txtBfilt.Size = new System.Drawing.Size(195, 28);
            this.txtBfilt.TabIndex = 3;
            this.txtBfilt.Text = "Busqueda Filtrada";
            this.txtBfilt.UseVisualStyleBackColor = true;
            this.txtBfilt.Click += new System.EventHandler(this.txtBfilt_Click);
            // 
            // cbBfilt
            // 
            this.cbBfilt.FormattingEnabled = true;
            this.cbBfilt.Location = new System.Drawing.Point(16, 82);
            this.cbBfilt.Margin = new System.Windows.Forms.Padding(4);
            this.cbBfilt.Name = "cbBfilt";
            this.cbBfilt.Size = new System.Drawing.Size(193, 24);
            this.cbBfilt.TabIndex = 4;
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbBfilt);
            this.Controls.Add(this.txtBfilt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvVer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ver";
            this.Text = "Ver";
            this.Load += new System.EventHandler(this.Ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtBfilt;
        private System.Windows.Forms.ComboBox cbBfilt;
    }
}