﻿using NotesCook.Models;
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


        public frmCreateIngredient(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim(',');
            String unit = txtUnit.Text.Trim(',');
            lstIngredient.Items.Add(name + "," + nupQuantity.Value.ToString() + "," + unit);
            recipe.Add(new Ingredient(name,((double)nupQuantity.Value),unit));
            txtName.Text = "";
            nupQuantity.Value = 0;  
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CreateStep cs = new CreateStep(recipe);
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (lstIngredient.SelectedIndex != -1)
            {
                recipe.RemoveIngredientByName(lstIngredient.SelectedItem.ToString().Split(',')[0]);
                lstIngredient.Items.Remove(lstIngredient.SelectedItem);
            }
        }

        private bool btnEnabler()
        {
            String name = txtName.Text.Trim(',');
            if (name != "" && txtUnit.Text.Trim(',') != "")
            {
                foreach (Ingredient ingredient in recipe.Ingredients)
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

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            btnPlus.Enabled = btnEnabler();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnPlus.Enabled = btnEnabler();
        }
    }
}
