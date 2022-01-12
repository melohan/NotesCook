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
    public partial class frm_ShowRecipeSteps : Form
    {
        private Recipe recipe;
        private int page=1;
        public frm_ShowRecipeSteps(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeIngredients frm_recipeIngredients = new frm_RecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeInfos frm_recipeInfos = new frm_RecipeInfos(recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if(recipe.Steps[(page + 1) * 2 - 1] != null)
            {
                this.page++;
                loadPage();
            }
        }

        private void loadPage()
        {
            grp_Step1.Visible = false;
            grp_Step2.Visible = false;
            lbl_Step1.Visible = false;
            lbl_Step2.Visible = false;

            if(recipe.Steps[page * 2 - 1] != null)
            {
                grp_Step1.Text = ("Etape " + (page * 2 - 1) + " : " + recipe.Steps[page * 2 - 1].Name);
                lbl_Step1.Text = recipe.Steps[page * 2 - 1].Description;
                grp_Step1.Visible = true;
                lbl_Step1.Visible = false;
            }

            if (recipe.Steps[page * 2] != null)
            {
                grp_Step2.Text = ("Etape " + (page * 2) + " : " + recipe.Steps[page * 2].Name);
                lbl_Step2.Text = recipe.Steps[page * 2].Description;
                grp_Step2.Visible = false;
                lbl_Step2.Visible = false;
            }
        }
    }
}
