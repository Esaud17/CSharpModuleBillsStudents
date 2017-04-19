using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EOMOD.Settings;
using EOMOD.Models;
using EOMOD.Controllers;

namespace EOMOD.Views
{
    public partial class CobrosAdmin : Form
    {
        StudentsController ctrStudentds = new StudentsController();
        BillsController ctrBillsStudents = new BillsController();
        GradeStudents ctrGradeStudents = new GradeStudents();
        public CobrosAdmin()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            DataTable Stu = ctrStudentds.FindByRegistroCode(this.txbRegistroCode.Text);
            DataTable Bill = ctrBillsStudents.FindByRegistroCode(this.txbRegistroCode.Text);

            foreach (DataRow row in Stu.Rows)
            {
                StudentsModels.Code = row["registro"].ToString();

                ctrStudentds.Registro = row["registro"].ToString();
                ctrStudentds.Pnombre = row["pnombre"].ToString();
                ctrStudentds.Snombre = row["snombre"].ToString();
                ctrStudentds.Papellido = row["papellido"].ToString();
                ctrStudentds.Sapellido = row["sapellido"].ToString();

                ctrStudentds.Sexo = row["sexo"].ToString();
                ctrStudentds.Grado = ctrGradeStudents.getGrado(row["codigog"].ToString());

            }

            txbName.Text = String.Format("{0} {1} {2} {3}", ctrStudentds.Pnombre, ctrStudentds.Snombre, ctrStudentds.Papellido, ctrStudentds.Sapellido);
            txbGenero.Text = ctrStudentds.Sexo;
            txbGrado.Text = ctrStudentds.Grado;
            dataGridView1.DataSource = Bill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validations.DisticnNullEmptyWhiteSpace(this.txbRegistroCode.Text))
            {
                loadData();
            }
            else
            {
                StudentsModels.GetCode = true;

                frmSearchStudents screenphilter = new frmSearchStudents();
                if (screenphilter.ShowDialog() == DialogResult.OK)
                {
                    StudentsModels.GetCode = false;
                    txbRegistroCode.Text = StudentsModels.Code;
                    loadData();
                }
            }
        }

        private void txbRegistroCode_TextChanged(object sender, EventArgs e)
        {
            String RegistroCode = Validations.DeleteCharters(txbRegistroCode.Text);

            this.txbRegistroCode.Text = RegistroCode;
            ctrStudentds.Registro = RegistroCode;
        }

        private void CobrosAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentsController.Code = String.Empty;
            StudentsModels.GetCode = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String ncuota = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            StudentsModels.Code = ctrStudentds.Registro;
            BillsModels.Ncuota = ncuota;
          
            CobroDetalle screenCobroDetalle = new CobroDetalle();
            if (screenCobroDetalle.ShowDialog() == DialogResult.OK)
            {

            }

            loadData();


        }
    }
}
