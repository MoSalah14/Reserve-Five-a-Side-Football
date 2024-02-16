using Login_;
using RegertrationPage;
using ReservationPage;
using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

            //Application.Run(new delReservation());
            // Application.Run(new Regest());
            //Application.Run(new Add_update_del_Stadium());
            //Application.Run(new Login_Form());
            Application.Run(new  DeleteResrvation());
            //Application.Run(new AddYourTeam());
            //Application.Run(new StadiumGalary());




        }
    }

   
}
