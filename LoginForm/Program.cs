﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms


{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static void Main(params string[] parameters)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
