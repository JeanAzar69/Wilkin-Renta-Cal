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
    public partial class Agregar : Form
    {
        BDconnect consult = new BDconnect();
        public Agregar()
        {
            InitializeComponent();
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {

            if (txtMarca.Text == "" || txtModelo.Text == "" || txtPrecio.Text == "" || cbEstatus.Text == "")
            {
                MessageBox.Show("Le faltan datos");
            }
            else
            {
                consult.addCar(txtMarca.Text, txtModelo.Text, txtPrecio.Text, cbEstatus.Text);

                txtMarca.Clear();
                txtModelo.Clear();
                txtPrecio.Clear();
                cbEstatus.Text = "";
                MessageBox.Show("Vehiculo añadido");
            }
            
        }

        //private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsNumber(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
