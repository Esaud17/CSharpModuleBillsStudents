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
    class GradeStudents
    {
        private ConnectionODBC CursorDB = new ConnectionODBC();

        public String getGrado(string codigog)
        {
            String result = String.Empty;

            CursorDB.CommandSqlText = string.Format("SELECT categoria, grado FROM Tgrado WHERE codigog = '{0}'",codigog);
            OdbcDataReader Reg = CursorDB.ExecuteReadQuery();
            if (Reg.Read())
            {
                result = Reg[0].ToString()+" "+Reg[1].ToString();
            }
            CursorDB.CloseExecuteReadQuery();

            return result;
        }

        public DataTable FindAll()
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT categoria, grado, codigog FROM Tgrado");
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }
    }
}
