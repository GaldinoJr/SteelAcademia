using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelGymDesktop
{
    class Util
    {
        public static bool ValidaNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                return true;
            else
                return false;
        }

        public static bool ValidaStringSemEspaco(string s)
        {
            if(ValidaString(s) && !s.Contains(" "))
            {
                return true;
            }
            return false;
        }

        public static bool ValidaString(string s)
        {
            return !(s.Equals("") || s == null);
        }

        public static bool ValidaRg(string s)
        {
            String campo = RemoverCaracteres(s);
            return (campo.Length >= 7 && campo.Length <= 9);
        }

        public static bool ValidaCpf(string s)
        {
            String campo = RemoverCaracteres(s);
            return (campo.Length == 11);
        }

        public static bool ValidaTelefone(string s)
        {
            s = RemoverCaracteres(s);
            return ValidaString(s);
        }

        public static String RemoverCaracteres(String s)
        {
            String campo = s.Replace(" ", "").Replace(",", "").Replace("-", "").Replace(".", "");
            return campo;
        }

        public static void ShowMessageWarning(string msg)
        {
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void DisabledCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        public static void EnabledCursor()
        {
            Cursor.Current = Cursors.Default;
        }

        internal static bool ValidaData(DateTime date)
        {
            int currentYear = DateTime.Today.Year;
            if (date.Year > currentYear)
            {
                return false;
            }
            return true;
        }

        internal static bool IsMinor(DateTime datePerson)
        {
            DateTime dateNow = DateTime.Today;
            int yearAdult = dateNow.Year - 18;
            if (datePerson.Year > yearAdult)
            {
                return true;
            }
            else if (datePerson.Year == yearAdult)
            {
                if (datePerson.Month > dateNow.Month)
                {
                    return true;
                }
                else if (datePerson.Month == dateNow.Month)
                {
                    if (datePerson.Day > dateNow.Day)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
