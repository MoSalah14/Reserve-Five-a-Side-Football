﻿using RegertrationPage;
using Reserve__a_Five_a_Side_Football.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            // Application.Run(new LeagueForm());
            // Application.Run(new Add_IncomeingPrice());
            // Application.Run(new Regest());
            //Application.Run(new OwnerAddLeague());
            Application.Run(new LeagueForm());


        }
    }
}
