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

        /**
         * Constructor
         * @param Recipe
         **/
        public frmRecipeIngredients(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            if (this.recipe.Ingredients.Count == 0)
            {
                this.btnEdit.Visible = false;
            }
        }

        /**
         * Event click of lblRecipe, go to frmRecipeInfos
         **/
        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeInfos frm_recipeInfos = new frmRecipeInfos(this.recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        /**
         * Event click of lblSteps, go to frmShowRecipeSteps
         **/
        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowRecipeSteps form = new frmShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }

        /**
         * When the form is loaded, prepare the data for display
         **/
        private void frmRecipeIngredients_Load(object sender, EventArgs e)
        {
            foreach(Ingredient ingredient in recipe.Ingredients)
            {
                String element = ingredient.Name + "\t\t" + ingredient.Quantity.ToString() +" "+ ingredient.Unit;
                this.lstIngredients.Items.Add(element);
            }
        }

        /**
         *When the selection of lstIngredients changed, pre-filled txtName, TxtUnit and nupQuantity
         **/
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                Ingredient selected = this.recipe.Ingredients.Find(x => x.Name == this.lstIngredients.SelectedItem.ToString().Split('\t')[0]);
                this.txtName.Text = selected.Name;
                this.txtUnit.Text = selected.Unit;
                this.nupQuantity.Value = (decimal)selected.Quantity;
            }
        }

        /**
         * Event click of btnEdit, toggles between edit and locked mode
         **/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(this.btnSave.Visible == false)
            {
                this.lblName.Visible = true;
                this.lblQuantity.Visible = true;
                this.lblUnity.Visible = true;

                this.txtName.Visible = true;
                this.nupQuantity.Visible = true;
                this.txtUnit.Visible = true;

                this.btnSave.Visible = true;
                this.lstIngredients.SelectionMode = (SelectionMode)1;
                this.btnEdit.Text = "Verrouiller";
                this.btnMinus.Visible = true;
                this.btnPlus.Visible = true;
            }
            else
            {
                this.lblName.Visible = false;
                this.lblQuantity.Visible = false;
                this.lblUnity.Visible = false;

                this.txtName.Visible = false;
                this.nupQuantity.Visible = false;
                this.txtUnit.Visible = false;

                this.btnSave.Visible = false;
                this.lstIngredients.SelectionMode = (SelectionMode)0;
                this.btnEdit.Text = "Modifier";
                this.btnMinus.Visible = false;
                this.btnPlus.Visible = false;
            }
        }

        /**
         * Event click of btnSave, save the modification of the ingredient in the database
         **/
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                Ingredient selected = this.recipe.Ingredients.Find(x => x.Name == this.lstIngredients.SelectedItem.ToString().Split('\t')[0]);
                selected.Name = this.txtName.Text;
                selected.Unit = this.txtUnit.Text;
                selected.Quantity = (double)this.nupQuantity.Value;
                this.lstIngredients.Items[lstIngredients.SelectedIndex] = selected.Name + "\t\t" + selected.Quantity.ToString() + " " + selected.Unit;
                this.recipe.Edit();
            }
        }

        /**
         * Event click btnMinus, remove a ingredient from lstIngredients and from the recipe
         **/
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                this.recipe.RemoveIngredientByName(this.lstIngredients.SelectedItem.ToString().Split('\t')[0]);
                this.lstIngredients.Items.Remove(this.lstIngredients.SelectedItem);
                this.recipe.Edit();
            }
        }

        /**
         * Event click of btnPlus, add an Ingredient to lstIngredients and to the recipe
         **/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.recipe.Add(new Ingredient("Nouvelle ingrédient",0,"unité"));
            this.lstIngredients.Items.Add("Nouvelle ingrédient" + "\t\t" + "0" + " unité");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void picLogo1_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
