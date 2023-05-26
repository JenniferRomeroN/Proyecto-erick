using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_erick
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnregistrarproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroProductos ee = new RegistroProductos();
            ee.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Size = new Size(1102, 567);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mod = new Form1();
            mod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
