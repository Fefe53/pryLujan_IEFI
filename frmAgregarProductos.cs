using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLujan_IEFI
{
    public partial class frmAgregarProductos : Form
    {
        public frmAgregarProductos()
        {
            InitializeComponent();
        }
        OleDbConnection conexion;
        clsClase clase = new clsClase();
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtIdproducto.Text) ||
                string.IsNullOrWhiteSpace(txtNombreproducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCategoriaproducto.Text) ||
                string.IsNullOrWhiteSpace(txtProveedor.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtIdproducto.Text, out decimal id))
            {
                MessageBox.Show("Número de Id inválido.");
                return;
            }



            string conexionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";
            using (OleDbConnection conexion = new OleDbConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "INSERT INTO [Productos] (IdProducto , Nombre , Cantidad , Precio , Categoria , Proveedor) " +
                                      "VALUES (?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("?", txtIdproducto.Text);
                        cmd.Parameters.AddWithValue("?", txtNombreproducto.Text);
                        cmd.Parameters.AddWithValue("?", txtCantidad.Text);
                        cmd.Parameters.AddWithValue("?", txtPrecio.Text);
                        cmd.Parameters.AddWithValue("?", txtCategoriaproducto.Text);
                        cmd.Parameters.AddWithValue("?", txtProveedor.Text);


                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto agregado correctamente.");
                    CargarProductos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void CargarProductos()
        {
            dgvProductos.Rows.Clear();
            string conexionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";
            using (OleDbConnection conexion = new OleDbConnection(conexionString))
            {
                string consulta = "SELECT * FROM Productos";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                conexion.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvProductos.Rows.Add(
                        reader["IdProducto"].ToString(),
                        reader["Nombre"].ToString(),
                        reader["Cantidad"].ToString(),
                        reader["Precio"].ToString(),
                        reader["Categoria"].ToString(),
                        reader["Proveedor"].ToString()
                    );
                }
                reader.Close();

            }
        }
        private void LimpiarCampos()
        {
            txtIdproducto.Clear();
            txtNombreproducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCategoriaproducto.Clear();
            txtProveedor.Clear();
            txtIdproducto.Focus();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                txtIdproducto.Text = fila.Cells["IdProducto"].Value.ToString();
                txtNombreproducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtCategoriaproducto.Text = fila.Cells["Categoria"].Value.ToString();
                txtProveedor.Text = fila.Cells["Proveedor"].Value.ToString();
            }
        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
            // Establece la ruta de la base de datos
            string rutaBD = Path.Combine(Application.StartupPath, "BDRRHH.mdb");

            // Verifica si el archivo de base de datos existe
            if (!File.Exists(rutaBD))
            {
                MessageBox.Show("Base de datos no encontrada en: " + rutaBD);
                return;
            }

            // Crear la cadena de conexión
            string cadenaConexion = $"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";

            // Inicializar la conexión
            conexion = new OleDbConnection(cadenaConexion);

            dgvProductos.ColumnCount = 6;
            dgvProductos.Columns[0].Name = "IdProducto";
            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[2].Name = "Cantidad";
            dgvProductos.Columns[3].Name = "Precio";
            dgvProductos.Columns[4].Name = "Categoria";
            dgvProductos.Columns[5].Name = "Proveedor";

            // Abrir la conexión a la base de datos
            try
            {
                conexion.Open(); 
                CargarProductos();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.ShowDialog();
            this.Hide();
        }
    }
}