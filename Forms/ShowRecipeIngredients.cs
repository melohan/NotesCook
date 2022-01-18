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
    public partial class frm_RecipeIngredients : Form
    {
        private Recipe recipe;
        public frm_RecipeIngredients(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeInfos frm_recipeInfos = new frm_RecipeInfos(this.recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ShowRecipeSteps form = new frm_ShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }

        private void frm_RecipeIngredients_Load(object sender, EventArgs e)
        {
            foreach(Ingredient ingredient in recipe.Ingredients)
            {
                String element = ingredient.Name + "\t\t" + ingredient.Quantity.ToString() +" "+ ingredient.Unit;
                lst_Ingredients.Items.Add(element);
            }
        }

        private void lst_Ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Ingredients.SelectedIndex != -1)
            {
                Ingredient selected = recipe.Ingredients.Find(x => x.Name == lst_Ingredients.SelectedItem.ToString().Split('\t')[0]);
                txtName.Text = selected.Name;
                txtUnit.Text = selected.Unit;
                nupQuantity.Value = (decimal)selected.Quantity;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(lblName.Visible == false)
            {
                lblName.Visible = true;
                lblQuantity.Visible = true;
                lblUnity.Visible = true;

                txtName.Visible = true;
                nupQuantity.Visible = true;
                txtUnit.Visible = true;

                lst_Ingredients.SelectionMode = (SelectionMode)1;
            }
            else if (lst_Ingredients.SelectedIndex != -1)
            {
                Ingredient selected = recipe.Ingredients.Find(x => x.Name == lst_Ingredients.SelectedItem.ToString().Split('\t')[0]);
                selected.Name = txtName.Text;
                selected.Unit = txtUnit.Text;
                selected.Quantity = (double)nupQuantity.Value;
                lst_Ingredients.Items[lst_Ingredients.SelectedIndex] = selected.Name + "\t\t" + selected.Quantity.ToString() + " " + selected.Unit;
                recipe.Edit();
            }
        }
    }
}
