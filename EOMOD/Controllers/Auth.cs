using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EOMOD.Settings;
using EOMOD.Models;

namespace EOMOD.Controllers
{
    class Auth:UserSession
    {
        private ConnectionODBC CursorDB = new ConnectionODBC();
        public String message;
        public Auth()
        {

        }
        public bool Login()
        {
            if (Validations.DisticnNullEmptyWhiteSpace(Auth.Pwd) && Validations.DisticnNullEmptyWhiteSpace(Auth.User)) {

                CursorDB.CommandSqlText = string.Format("SELECT * FROM Tpas WHERE usuario = '{0}' AND clave = '{1}'", Auth.User, Auth.Pwd);
                OdbcDataReader Reg = CursorDB.ExecuteReadQuery();

                Auth.Session = false;
                if (Reg.Read())
                {
                    Auth.Session = true;
                    Auth.Name = Reg[2].ToString();
                    this.message = string.Format("Bienvenido {0}", Auth.Name);
                    Auth.StatusBar = String.Format("Conectado : [ {0} ]", Auth.Name.ToUpper());
                } else {

                    this.message = "Revise el campo de usuario o de la clave y digite correctamente \n Por favor intente de nuevo ";
                }
                CursorDB.CloseExecuteReadQuery();
            } else {

                Auth.Session = false;
                this.message = "Aún no ha ingresado una credencial de acceso válida";
            }

            return Auth.Session;
        }

        public void DestroySession()
        {
            this.message = string.Format("Sesión del usuario : {0} ha sido cerrada ", Auth.Name);
            Auth.Session = false;
            Auth.Name = String.Empty;

        }

    }
}
