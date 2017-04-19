using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using EOMOD.Settings;
using EOMOD.Models;

namespace EOMOD.Controllers
{
    class BanksController
    {
        private ConnectionODBC CursorDB = new ConnectionODBC();

        public DataTable FindTcuentas()
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT codigob , ncuenta  FROM tcuentas");
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }
    }
}
