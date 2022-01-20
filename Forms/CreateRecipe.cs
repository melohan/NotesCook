using NotesCook.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace NotesCook.Forms
{
    public partial class frmCreateRecipe : Form
    {

        private Recipe recipe;

        public frmCreateRecipe()
        {
            recipe = new Recipe();
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string tagName = txtTag.Text.ToString();
            lstTag.Items.Add(tagName);
            this.recipe.Add(new Tag(tagName));
            txtTag.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.recipe.Name = txtName.Text;
            this.recipe.NumberOfPersons = (int)nupNbPersons.Value;

            frmCreateIngredient cr = new frmCreateIngredient(recipe);

            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (lstTag.SelectedIndex != -1)
            {
                this.recipe.RemoveTagByName(lstTag.SelectedItem.ToString());
                lstTag.Items.Remove(lstTag.SelectedItem);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.ToString() != "")
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            string tagName = txtTag.Text.ToString();
            if (tagName != "")
            {
                foreach (Tag tag in recipe.Tags)
                {
                    if (tagName == tag.Name)
                    {
                        btnPlus.Enabled = false;
                        return;
                    }
                }
                btnPlus.Enabled = true;
            }
            else
                btnPlus.Enabled = false;
        }
    }
}

