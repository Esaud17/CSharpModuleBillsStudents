using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EOMOD.Controllers;
using EOMOD.Views;

namespace EOMOD
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            DialogResult = DialogResult.Abort;
            toolStripStatusLabel2.Text = Auth.StatusBar;
            statusStrip1.Refresh();
        } 

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
        }
        
        private void OpenBills()
        {
            CobrosAdmin BillsStudents = new CobrosAdmin();
            if (BillsStudents.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenBills();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.OpenBills();
        }
    }
}
