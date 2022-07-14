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
            this.btn_regresar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_regresar2
            // 
            this.btn_regresar2.Location = new System.Drawing.Point(713, 415);
            this.btn_regresar2.Name = "btn_regresar2";
            this.btn_regresar2.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar2.TabIndex = 0;
            this.btn_regresar2.Text = "Regresar";
            this.btn_regresar2.UseVisualStyleBackColor = true;
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_regresar2);
            this.Name = "Ver";
            this.Text = "Ver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar2;
    }
}