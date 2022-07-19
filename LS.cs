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
    public partial class LS : Form
    {
        public LS()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= panel1.Width)
            {
                timer.Stop();
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
        }

        
    }
}
