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

namespace Proyecto_erick
{
    public partial class login : Form
    {
        //Alexs mi novia hermosa
        SqlCommand cmd;
        SqlConnection con = new SqlConnection();
        private SqlDataReader dr;

        public login()
        {
            InitializeComponent();
        }
       
        bool moves = false;
       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        { 
            if (txtclave.Text != string.Empty || txtusuario.Text != string.Empty)
            {

                if (txtclave.Text != string.Empty || txtusuario.Text != string.Empty)
                {

                    cmd = new SqlCommand("select * from LoginTable where username='" + txtusuario.Text + "' and password='" + txtclave.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No hay cuenta disponible con este nombre de usuario y contraseña. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, introduzca el valor en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        
    }
    

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;


        }

        private void clave_TextChanged(object sender, EventArgs e)
        {
            txtclave.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void iniciosesion_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jenni\\OneDrive\\Escritorio\\Proyecto erick\\Proyecto erick\\Database.mdf\";Integrated Security=True");
            con.Open();
        }

        private void btncuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registration = new Registro();
            registration.ShowDialog();
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            moves = true;
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (moves == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            moves= false;
        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {
            pbocultar.BringToFront();
            txtclave.PasswordChar = '\0';
        }

        private void pbocultar_Click(object sender, EventArgs e)
        {
            pbmostrar.BringToFront();
            txtclave.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();
        }
    }
}
