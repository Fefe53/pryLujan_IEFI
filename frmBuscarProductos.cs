using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace pryLujan_IEFI
{
    public partial class frmBuscarProductos : Form
    {
        public frmBuscarProductos()
        {
            InitializeComponent();
            CargarProveedores();
            
        }
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;");
        clsClase proveedores = new clsClase();
        
        private void CargarProveedores()
        {
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand("SELECT DISTINCT Proveedor FROM Productos", conexion);
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cmbProveedores.Items.Add(lector["Proveedor"].ToString());
                }

                lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }
        private void MostrarProductos(string proveedor)
        {
            lstProveedores.Items.Clear();

            try
            {
                conexion.Open(); // o AbrirConexion();
                string consulta = "SELECT Nombre, Precio, Cantidad, Categoria FROM Productos WHERE Proveedor = @Proveedor";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Proveedor", proveedor);

                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ListViewItem item = new ListViewItem(lector["Nombre"].ToString());
                    item.SubItems.Add(lector["Precio"].ToString());
                    item.SubItems.Add(lector["Cantidad"].ToString());
                    item.SubItems.Add(lector["Categoria"].ToString() );
                    lstProveedores.Items.Add(item);
                }

                lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccioná un proveedor.");
                return;
            }

            string proveedorSeleccionado = cmbProveedores.SelectedItem.ToString();
            MostrarProductos(proveedorSeleccionado);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.ShowDialog();
            this.Hide();
        }
    }
}
