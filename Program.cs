﻿using NotesCook.Forms;
using NotesCook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesCook
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Recipe test = Recipe.FindOne<Recipe, string>("Name", "Test2");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_home());
            Application.Run(new frmRecipeIngredients(test));
        }
    }
}
