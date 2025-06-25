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
        public string NombreUsuario
        {
            get { return toolStripStatusLabel.Text; }
            set { toolStripStatusLabel.Text = "Bienvenido, " + value; }
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
    }
}
