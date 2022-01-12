using NotesCook.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace NotesCook.Forms
{
    public partial class CreateRecipe : Form
    {

        private Recipe recipe;

        /**
         * Init Recipe 
         **/
        public CreateRecipe()
        {
            recipe = new Recipe();
            InitializeComponent();
        }

        /**
         * Add Tag
         **/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtTag.Text != "")
            {
                lstTag.Items.Add(txtTag.Text);
                txtTag.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < lstTag.Items.Count; i++)
            {
                this.recipe.Add(new Tag(lstTag.Items[i].ToString()));
            }
            CreateIngredient cr = new CreateIngredient();
            cr.setRecipe(this.recipe);
            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                this.recipe.Name = txtName.Text;
            }
        }

        private void nupNbPersons_ValueChanged(object sender, EventArgs e)
        {
            if (nupNbPersons.Value != recipe.NumberOfPersons && nupNbPersons.Value > 0)
                this.recipe.NumberOfPersons = (int)nupNbPersons.Value;
        }

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if(lstTag.SelectedIndex != -1)
            {
                lstTag.Items.Remove(lstTag.SelectedItem);
            }
        }
    }

}

