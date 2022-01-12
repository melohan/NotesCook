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
    public partial class CreateIngredient : Form
    {
        private Recipe recipe;

        public void setRecipe(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public CreateIngredient()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtUnit.Text != "")
            {
                lstIngredient.Items.Add(txtName.Text + " " + nupQuantity.Value.ToString() + " " + txtUnit.Text);
                txtName.Text = "";
                nupQuantity.Value = 0;
                txtUnit.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstIngredient.Items.Count; i++)
            {
                string[] ingredient = lstIngredient.Items[i].ToString().Split(' ', '3', (char)StringSplitOptions.RemoveEmptyEntries);
                this.recipe.Ingredients.Add(new Ingredient(ingredient[0], Convert.ToInt32(ingredient[1]), ingredient[2]));
            
            }
            CreateStep cs = new CreateStep();
            cs.setRecipe(this.recipe);
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (lstIngredient.SelectedIndex != -1)
            {
                for (int i = lstIngredient.SelectedItems.Count - 1; i >= 0; i--)
                    lstIngredient.Items.Remove(lstIngredient.SelectedItems[i]);
            }
        }
    }
}
