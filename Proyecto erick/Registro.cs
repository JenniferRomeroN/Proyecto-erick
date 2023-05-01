using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proyecto_erick
{
    public partial class Registro : Form
    {
        SqlConnection con = new SqlConnection();
        private SqlDataReader dr;
        SqlCommand cmd;
       
       
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jenni\\OneDrive\\Escritorio\\Proyecto erick\\Proyecto erick\\Database.mdf\";Integrated Security=True");
            con.Open();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            
                if (txtconfirmar.Text != string.Empty || txtcontrasenia.Text != string.Empty || txtnombusuario.Text != string.Empty)
                {
                if (txtcontrasenia.Text == txtconfirmar.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + txtnombusuario.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Nombre de usuario Ya existe por favor intente con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", txtnombusuario.Text);
                        cmd.Parameters.AddWithValue("password", txtcontrasenia.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Su cuenta ha sido creada. Por favor, inicie sesión ahora.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca la misma contraseña. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            login ee = new login();
            ee.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
   
}
