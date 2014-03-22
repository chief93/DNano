using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Windows
{
    public class Alert
    {
        public static void Notice(string body)
        {
            MessageBox.Show(body, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string body)
        {
            MessageBox.Show(body, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}