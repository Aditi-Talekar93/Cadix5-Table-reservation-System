using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codathon_draft
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Form2_gallery());
            //Application.Run(new Form3_about());
            //Application.Run(new Form4_contact());
            //Application.Run(new Form5_res());
            //Application.Run(new Form6_menu());
            //Application.Run(new Form7_rev());

        }
    }
}
