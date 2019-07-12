using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_game
{
    static class TRexEndlessRunner
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (System.Diagnostics.Process.GetProcessesByName(Application.ProductName).Length > 1)
            {
                MessageBox.Show("Приложение уже запущено");
                return;
            }
            else
            {
                try
                {
                    Application.Run(new Form1());
                }
                catch (Exception information)
                {
                    MessageBox.Show("В приложении возникла ошибка!\n Сообщение:\n" + information.Message);
                }
                Application.Exit();
            }

        }
    }
}