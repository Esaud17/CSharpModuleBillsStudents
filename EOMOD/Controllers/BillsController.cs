using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;
using EOMOD.Settings;
using EOMOD.Models;

namespace EOMOD.Controllers
{
    class BillsController:BillsModels
    {
        private ConnectionODBC CursorDB = new ConnectionODBC();
        
        public DataTable FindByRegistroCode(String Registro)
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT  mes as Descripción, ncuota as Numero_Cuota, cuota as Valor FROM tmensualidad WHERE registro = '{0}' AND ((ncuota = 0) OR (ncuota = 12)) AND confirmado = 0 ORDER BY ncuota ", Registro);
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }

        public DataTable FindByRegistroNCuenta(String Registro, int Ncuota)
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT  * FROM tmensualidad WHERE registro = '{0}' AND ncuota = {1}", Registro,Ncuota);
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }

        public void UpdateByRegistroNCuenta(String Registro, BillsModels datos)
        {
            CursorDB.CommandSqlText = string.Format("UPDATE tmensualidad SET  ncuenta = '{2}', interes=CCur('{3}'), Total = CCur('{4}'), fechap = '{5}' , cuota=CCur('{6}'), confirmado = True  WHERE registro = '{0}' AND ncuota = {1}", Registro, datos.NumbCouta, datos.Ncuenta, datos.Interes, datos.Total, datos.Fecha.ToString("dd/MM/yyyy hh:mm:ss"), datos.Couta);          
            CursorDB.ExecuteNonQuery();

        }

    }
}
