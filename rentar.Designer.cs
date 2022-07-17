namespace RentaCal
{
    partial class rentar
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
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.btnWant = new System.Windows.Forms.Button();
            this.txtRent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRental
            // 
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(0, 234);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.RowHeadersWidth = 51;
            this.dgvRental.Size = new System.Drawing.Size(801, 214);
            this.dgvRental.TabIndex = 0;
            // 
            // btnWant
            // 
            this.btnWant.Location = new System.Drawing.Point(333, 179);
            this.btnWant.Name = "btnWant";
            this.btnWant.Size = new System.Drawing.Size(196, 23);
            this.btnWant.TabIndex = 1;
            this.btnWant.Text = "Quiero rentar";
            this.btnWant.UseVisualStyleBackColor = true;
            this.btnWant.Click += new System.EventHandler(this.btnWant_Click);
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(287, 137);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(287, 22);
            this.txtRent.TabIndex = 2;
            // 
            // rentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.btnWant);
            this.Controls.Add(this.dgvRental);
            this.Name = "rentar";
            this.Text = "rentar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.Button btnWant;
        private System.Windows.Forms.TextBox txtRent;
    }
}