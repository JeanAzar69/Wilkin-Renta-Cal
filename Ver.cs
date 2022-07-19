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
    public partial class Ver : Form
    {
        BDconnect consult = new BDconnect();
        private string dsend;
        private string marcasend;
        private string modelosend;
        private string preciosend;
        private string disponibilidadsend;

        string modificar = "";

        public Ver()
        {
            InitializeComponent();
        }
        private void txtBfilt_Click(object sender, EventArgs e)
        {
            if (txtBuscarFiltro.Text == "")
            {
                MessageBox.Show("Debe colocar datos en la barra de busqueda");
            }
            else 
            {
                                
                dgvVer.DataSource = consult.FilterMarca(txtBuscarFiltro.Text);
            }
        }

        private void Ver_Load(object sender, EventArgs e)
        {
            dgvVer.DataSource = consult.ReadAllDocument();

            while (txtBuscador.Text != "")
            {
                lbHolder.Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modificar = "actualizar";

            txtBuscador.Visible = true;
            btnModificar.Visible = true;
        }

        private void cbDisponibilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbEditor.Visible = false;
            txtBuscarFiltro.Clear();
            dgvVer.DataSource = consult.ReadAllDocument();
            txtBuscarFiltro.Enabled = true;
            lbHolder.Visible = false;
            txtBuscador.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            consult.update(txtBuscador.Text, txtMarca.Text, txtModelo.Text, txtPrecio.Text,cbDisponibilidad.Text);
            gbEditor.Visible = false;
            txtBuscarFiltro.Clear();
            dgvVer.DataSource = consult.ReadAllDocument();
            txtBuscarFiltro.Enabled = true;
            lbHolder.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvVer.DataSource = consult.ReadAllDocument();
            txtBuscarFiltro.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "")
            {
                MessageBox.Show("debe colocar datos dentro del buscador");
            }
            else
            {
                if (consult.search(txtBuscador.Text) == false)
                {
                    MessageBox.Show("Usted coloco el id de forma incorrecta");
                    txtBuscador.Clear();
                }
                else
                {
                    dgvVer.DataSource = consult.FilterId(txtBuscador.Text);
                    gbEditor.Visible = true;

                    if (modificar == "borrar")
                    {
                        txtMarca.Text = dgvVer.Rows[0].Cells[1].Value.ToString();
                        txtModelo.Text = dgvVer.Rows[0].Cells[2].Value.ToString();
                        txtPrecio.Text = dgvVer.Rows[0].Cells[3].Value.ToString();
                        cbDisponibilidad.Text = dgvVer.Rows[0].Cells[4].Value.ToString();

                        txtPrecio.Enabled = false;
                        txtModelo.Enabled = false;
                        cbDisponibilidad.Enabled = false;
                        txtMarca.Enabled = false;
                        btnSave.Visible = false;
                        btnEliminar.Visible = true;
                    }
                    else
                    {
                        txtMarca.Text = dgvVer.Rows[0].Cells[1].Value.ToString();
                        txtModelo.Text = dgvVer.Rows[0].Cells[2].Value.ToString();
                        txtPrecio.Text = dgvVer.Rows[0].Cells[3].Value.ToString();
                        cbDisponibilidad.Text = dgvVer.Rows[0].Cells[4].Value.ToString();
                        txtPrecio.Enabled = true;
                        txtModelo.Enabled = true;
                        cbDisponibilidad.Enabled = true;
                        txtMarca.Enabled = true;
                        btnEliminar.Visible = false;
                        btnSave.Visible = true;
                    }

                
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modificar = "borrar";
            txtBuscador.Visible = true;
            btnModificar.Visible = true;
            lbHolder.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            consult.delete(txtBuscador.Text, txtMarca.Text, txtModelo.Text, txtPrecio.Text, cbDisponibilidad.Text);
            gbEditor.Visible = false;
            txtBuscador.Clear();
            txtBuscarFiltro.Clear();
            txtBuscador.Visible = false;
            dgvVer.DataSource = consult.ReadAllDocument();
            txtBuscarFiltro.Enabled = true;
            lbHolder.Visible = false;
        }
    }
}
