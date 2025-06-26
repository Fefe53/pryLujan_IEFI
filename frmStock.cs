using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLujan_IEFI
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;");
        clsClase stock = new clsClase();
        private void btnStock_Click(object sender, EventArgs e)
        {
            lstStock.Items.Clear(); // Limpiamos primero

            try
            {
                conexion.Open();

                string consulta = "SELECT Nombre, Cantidad FROM Productos";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string nombre = lector["Nombre"].ToString();
                    int stock = Convert.ToInt32(lector["Cantidad"]);
                    lstStock.Items.Add($"{nombre} - Stock: {stock}");
                }

                lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
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
