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
            frm_RecipeInfos frm_recipeInfos = new frm_RecipeInfos(recipe);
            frm_recipeInfos.ShowDialog();
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

        }
    }
}
