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
    
    public partial class rentar : Form
    {
        BDconnect consult = new BDconnect();
        public rentar()
        {
            InitializeComponent();
            dgvRental.DataSource = consult.disponible();
        }

        private void btnWant_Click(object sender, EventArgs e)
        {
            if (consult.rent(txtRent.Text) == true)
            {
                MessageBox.Show("Su carro fue rentado con exito!");
                dgvRental.DataSource = consult.disponible();
                txtRent.Clear();
            }
            else
            {
                MessageBox.Show("INTENTO FALLIDO!");
                txtRent.Clear();
            }
        }
    }
}
