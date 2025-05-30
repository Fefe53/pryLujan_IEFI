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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        clsClase x = new clsClase();
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                 string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos."); return;
            }
            if (!decimal.TryParse(txtIdUsuario.Text, out decimal IdUsuario))
            {
                MessageBox.Show("Número ID inválido.");
                return;
            }

            string usuario = txtIdUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            

            string conexionStr = $"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";

            using (OleDbConnection conexion = new OleDbConnection(conexionStr))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM LogIn WHERE IdUsuario = ? AND Contraseña = ?";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", contrasena);

                        int contador = (int)comando.ExecuteScalar();

                        if (contador > 0)
                        {
                            MessageBox.Show("Login exitoso");
                            frmMenuPrincipal v = new frmMenuPrincipal();
                            v.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }

                    int idUsuario;
                    if (int.TryParse(txtIdUsuario.Text.Trim(), out idUsuario))
                    {
                        string consultaNombre = "SELECT [Nombre Completo] FROM Usuarios WHERE IdUsuario = ?";
                        using (OleDbCommand comandoNombre = new OleDbCommand(consultaNombre, conexion))
                        {
                            comandoNombre.Parameters.AddWithValue("?", idUsuario); 
                            object resultado = comandoNombre.ExecuteScalar();

                            if (resultado != null)
                            {
                                string nombreCompleto = resultado.ToString();

                                frmMenuPrincipal principal = new frmMenuPrincipal();
                                principal.NombreUsuario = nombreCompleto;
                                principal.Show();
                                this.Hide();
                                
                            }
                            else
                            {
                                MessageBox.Show("Usuario autenticado, pero no se encontró su nombre completo.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            pbUsuario.BorderStyle = BorderStyle.None;


        }
    }
    }

