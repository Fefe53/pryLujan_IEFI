using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryLujan_IEFI
{
    public partial class frmEliminarUsuario : Form
    {
        public frmEliminarUsuario()
        {
            InitializeComponent();
        }
        OleDbConnection conexion;
        clsClase x = new clsClase();
        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            // Crear la cadena de conexión
            string cadenaConexion = $"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";

            // Inicializar la conexión
            conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            CargarProductos();
            CargarCodigosEnComboBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbIDUsuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un código de producto para eliminar.");
                return;
            }

            string idUsuario = cmbIDUsuario.SelectedItem.ToString();

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea eliminar el producto con Id de Usuario " + idUsuario + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                string sql = "DELETE FROM Usuarios WHERE IdUsuario = ?";

                try
                {
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    using (OleDbCommand cmd = new OleDbCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("?", idUsuario);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                            CargarProductos();              // Recargar el DataGridView
                            CargarCodigosEnComboBox();  // Recargar el ComboBox
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }
        private void CargarProductos()
        {
            string conexionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";
            using (OleDbConnection conexion = new OleDbConnection(conexionString))

                try
                {


                    string sql = "SELECT * FROM Usuarios";
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvUsuarios.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
        }
        private void CargarCodigosEnComboBox()
        {
            string consulta = "SELECT IdUsuario FROM Usuarios";
            OleDbCommand cmd = new OleDbCommand(consulta, conexion);
            OleDbDataReader lector = cmd.ExecuteReader();

            cmbIDUsuario.Items.Clear(); // Limpia los ítems antes de cargar

            while (lector.Read())
            {
                cmbIDUsuario.Items.Add(lector["IDUSUARIO"].ToString());
            }

            lector.Close();
        }
    }
}
