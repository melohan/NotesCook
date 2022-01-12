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
            loadPage();
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
                this.page++;
                loadPage();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            this.page--;
            loadPage();
        }

        private void loadPage()
        {
            grp_Step1.Visible = false;
            grp_Step2.Visible = false;
            lbl_Step1.Visible = false;
            lbl_Step2.Visible = false;

            if(recipe.Steps.Count >= (page * 2 - 1))
            {
                grp_Step1.Text = ("Etape " + (page * 2 - 1) + " : " + recipe.Steps[page * 2 - 2].Name);
                lbl_Step1.Text = recipe.Steps[page * 2 - 2].Description;
                grp_Step1.Visible = true;
                lbl_Step1.Visible = true;
            }

            if (recipe.Steps.Count >= (page * 2))
            {
                grp_Step2.Text = ("Etape " + (page * 2) + " : " + recipe.Steps[page * 2 -1].Name);
                lbl_Step2.Text = recipe.Steps[page * 2 - 1].Description;
                grp_Step2.Visible = true;
                lbl_Step2.Visible = true;
            }

            if (recipe.Steps.Count < ((page+1) * 2 - 1))
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }

            if (page == 1)
            {
                btn_Previous.Enabled = false;
            }
            else
            {
                btn_Previous.Enabled = true;
            }
        }

        
    }
}
