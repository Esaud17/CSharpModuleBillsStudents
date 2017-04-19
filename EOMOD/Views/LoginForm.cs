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
using EOMOD.Settings;

namespace EOMOD
{
    public partial class frmLogin : Form
    {

        Auth AuthUser = new Auth();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void txbUser_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txbUser.Text = Validations.DeleteSpecialCharters(txbUser.Text);

            Auth.User = txbUser.Text;
        }

        private void txbPwd_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txbPwd.Text = Validations.DeleteSpecialCharters(txbPwd.Text);
           
            Auth.Pwd = txbPwd.Text;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           
            bool Session = AuthUser.Login();
            
            if (Session)
            {
                MessageBox.Show(this,AuthUser.message, "Confirmación de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmHome _ScreenHome = new frmHome();
                this.Hide();
                if (_ScreenHome.ShowDialog() == DialogResult.OK)
                {
                    AuthUser.DestroySession();
                    this.Dispose();
                }
                else
                {
                    AuthUser.DestroySession();
                    MessageBox.Show(this,AuthUser.message, "Confirmación de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txbPwd.Text = String.Empty;
                    this.txbUser.Text = String.Empty;

                    this.Show();
                }
            } else{
                MessageBox.Show(this,AuthUser.message, "Alerta de Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!Validations.DisticnNullEmptyWhiteSpace(txbUser.Text))
                {
                    errorProvider1.SetError(txbUser , " Campo usuario es requerido");
                }
                else if (!Validations.DisticnNullEmptyWhiteSpace(txbPwd.Text))
                {
                    errorProvider1.SetError(txbPwd, " Campo clave es requerido");
                }
            }
            
        }

        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (e.KeyCode == Keys.Enter)
            {
                if (temp.Name == "txbUser")
                {
                    this.txbPwd.Focus();
                }
                else if (temp.Name == "txbPwd")
                {
                    this.btnOpen.Focus();
                }
            }
        }
    }
}
