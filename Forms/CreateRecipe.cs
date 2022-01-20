﻿using NotesCook.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace NotesCook.Forms
{
    public partial class frmCreateRecipe : Form
    {

        private Recipe recipe;

        /**
         * Constructor
         **/
        public frmCreateRecipe()
        {
            this.recipe = new Recipe();
            InitializeComponent();
        }

        /**
         * Event of the btnPlus, allow to add a new tag
         **/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            string tagName = this.txtTag.Text.ToString();
            this.lstTag.Items.Add(tagName);
            this.recipe.Add(new Tag(tagName));
            this.txtTag.Text = "";
        }

        /**
         * Event of the btnNext, move to the form CreateIngredient
         **/
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.recipe.Name = this.txtName.Text;
            this.recipe.NumberOfPersons = (int)this.nupNbPersons.Value;

            frmCreateIngredient cr = new frmCreateIngredient(recipe);

            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        /**
         * Event of the btnMinus, allow to remove tag
         **/
        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (this.lstTag.SelectedIndex != -1)
            {
                this.recipe.RemoveTagByName(lstTag.SelectedItem.ToString());
                this.lstTag.Items.Remove(lstTag.SelectedItem);
            }
        }

        /**
         * Check that txtName is empty, if so it is impossible to proceed to the next step
         **/
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtName.Text.ToString() != "")
                this.btnNext.Enabled = true;
            else
                this.btnNext.Enabled = false;
        }


        /**
         * Check that txtTag is not empty, and that it contains a tag not already added to the recipe, if so allow the use of btnPlus
         **/
        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            string tagName = this.txtTag.Text.ToString();
            if (tagName != "")
            {
                foreach (Tag tag in this.recipe.Tags)
                {
                    if (tagName == tag.Name)
                    {
                        this.btnPlus.Enabled = false;
                        return;
                    }
                }
                this.btnPlus.Enabled = true;
            }
            else
                this.btnPlus.Enabled = false;
        }
    }
}

