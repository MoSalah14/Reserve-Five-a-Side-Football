﻿using Login_;
using RegertrationPage;
using ReservationPage;
using Reserve__a_Five_a_Side_Football.Database;
using Reserve__a_Five_a_Side_Football.Owner;
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


            
            
            Application.Run(new designForm());





        }
    }


}
