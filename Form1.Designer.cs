namespace RentaCal
{
    partial class Form1
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(18, 639);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 35);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(140, 639);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(112, 35);
            this.btn_ver.TabIndex = 1;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(260, 639);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(112, 35);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Rentar";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.btn_agregar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Button btnRent;
    }
}

