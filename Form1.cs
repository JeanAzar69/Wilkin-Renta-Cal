using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar fa = new Agregar();
            fa.ShowDialog();
            fa = null;
            this.Show();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver fv = new Ver();
            fv.ShowDialog();
            fv = null;
            this.Show();
        }
    }
}
