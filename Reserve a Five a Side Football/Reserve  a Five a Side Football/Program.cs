using RegertrationPage;
using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
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
            Application.Run(new Player_Data());

            //Application.Run(new Add_IncomeingPrice());
            //Reserve_a_Five_a_Side context = new Reserve_a_Five_a_Side();

            //var x = context.Stadium.Select(e => e.Stad_Name).ToList();
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
