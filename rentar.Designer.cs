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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.btnWant = new System.Windows.Forms.Button();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRental
            // 
            this.dgvRental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Apercu Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(91)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(124)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.EnableHeadersVisualStyles = false;
            this.dgvRental.Location = new System.Drawing.Point(12, 59);
            this.dgvRental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.RowHeadersVisible = false;
            this.dgvRental.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Apercu Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(124)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(91)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRental.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRental.Size = new System.Drawing.Size(847, 467);
            this.dgvRental.TabIndex = 0;
            // 
            // btnWant
            // 
            this.btnWant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(91)))), ((int)(((byte)(62)))));
            this.btnWant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWant.Font = new System.Drawing.Font("Apercu Pro", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnWant.Location = new System.Drawing.Point(687, 9);
            this.btnWant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWant.Name = "btnWant";
            this.btnWant.Size = new System.Drawing.Size(172, 42);
            this.btnWant.TabIndex = 1;
            this.btnWant.Text = "Quiero Rentar";
            this.btnWant.UseVisualStyleBackColor = false;
            this.btnWant.Click += new System.EventHandler(this.btnWant_Click);
            // 
            // txtRent
            // 
            this.txtRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRent.Location = new System.Drawing.Point(12, 13);
            this.txtRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(669, 19);
            this.txtRent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(91)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 2);
            this.panel1.TabIndex = 3;
            // 
            // rentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(885, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.btnWant);
            this.Controls.Add(this.dgvRental);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Panel panel1;
    }
}