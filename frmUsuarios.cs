using System;
using System.Collections;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        OleDbConnection  conexion;
        clsClase x = new clsClase();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text))
                
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtIdUsuario.Text, out decimal id))
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

                    string consulta = "INSERT INTO [Usuarios] (IdUsuario, [Nombre Completo], CategoríaRol) " +
                                      "VALUES (?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("?", txtIdUsuario.Text);
                        cmd.Parameters.AddWithValue("?", txtNombre.Text);
                        cmd.Parameters.AddWithValue("?", txtCategoria.Text);
                      

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario agregado correctamente.");
                    CargarUsuarios(); // Refresca el DataGridView
                    LimpiarCampos();   // Limpia las cajas de texto
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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

            // Abrir la conexión a la base de datos
            try
            {
                conexion.Open(); // ABRIR LA CONEXIÓN AQUÍ
                CargarUsuarios();   // Cargar los datos en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
            dgvUsuarios.ColumnCount = 3;
            dgvUsuarios.Columns[0].Name = "IdUsuario";
            dgvUsuarios.Columns[1].Name = "Nombre Completo";
            dgvUsuarios.Columns[2].Name = "CategoríaRol";
            

            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            string conexionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDRRHH.mdb;";
            using (OleDbConnection conexion = new OleDbConnection(conexionString))
            {
                string consulta = "SELECT * FROM Usuarios";
                OleDbCommand cmd = new OleDbCommand(consulta, conexion);
                conexion.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvUsuarios.Rows.Add(
                        reader["IdUsuario"].ToString(),
                        reader["Nombre Completo"].ToString(),
                        reader["CategoríaRol"].ToString()
                        
                    );
                }
                reader.Close();
            }
        }
        private void LimpiarCampos()
        {
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtIdUsuario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Selecciona un Id de Usuario para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return;
            }

            string sql = "UPDATE Usuarios SET NOMBRECOMPLETO = ?, [CATEGORÍAROL] = ? WHERE IDUSUARIO = ?";

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("?", txtNombre.Text);
                    cmd.Parameters.AddWithValue("?", txtCategoria.Text);
                    cmd.Parameters.AddWithValue("?", txtIdUsuario.Text);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario modificado correctamente.");
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }


        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtIdUsuario.Text = fila.Cells["IDUSUARIO"].Value.ToString();
                txtNombre.Text = fila.Cells["NOMBRECOMPLETO"].Value.ToString();
                txtCategoria.Text = fila.Cells["CATEGORÍAROL"].Value.ToString();
                
            }
        }

        
    }
    }

    

