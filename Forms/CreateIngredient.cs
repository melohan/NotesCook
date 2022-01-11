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
            if (txtName.Text != null && txtUnit.Text != null)
            {
                this.recipe.Add(new Ingredient(txtName.Text, (int)nupQuantity.Value,txtUnit.Text));
                txtName.Text = "";
                nupQuantity.Value = 0;
                txtUnit.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CreateStep cs = new CreateStep();
            cs.setRecipe(this.recipe);
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }
    }
}
