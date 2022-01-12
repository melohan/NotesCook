using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesCook.Forms;
using NotesCook.Database;
using NotesCook.Models;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB dB = new DB("NotesCook","recepe");
            List<Recipe> myrecipe = dB.All<Recipe>();

            Recipe recipe =  myrecipe[0];

            

            Application.Run(new frm_RecipeIngredients(recipe));
            //Application.Run(new frm_home());
        }
    }
}
