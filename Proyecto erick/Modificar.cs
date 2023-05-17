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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        String id;
        public Form1()
        {
            InitializeComponent();
        }
        public void conexion()
        {
            try
            {
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jenni\\source\\repos\\Proyecto erick\\Proyecto erick\\Database.mdf\";Integrated Security=True";
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(1110, 530);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion();

                String consulta2 = "SELECT * FROM Registros";
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, con);
                adaptador.Fill(dt);
                dgactualizar.DataSource = dt;
                con.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show("Error " + er);

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion();

                String consulta = " DELETE FROM Registros WHERE IdProducto= " + dgactualizar.Rows[dgactualizar.CurrentRow.Index].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente :)");

                String consulta2 = "SELECT * FROM Registros";
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, con);
                adaptador.Fill(dt);
                dgactualizar.DataSource = dt;
                con.Close();
                //txtnombre.Clear();
                //txtcel.Clear();
                //txtcorreo.Clear();
                //txtdir.Clear();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error " + er);

            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion();

                String consulta = "UPDATE Registros SET Nombre='" + txtnombre.Text + "', Despcricion='" + txtdescripcion.Text + "', Stock='" + txtstock.Text + "', Precio='" + txtprecio.Text + "' WHERE idProducto=" + id;
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
                String consulta2 = "SELECT * FROM Registros";
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, con);
                adaptador.Fill(dt);
                dgactualizar.DataSource = dt;
                con.Close();
            }
            catch (SqlException er)
            {
                MessageBox.Show("Error: " + er);

            }
        }

        private void dgactualizar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgactualizar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnombre.Text = dgactualizar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdescripcion.Text = dgactualizar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtstock.Text = dgactualizar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtprecio.Text = dgactualizar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void bntclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
