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

<<<<<<< Updated upstream
            //Application.Run(new delReservation());
            // Application.Run(new Regest());
            //Application.Run(new Add_update_del_Stadium());
            //Application.Run(new Login_Form());
<<<<<<< HEAD
            Application.Run(new Player_Data());
=======
            Application.Run(new TeamInformation());
>>>>>>> a4cb71189a69bc1aa373c377906f6a3f8ec9541a
            //Application.Run(new AddYourTeam());
            //Application.Run(new StadiumGalary());
=======
            
            Application.Run(new designForm());
>>>>>>> Stashed changes




        }
    }


}
