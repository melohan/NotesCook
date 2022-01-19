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
    public partial class frmRecipeIngredients : Form
    {
        private Recipe recipe;
        public frmRecipeIngredients(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            if (this.recipe.Ingredients.Count == 0)
            {
                btnEdit.Visible = false;
            }
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeInfos frm_recipeInfos = new frmRecipeInfos(this.recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowRecipeSteps form = new frmShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }

        private void frmRecipeIngredients_Load(object sender, EventArgs e)
        {
            foreach(Ingredient ingredient in recipe.Ingredients)
            {
                String element = ingredient.Name + "\t\t" + ingredient.Quantity.ToString() +" "+ ingredient.Unit;
                lstIngredients.Items.Add(element);
            }
        }

        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                Ingredient selected = recipe.Ingredients.Find(x => x.Name == lstIngredients.SelectedItem.ToString().Split('\t')[0]);
                txtName.Text = selected.Name;
                txtUnit.Text = selected.Unit;
                nupQuantity.Value = (decimal)selected.Quantity;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lblName.Visible == false)
            {
                lblName.Visible = true;
                lblQuantity.Visible = true;
                lblUnity.Visible = true;

                txtName.Visible = true;
                nupQuantity.Visible = true;
                txtUnit.Visible = true;

                btnSave.Visible = true;
                lstIngredients.SelectionMode = (SelectionMode)1;
                btnEdit.Text = "Verrouiller";
                btnMinus.Visible = true;
            }
            else
            {
                lblName.Visible = false;
                lblQuantity.Visible = false;
                lblUnity.Visible = false;

                txtName.Visible = false;
                nupQuantity.Visible = false;
                txtUnit.Visible = false;

                btnSave.Visible = false;
                lstIngredients.SelectionMode = (SelectionMode)0;
                btnEdit.Text = "Modifier";
                btnMinus.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                Ingredient selected = recipe.Ingredients.Find(x => x.Name == lstIngredients.SelectedItem.ToString().Split('\t')[0]);
                selected.Name = txtName.Text;
                selected.Unit = txtUnit.Text;
                selected.Quantity = (double)nupQuantity.Value;
                lstIngredients.Items[lstIngredients.SelectedIndex] = selected.Name + "\t\t" + selected.Quantity.ToString() + " " + selected.Unit;
                recipe.Edit();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                this.recipe.RemoveIngredientByName(lstIngredients.SelectedItem.ToString().Split('\t')[0]);
                lstIngredients.Items.Remove(lstIngredients.SelectedItem);
                recipe.Edit();
            }
        }
    }
}
