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

        public static bool ValidaString(string s)
        {
            return !(s.Equals("") || s == null);
        }

        public static bool ValidaRg(string s)
        {
            String campo = RemoverCaracteres(s);
            return (campo.Length < 8);
        }

        public static bool ValidaCpf(string s)
        {
            String campo = RemoverCaracteres(s);
            return (campo.Length < 11);
        }

        private static String RemoverCaracteres(String s)
        {
            String campo = s.Replace(" ", "").Replace(",", "").Replace("-", "");
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
    }
}
