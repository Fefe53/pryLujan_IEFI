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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }
        clsClase X = new clsClase();
        private string connectionString = "Provider = Microsoft.JET.OLEDB.4.0; Data Source =BDRRHH.mdb;Persist Security Info=False;";


        private void btnListar_Click(object sender, EventArgs e)
        {
            X.ListarDS(dgvUsuarios);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal v = new frmMenuPrincipal();
            v.Show();
            this.Hide();
        }
    }
}
