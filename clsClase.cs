using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace pryLujan_IEFI
{
    internal class clsClase
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb";
        private string Tabla = "Usuarios";

        public void ListarDS(DataGridView Grilla)
        {
            try
            {
                // Utilizamos 'using' para gestionar automáticamente el cierre de la conexión al finalizar
                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
                {
                    // Abre la conexión a la base de datos
                    conexion.Open();

                    // Configuramos el comando para realizar una consulta directa a la tabla
                    using (OleDbCommand comando = new OleDbCommand(Tabla, conexion))
                    {
                        comando.CommandType = CommandType.TableDirect; // Acceso directo a la tabla

                        // Utilizamos otro 'using' para manejar el adaptador y su conexión con el DataSet
                        using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                        {
                            // Creamos y llenamos un DataSet con los datos de la tabla
                            DataSet DS = new DataSet();
                            adaptador.Fill(DS);

                            // Asignamos los datos del DataSet al DataGridView
                            Grilla.DataSource = DS.Tables[0];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Mostramos un mensaje en caso de que ocurra algún error durante el proceso
                MessageBox.Show(e.ToString());
            }
        }  }
    }
