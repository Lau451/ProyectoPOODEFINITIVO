using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Capa_Entidad
{
   public class ValidarTxt
    {
        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if(char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled=true;
                return false;
            }
        }
        public static bool TextVacios(TextBox pTxt)
        {
            if(pTxt.Text==String.Empty)
            {
                pTxt.Focus();
                return true;
            }else 
                return false;
        }
        public static bool ValidarEmail(String pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo, 
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
