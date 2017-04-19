using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EOMOD.Settings;
using EOMOD.Models;
using System.Data;

namespace EOMOD.Models
{
    class StudentsModels
    {
        public enum Generos
        {
           Femenino = 'F',
           Masculino = 'M',
           Todos = 'T' ,
        }

        public static String Code { get; set; }
        public static bool GetCode { get; set; }

        public String Registro  { get; set; }
        public String Pnombre { get; set; }
        public String Snombre { get; set; }
        public String Papellido { get; set; }
        public String Sapellido { get; set; }
        public Byte[] Fotografia { get; set; }
        public String Sexo { get; set; }
        public String Grado { get; set; }

        public String Telefono { get; set; }

        public String Direccion { get; set; }
        public String Madre { get; set; }

        public String Padre { get; set; }

        public String MadreTelefono { get; set; }
        public String PadreTelefono { get; set; }
    }
}
