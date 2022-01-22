using NotesCook.Database;
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
    public partial class frmCreateStep : Form
    {
        private Recipe recipe;

        /**
         * Constructor
         * @param Recipe
         **/
        public frmCreateStep(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            foreach (Step step in this.recipe.Steps)
            {
                this.lstStep.Items.Add(step.Position.ToString() + ". " + step.Name);
            }
        }

        /**
         * Event click of btnPlus, add a new step in the recipe and in lstStep
         **/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.recipe.Add(new Step((int)this.nupNoStep.Value, this.txtName.Text, this.txtDescription.Text));
            this.lstStep.Items.Add(this.nupNoStep.Value.ToString() + ". " + this.txtName.Text);
            this.txtName.Text = "";
            this.nupNoStep.Value += 1;
            this.txtDescription.Text = "";
        }

        /**
         * Event click of btnEnd, create the recipe in the database and return to frm_home
         **/
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.recipe.Create();
            this.Hide();
            frmHome h = new frmHome();
            h.ShowDialog();
            this.Close();
        }

        /**
         * Allows to know if btnPlus should be enabled
         * @return True if btnPlus must be active, otherwise false
         **/
        private bool btnEnabler()
        {
            string name = this.txtName.Text.ToString();
            if (name != "")
            {
                foreach (Step step in this.recipe.Steps)
                {
                    if (this.nupNoStep.Value == step.Position)
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
         * Event click of btnMinus, remove selected step form lstStep and from recipe
         **/
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lstStep.SelectedIndex != -1)
            {
                int position = Convert.ToInt32(this.lstStep.SelectedItem.ToString().Split('.')[0]);
                this.recipe.RemoveStepByPosition(position);
                this.lstStep.Items.Remove(lstStep.SelectedItem);
            }
        }

        /**
         * When text changed in txtName enbale or disable btnPlus
         **/
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.btnPlus.Enabled = btnEnabler();
        }

        /**
         * When value of nupNoStep changed enbale or disable btnPlus
         **/
        private void nupNoStep_ValueChanged(object sender, EventArgs e)
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

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            frmCreateIngredient frm = new frmCreateIngredient(this.recipe);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
