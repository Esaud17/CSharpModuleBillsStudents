using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace EOMOD.Settings
{
    class Validations
    {
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public static bool DisticnNullEmptyWhiteSpace(string value)
        {
            bool responce = false;

            if (!String.IsNullOrEmpty(value))
            {

                if (!String.IsNullOrWhiteSpace(value))
                {
                    responce = true;
                }
            }
            return responce;
        }

        public static bool IsNumber(string value)
        {
            bool response = false;

            double result;

            if (double.TryParse(value, out result))
            {
                response = true;
            }

            return response;

        }

        public static string ParamsValidate(string value, string[] elments, int vbegin, int vend )
        {
            foreach (string Params in elments)
            {

                if (value.Substring(vbegin, vend) != Params)
                {
                    value = string.Empty;
                }
            }
            return value;
        }

        public static string DeleteNumbers(string value)
        {
            int vcount = 0;

            foreach (char vchar in value)
            {
                if (char.IsNumber(vchar))
                {
                    value = value.Remove(vcount);
                }

                vcount++;

            }

            return value;
        }

        public static string DeleteCharters(string value)
        {
            int vcount = 1;

            foreach (char vchar in value)
            {
                if (!string.IsNullOrEmpty(vchar.ToString()))
                {
                    if (!char.IsNumber(vchar))
                    {
                        try
                        {
                            value = value.Remove(vcount - 1);
                        }
                        catch (Exception)
                        {
                            value = null;
                        }
                    }

                    vcount++;
                }
            }

            return value;
        }

        public static string MaxLentg(string value, int maxlentg)
        {
            if (value.Length > maxlentg)
            {
                value = value.Remove(maxlentg);
            }
            return value;
        }

        public static bool EmailValidate(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool DataGridViewEmpty(DataGridView grid)
        {
            bool ret = false;

            foreach (DataGridViewRow grows in grid.Rows)
            {
                for (int i = 0; i < grows.Cells.Count; i++)
                {
                    string cat = string.Empty;
                    try
                    {
                        cat = grows.Cells[i].Value.ToString();
                    }
                    catch
                    {
                        cat = string.Empty;
                    }

                    if (string.IsNullOrEmpty(cat))
                    {
                        ret = true;
                    }
                }

            }

            return ret;
        }

        public static bool DeletePunctuations(string value)
        {
            string Exprecion = @"^\w\t\n\x0B\f\r";

            if (Regex.Match(value, Exprecion).Length == 0)
            {
                return false;
            }

            return true;
        }

        public static string DeleteSpecialCharters(string value)
        {
            string aux = value.Trim((",;._-:ç()´}{[]+'`^?¡¿!.$%&/ªº=*¨¬€#~|@<>\\Ç\"·").ToCharArray()).ToLower();
            return aux;
        }
    }
}
