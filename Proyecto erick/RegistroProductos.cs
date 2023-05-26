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
    public partial class RegistroProductos : Form
    {
        //hola
        SqlConnection con = new SqlConnection();
        public RegistroProductos()
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
            private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion();

                String consulta = "INSERT INTO Registros(Nombre, Descripcion, Stock, Precio) VALUES('" + txtnombrerp.Text + "','" + txtdescripcion.Text + "','" + txtstock.Text + "','" + txtprecio.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado CORRECTAMENTE");
                String consulta2 = "SELECT * FROM Registros";
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, con);
                adaptador.Fill(dt);
                dgregistro.DataSource = dt;
                con.Close();



            }
            catch (SqlException er)
            {
                MessageBox.Show("Error: " + er);

            }
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            Size = new Size(1110, 530);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
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
                dgregistro.DataSource = dt;
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

                String consulta = " DELETE FROM Registros WHERE IdProducto= " + dgregistro.Rows[dgregistro.CurrentRow.Index].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado correctamente :)");

                String consulta2 = "SELECT * FROM Registros";
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta2, con);
                adaptador.Fill(dt);
                dgregistro.DataSource = dt;
                con.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show("Error " + er);

            }
        }
        private ErrorProvider errorProvider1 = new ErrorProvider();
        private bool ValidacionCampos()
        {
            bool ok = true;

            if (txtnombrerp.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnombrerp, "Ingrese un producto.");
            }
            if (txtdescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtdescripcion, "Ingrese la descripcion del producto.");
            }
            if (txtprecio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtprecio, "Ingrese el precio del producto.");
            }
            if (txtstock.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtstock, "Ingrese el stock de los productos.");
            }
            if (txtstock.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtstock, "Ingrese el stock de los productos.");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtnombrerp, "");
            errorProvider1.SetError(txtdescripcion, "");
            errorProvider1.SetError(txtprecio, "");
            errorProvider1.SetError(txtstock, "");
        }
    }
}
