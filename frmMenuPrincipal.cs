using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLujan_IEFI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        clsClase x = new clsClase();
        public string CategoriaUsuario { get; set; }
        public string NombreUsuario
        {
            get { return toolStripStatusLabel.Text; }
            set { toolStripStatusLabel.Text = "" + value; }
        }
        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria v = new frmAuditoria();
            v.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario v = new frmEliminarUsuario();
            v.Show();
            this.Hide();
        }

        private void agregarOModificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProductos productos = new frmAgregarProductos();
            productos.Show();
            this.Hide();
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarProductos busqueda = new frmBuscarProductos();
            busqueda.Show();
            this.Hide();
        }

        private void stockTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.Show();
            this.Hide();
        }
        
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Controlar acceso según categoría
            if (CategoriaUsuario != "Administrador")
            {
                menuAdministrar.Enabled = false; // o Visible = false;
            }

            // Opcional: mostrar nombre del usuario
            toolStripStatusLabel.Text = $"Bienvenido: {NombreUsuario} ({CategoriaUsuario})";
        }
    }
}
