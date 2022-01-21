﻿using System;
using System.Windows.Forms;
using System.Threading;
using NotesCook.Forms;
using NotesCook.Models;

namespace NotesCook
{
    public partial class frm_home : Form
    {

        public frm_home()
        {
            InitializeComponent();
        }

        public void openCreationRecipe(Object obj)
        {
            Application.Run(new frmCreateRecipe());
        }

        // Clos this process and open new thread for recipe 
        private void btn_new_recipe_Click(object sender, EventArgs e)
        {
            frmCreateRecipe cs = new frmCreateRecipe();
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            frmShowRecipeList srl = new frmShowRecipeList(Recipe.All<Recipe>());
            this.Hide();
            srl.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecipe s = new SearchRecipe();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }
    }
}
