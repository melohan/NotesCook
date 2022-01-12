using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesCook.Models;

namespace NotesCook.Forms
{
    public partial class frm_RecipeInfos : Form
    {
        private Recipe recipe;
        public frm_RecipeInfos(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            grp_recipeInfos.Text = recipe.Name;
            lbl_NbPeople.Text = "Pour " + recipe.NumberOfPersons + " personne";
            if (recipe.NumberOfPersons > 1) lbl_NbPeople.Text += "s";

            foreach(Tag tag in recipe.Tags)
            {
                lblTags.Text += ("#" + tag.Name + " ");
            }
        }

        private void frm_recipe_Load(object sender, EventArgs e)
        {

        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeIngredients frm_recipeIngredients = new frm_RecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ShowRecipeSteps form = new frm_ShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }
    }
}
