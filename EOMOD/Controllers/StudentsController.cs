using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using EOMOD.Settings;
using EOMOD.Models;

namespace EOMOD.Controllers
{
    class StudentsController: StudentsModels
    {
        private ConnectionODBC CursorDB = new ConnectionODBC();
        
        public DataTable FindAll()
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT  * FROM Talumno");
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }


        public DataTable FindByRegistroCodeForPhilter(String Philter)
        {

            DataTable result = new DataTable();
            if (Validations.DisticnNullEmptyWhiteSpace(Philter)) {
                CursorDB.CommandSqlText = string.Format(
                    "SELECT registro as Registro_Código, pnombre+' '+snombre+' '+papellido+' '+sapellido as Nombre_Completo,sexo as Genero,RNE as Identidad FROM Talumno WHERE {0} ", Philter);
                result = CursorDB.ExecuteAdapterQuery();
            }
            return result;

        }

        public DataTable FindByRegistroCode(String Registro)
        {
            DataTable result = new DataTable();

            CursorDB.CommandSqlText = string.Format("SELECT * FROM Talumno WHERE registro = '{0}' ", Registro);
            result = CursorDB.ExecuteAdapterQuery();
            return result;
        }
    }
}
