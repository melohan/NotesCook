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
using NotesCook.Database;

namespace NotesCook.Forms
{
    public partial class frm_RecipeInfos : Form
    {
        private Recipe recipe;
        public frm_RecipeInfos(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            grp_recipeInfos.Text = recipe.Name;
            lbl_NbPeople.Text = "Pour " + recipe.NumberOfPersons + " personne";
            if (recipe.NumberOfPersons > 1) lbl_NbPeople.Text += "s";

            foreach(Tag tag in recipe.Tags)
            {
                lblTags.Text += ("#" + tag.Name + " ");
                lstTag.Items.Add(tag.Name);
            }
        }

        private void frm_recipe_Load(object sender, EventArgs e)
        {

        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeIngredients frm_recipeIngredients = new frm_RecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ShowRecipeSteps form = new frm_ShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir supprimer cette recette ?", "Veuillez confirmer", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                this.recipe.Destroy();
                this.Hide();
                frm_home form = new frm_home();
                form.ShowDialog();
                this.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(txtName.Visible == false)
            {
                txtName.Visible = true;
                txtName.Text = recipe.Name;
                txtTag.Visible = true;
                nupNbPersons.Visible = true;
                nupNbPersons.Value = recipe.NumberOfPersons;
                lblNewNbPerson.Visible = true;
                lstTag.Visible = true;

                btnSave.Visible = true;

                lbl_NbPeople.Visible = false;
                lblTags.Visible = false;
                btn_edit.Text = "Verrouiller";
            }
            else
            {
                txtName.Visible = false;
                txtTag.Visible = false;
                nupNbPersons.Visible = false;
                lblNewNbPerson.Visible = false;
                lstTag.Visible = false;

                btnSave.Visible = false;

                lbl_NbPeople.Visible = true;
                lblTags.Visible = true;
                btn_edit.Text = "Modifier";
            }
        }

        private void lstTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTag.SelectedIndex != -1)
            {
                txtTag.Text = recipe.Tags.Find(x => x.Name == lstTag.SelectedItem.ToString()).Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            recipe.Name = txtName.Text;
            recipe.NumberOfPersons = (int)nupNbPersons.Value;
            grp_recipeInfos.Text = recipe.Name;

            
            if (lstTag.SelectedIndex != -1)
            {
                Tag selected = recipe.Tags.Find(x => x.Name == lstTag.SelectedItem.ToString());
                selected.Name = txtTag.Text;
                
                lstTag.Items[lstTag.SelectedIndex] = selected.Name;
            }

            recipe.Edit();

            lblTags.Text = "";
            foreach (Tag tag in recipe.Tags)
            {
                lblTags.Text += ("#" + tag.Name + " ");;
            }
            lbl_NbPeople.Text = "Pour " + recipe.NumberOfPersons + " personne";

            if (recipe.NumberOfPersons > 1)
            {
                lbl_NbPeople.Text += "s";
            }
        }
    }
}
