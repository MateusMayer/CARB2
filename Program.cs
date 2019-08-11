using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CARB2
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());
            try
            {
                Application.Run(new Form3());
            }
            catch
            {
                MessageBox.Show("Tente novamente mais tarde");
            }
        }
    }

}
