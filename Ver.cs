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
        public Ver()
        {
            InitializeComponent();
        }

        private void txtBfilt_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Load(object sender, EventArgs e)
        {
            dgvVer.DataSource = consult.ReadAllDocument();
        }
    }
}
