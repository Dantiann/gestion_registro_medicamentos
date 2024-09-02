using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wformsdrogueriatres
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-NE3TVQ9\\SQLEXPRESS;database=drogueriatres;integrated security=true");

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drogueriatresDataSet.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.drogueriatresDataSet.productos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into productos values('"+txtIdproducto.Text+"','"+txtProducto.Text+"','"+txtPresentacion.Text+"','"+txtPrecio.Text+"','"+txtStock.Text+"','"+txtVencimiento.Text+"','"+txtRegistroinvima.Text+"')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro agregado");
            conexion.Close();

            this.productosTableAdapter.Fill(this.drogueriatresDataSet.productos);
            dgvProductos.DataSource = drogueriatresDataSet.productos; //Actualiza la lista cada vez que se oprime un botón
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from productos where idproducto = '" + txtIdproducto.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                txtProducto.Text = lector["producto"].ToString();
                txtPresentacion.Text = lector["presentación"].ToString();
                txtPrecio.Text = lector["precio"].ToString();
                txtStock.Text = lector["stock"].ToString();
                txtVencimiento.Text = lector["vencimiento"].ToString();
                txtRegistroinvima.Text = lector["registroinvima"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el registro");
            }

            lector.Close();
            conexion.Close();

            this.productosTableAdapter.Fill(this.drogueriatresDataSet.productos);
            dgvProductos.DataSource = drogueriatresDataSet.productos;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "update productos set producto = '" + txtProducto.Text + "', presentacion = '" + txtPresentacion.Text + "', precio = '" + txtPrecio.Text + "', stock = '" + txtStock.Text + "', vencimiento = '" + txtVencimiento.Text + "', registroinvima = '" + txtRegistroinvima.Text + "' where idproducto = '" + txtIdproducto.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro actualizado");
            conexion.Close();

            this.productosTableAdapter.Fill(this.drogueriatresDataSet.productos);
            dgvProductos.DataSource = drogueriatresDataSet.productos;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = txtIdproducto.Text;
            string consulta = "DELETE FROM productos WHERE idproducto = @idproducto";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idproducto", idProducto);
            conexion.Open(); // Agregar esta línea
            comando.ExecuteNonQuery();
            conexion.Close();
            this.productosTableAdapter.Fill(this.drogueriatresDataSet.productos);
            dgvProductos.DataSource = drogueriatresDataSet.productos;
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtIdproducto.Text = "";
            txtProducto.Text = "";
            txtPresentacion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtVencimiento.Text = "";
            txtRegistroinvima.Text = "";
            MessageBox.Show("Registro Borrado");
            conexion.Close();

            this.productosTableAdapter.Fill(this.drogueriatresDataSet.productos);
            dgvProductos.DataSource = drogueriatresDataSet.productos;

        }


        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
