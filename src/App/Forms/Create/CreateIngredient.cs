using NotesCook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesCook.Forms
{
    public partial class frmCreateIngredient : Form
    {
        private Recipe recipe;

        /**
         * Constructor
         * @param Recipe
         **/
        public frmCreateIngredient(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();

            foreach(Ingredient ingredient in this.recipe.Ingredients)
            {
                this.lstIngredient.Items.Add(ingredient.Name + "," + ingredient.Quantity.ToString() + "," + ingredient.Unit);
            }
        }

        /**
         * Event click of btnPlus, add an ingredient to the recipe and to lstIngredient
         **/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            String name = this.txtName.Text.Trim(',');
            String unit = this.txtUnit.Text.Trim(',');
            this.lstIngredient.Items.Add(name + "," + this.nupQuantity.Value.ToString() + "," + unit);
            this.recipe.Add(new Ingredient(name,((double)this.nupQuantity.Value),unit));
            this.txtName.Text = "";
            this.nupQuantity.Value = 0;  
        }

        /**
         * Event click of btnNext, move to the form CreateStep
         **/
        private void btnNext_Click(object sender, EventArgs e)
        {
            frmCreateStep cs = new frmCreateStep(recipe);
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }

        /**
         * Event click btnMinus, remove an ingredient from lstIngredient and from recipe
         **/
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.lstIngredient.SelectedIndex != -1)
            {
                this.recipe.RemoveIngredientByName(this.lstIngredient.SelectedItem.ToString().Split(',')[0]);
                this.lstIngredient.Items.Remove(lstIngredient.SelectedItem);
            }
        }

        /**
         * Allows to know if btnPlus should be enabled
         * @return True if btnPlus must be active, otherwise false
         **/
        private bool btnEnabler()
        {
            String name = this.txtName.Text.Trim(',');
            if (name != "" && this.txtUnit.Text.Trim(',') != "")
            {
                foreach (Ingredient ingredient in this.recipe.Ingredients)
                {
                    if (name == ingredient.Name)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
                return false;
        }

        /**
         * When text changed in txtUnit enbale or disable btnPlus
         **/
        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            this.btnPlus.Enabled = btnEnabler();
        }

        /**
         * When text changed in txtUnit enbale or disable btnPlus
         **/
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.btnPlus.Enabled = btnEnabler();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void pic_logo1_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            frmCreateRecipe frm = new frmCreateRecipe(this.recipe);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            frmCreateStep frm = new frmCreateStep(this.recipe);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
