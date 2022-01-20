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
    public partial class frmRecipeInfos : Form
    {
        private Recipe recipe;
        public frmRecipeInfos(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            loadInformation();
        }

        private void loadInformation()
        {
            grpRecipeInfos.Text = recipe.Name;
            lblNbPersons.Text = "Pour " + recipe.NumberOfPersons + " personne";
            if (recipe.NumberOfPersons > 1) lblNbPersons.Text += "s";

            lblTags.Text = "";
            lstTag.Items.Clear();

            foreach (Tag tag in recipe.Tags)
            {
                lblTags.Text += ("#" + tag.Name + " ");
                lstTag.Items.Add(tag.Name);
            }
        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeIngredients frm_recipeIngredients = new frmRecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowRecipeSteps form = new frmShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnSave.Visible == false)
            {
                txtName.Visible = true;
                txtName.Text = recipe.Name;
                txtTag.Visible = true;
                nupNbPersons.Visible = true;
                nupNbPersons.Value = recipe.NumberOfPersons;
                lblNewNbPerson.Visible = true;

                btnMinus.Visible = true;
                btnPlus.Visible = true;
                lstTag.Visible = true;
                lblTag.Visible = true;

                btnSave.Visible = true;
                

                lblNbPersons.Visible = false;
                lblTags.Visible = false;
                btnEdit.Text = "Verrouiller";
            }
            else
            {
                txtName.Visible = false;
                txtTag.Visible = false;
                nupNbPersons.Visible = false;
                lblNewNbPerson.Visible = false;
                lstTag.Visible = false;
                lblTag.Visible = false;

                btnSave.Visible = false;
                btnMinus.Visible = false;
                btnPlus.Visible = false;

                lblNbPersons.Visible = true;
                lblTags.Visible = true;
                btnEdit.Text = "Modifier";
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
            grpRecipeInfos.Text = recipe.Name;

            
            if (lstTag.SelectedIndex != -1)
            {
                Tag selected = recipe.Tags.Find(x => x.Name == lstTag.SelectedItem.ToString());
                selected.Name = txtTag.Text;
                
                lstTag.Items[lstTag.SelectedIndex] = selected.Name;
            }

            recipe.Edit();

            loadInformation();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lstTag.SelectedIndex != -1)
            {
                this.recipe.RemoveTagByName(lstTag.SelectedItem.ToString());
                lstTag.Items.Remove(lstTag.SelectedItem);
                recipe.Edit();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            recipe.Add(new Tag("Nouveau tag"));
            lstTag.Items.Add("Nouveau tag");
        }
    }
}
