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
    public partial class resetpass : Form
    {
        SqlConnection con = new SqlConnection();
        public resetpass()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
         
                try
                {

                    conexion();
                    SqlDataAdapter sda = new SqlDataAdapter("select password from LoginTable Where password = '" + txtold.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count.ToString() == "1")
                    {
                        if (txtnuevo.Text == txtconfirmar.Text)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET password = '" + txtconfirmar.Text + "'where password = '" + txtold.Text + "'", con);


                            cmd.ExecuteNonQuery();
                            con.Close();
                            label1.ForeColor = System.Drawing.Color.Green;
                            label1.Text = "Your Password Is Successfully Updated…";
                        }


                        else
                        {
                            label1.ForeColor = System.Drawing.Color.Red;
                            label1.Text = "Su contraseña no está actualizada Por favor, inténtelo de nuevo...";

                        }
                    }
                }

                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        
            public void conexion()
            {
                try
                {
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jenni\\source\\repos\\Proyecto erick\\Proyecto erick\\Login.mdf\";Integrated Security=True";
                    //con.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("error" + ex);
                };
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login(); 
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
