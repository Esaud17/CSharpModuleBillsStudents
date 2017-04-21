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
using EOMOD.Models;

namespace EOMOD.Views
{
    public partial class frmSearchStudents : Form
    {   
        StudentsController ctrStudentds = new StudentsController();
        GradeStudents ctrsGrado = new GradeStudents();
        public frmSearchStudents()
        {
            InitializeComponent();
            this.LoadComboGenero();
            this.loadGrado();

            if (StudentsModels.GetCode)
            {
                DialogResult = DialogResult.OK;
            }
        }
        private void loadGrado()
        {
           DataTable grado =  ctrsGrado.FindAll();

           cbmGrado.DataSource = grado;
           cbmGrado.SelectedIndex = 0;
           cbmGrado.DisplayMember = "grado";
           cbmGrado.ValueMember = "codigog";

        }
        private void LoadComboGenero()
        {
            cbmGenero.DataSource = Enum.GetValues(typeof(StudentsController.Generos));
            cbmGenero.SelectedIndex = 2;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txbName.Text = String.Empty;
            this.txbApellido.Text = String.Empty;
            this.txbIdentidad.Text = String.Empty;
            this.txbRegistroCode.Text = String.Empty;
            this.LoadComboGenero();

            this.btnSearch_Click(sender, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String Philter = String.Empty;

            if (Validations.DisticnNullEmptyWhiteSpace(cbmGrado.SelectedValue.ToString()))
            {
                if (Validations.DisticnNullEmptyWhiteSpace(Philter))
                {
                    Philter += String.Format("AND  Ttalonario.codigog  LIKE '%{0}%'", cbmGrado.SelectedValue.ToString());
                }
                else
                {
                    Philter = String.Format("Ttalonario.codigog LIKE '%{0}%'", cbmGrado.SelectedValue.ToString());
                }

            }

            if (Validations.DisticnNullEmptyWhiteSpace(txbRegistroCode.Text))
            {
                Philter = String.Format("Ttalonario.registro LIKE '%{0}%'", txbRegistroCode.Text);
            }

            if (Validations.DisticnNullEmptyWhiteSpace(txbName.Text))
            {

                if ( Validations.DisticnNullEmptyWhiteSpace(Philter)){
                    Philter += String.Format("AND Talumno.pnombre  LIKE '%{0}%'", txbName.Text);
                }
                else
                {
                    Philter = String.Format("Talumno.pnombre LIKE '%{0}%'", txbName.Text);
                }

            }

            if (Validations.DisticnNullEmptyWhiteSpace(txbApellido.Text))
            {
                if (Validations.DisticnNullEmptyWhiteSpace(Philter))
                {
                    Philter += String.Format("AND Talumno.papellido  LIKE '%{0}%'", txbApellido.Text);
                }
                else
                {
                    Philter = String.Format("Talumno.papellido LIKE '%{0}%'", txbApellido.Text);
                }
            }

            if (Validations.DisticnNullEmptyWhiteSpace(txbIdentidad.Text))
            {
                if (Validations.DisticnNullEmptyWhiteSpace(Philter))
                {
                    Philter += String.Format("AND RNE  LIKE '%{0}%'", txbIdentidad.Text);
                }
                else
                {
                    Philter = String.Format("RNE LIKE '%{0}%'", txbIdentidad.Text);
                }

            }

            if (StudentsController.Generos.Todos != (StudentsController.Generos)cbmGenero.SelectedValue)
            {

                String value = "M";
                if (StudentsController.Generos.Femenino == (StudentsController.Generos)cbmGenero.SelectedValue)
                {
                    value = "F";
                }

                if (Validations.DisticnNullEmptyWhiteSpace(Philter))
                {
                    Philter += String.Format("AND sexo = '{0}'", value);
                }
                else
                {
                    Philter = String.Format("sexo = '{0}'", value);
                }
            }

            dataGridView1.DataSource = ctrStudentds.FindByRegistroCodeForPhilter(Philter);
        }

        private void txbRegistroCode_TextChanged(object sender, EventArgs e)
        {
            String RegistroCode = Validations.DeleteCharters(txbRegistroCode.Text);
            this.txbRegistroCode.Text = RegistroCode;
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {

            String apellidoString = Validations.DeleteNumbers(txbApellido.Text);
            this.txbApellido.Text = apellidoString;
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            String nameString = Validations.DeleteNumbers(txbName.Text);
            this.txbName.Text = nameString;
        }
        
        private void txbIdentidad_TextChanged(object sender, EventArgs e)
        {
            String IdString = Validations.DeleteCharters(txbIdentidad.Text);
            this.txbIdentidad.Text = IdString;
        }

        private void cbmGenero_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cbmGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SelecRegistreDetail_Click(object sender, EventArgs e)
        {
            try
            {
                String registro = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                StudentsModels.Code = registro;

                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No hay registros selecionados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmSearchStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (StudentsModels.GetCode)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
