using System;
using System.Globalization;
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
    public partial class CobroDetalle : Form
    {
        BanksController ctrBanck = new BanksController();
        StudentsController ctrStudentds = new StudentsController();
        BillsController ctrBillsStudents = new BillsController();
        GradeStudents ctrGradeStudents = new GradeStudents();

        public CobroDetalle()
        {
            InitializeComponent();

            this.txbRegistroCode.Text = StudentsModels.Code;

            this.loadBanksAccount();
            this.loadBillsNcuota();
            this.loadData();

           // toolTip1.SetToolTip(this.btnCalcTotal, "Calcular Total");
        }

        private void loadBanksAccount()
        {
           DataTable cuentas =  ctrBanck.FindTcuentas();
           cbmBancos.DataSource = cuentas;
           cbmBancos.SelectedIndex = 0;
           cbmBancos.DisplayMember = "ncuenta";
           cbmBancos.ValueMember = "ncuenta";
        }

        private void loadData()
        {
            DataTable Stu = ctrStudentds.FindByRegistroCode(this.txbRegistroCode.Text);
           
            foreach (DataRow row in Stu.Rows)
            {
                StudentsModels.Code = row["registro"].ToString();

                ctrStudentds.Registro = row["registro"].ToString();
                ctrStudentds.Pnombre = row["pnombre"].ToString();
                ctrStudentds.Snombre = row["snombre"].ToString();
                ctrStudentds.Papellido = row["papellido"].ToString();
                ctrStudentds.Sapellido = row["sapellido"].ToString();

                ctrStudentds.Grado = ctrGradeStudents.getGrado(row["codigog"].ToString());

            }

            txbRegistroCode.Text = ctrStudentds.Registro;
            txbName.Text = String.Format("{0} {1} {2} {3}", ctrStudentds.Pnombre, ctrStudentds.Snombre, ctrStudentds.Papellido, ctrStudentds.Sapellido);
            txbGrado.Text = ctrStudentds.Grado;
      
        }


        private void loadBillsNcuota()
        {
            DataTable Bills = ctrBillsStudents.FindByRegistroNCuenta(this.txbRegistroCode.Text,Int32.Parse(BillsModels.Ncuota));

            foreach (DataRow row in Bills.Rows)
            {
                
                ctrBillsStudents.Descripcion = row["mes"].ToString();
                ctrBillsStudents.NumbCouta = row["ncuota"].ToString();
                ctrBillsStudents.Couta = row["cuota"].ToString();
                ctrBillsStudents.Interes = row["interes"].ToString();
                ctrBillsStudents.Total = row["total"].ToString();

            }
            
            txbDescripcion.Text = ctrBillsStudents.Descripcion;
            txbCouta.Text = Math.Round(Decimal.Parse(ctrBillsStudents.Couta), 2).ToString();
            txbInteres.Text = Math.Round(Decimal.Parse(ctrBillsStudents.Interes), 2).ToString();

            getTotal();
        }

        private void getTotal()
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            Double cuota = Double.Parse(ctrBillsStudents.Couta);
            cuota = Double.Parse(cuota.ToString(nfi),CultureInfo.InvariantCulture);
            Double interes = Double.Parse(ctrBillsStudents.Interes);
            interes = Double.Parse(interes.ToString(nfi), CultureInfo.InvariantCulture);

            Double total = cuota + interes;
            
            ctrBillsStudents.Total = (Math.Round(total,2)).ToString(nfi);
            txtTotal.Text = ctrBillsStudents.Total;
        }

        private void ChangedInteres()
        {
            if (Validations.IsNumber(txbInteres.Text)) { 

                if (Validations.DisticnNullEmptyWhiteSpace(this.txbInteres.Text))
                {
                    ctrBillsStudents.Interes = txbInteres.Text;
                }
                else
                {
                    ctrBillsStudents.Interes = "0";
                }

                getTotal();
            }
            else
            {
                ctrBillsStudents.Interes = "0";
                getTotal();

                txbInteres.Text = String.Empty;
            }
        }

        private void cbmBancos_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cbmBancos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txbInteres_Leave(object sender, EventArgs e)
        {
            ChangedInteres();
        }

        private void txbInteres_TextChanged(object sender, EventArgs e)
        {
            ChangedInteres();
        }

        private void CobroDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            BillsModels.Ncuota = String.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BillsModels.Ncuota = String.Empty;
            this.Dispose();
        }
        
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ctrBillsStudents.Fecha = dtpFecha.Value;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ChangedInteres();

            ctrBillsStudents.Fecha = dtpFecha.Value;
            ctrBillsStudents.Ncuenta = cbmBancos.SelectedValue.ToString();
            ctrBillsStudents.UpdateByRegistroNCuenta(ctrStudentds.Registro, ctrBillsStudents);

            MessageBox.Show(this, "Registro de pago realizado", "Confirmación de pago ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnPay.Visible = false;
            //btnCalcTotal.Visible = false;
            btnCancelar.Text = "Salir";

            txbInteres.ReadOnly = true;
            txtTotal.ReadOnly = true;
            
        }

        private void cbmBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrBillsStudents.Ncuenta = cbmBancos.SelectedValue.ToString(); 
        }

        private void txbInteres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangedInteres();
            }
        }

        private void txbInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                ChangedInteres();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangedInteres();
        }
    }
}
