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

        /**
         * Constructor
         * @param Recipe
         **/
        public frmRecipeInfos(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            loadInformation();
        }

        /**
         * Load the information in the form
         **/
        private void loadInformation()
        {
            this.grpRecipeInfos.Text = this.recipe.Name;
            this.lblNbPersons.Text = "Pour " + this.recipe.NumberOfPersons + " personne";
            if (this.recipe.NumberOfPersons > 1) this.lblNbPersons.Text += "s";

            this.lblTags.Text = "";
            this.lstTag.Items.Clear();

            foreach (Tag tag in this.recipe.Tags)
            {
                this.lblTags.Text += ("#" + tag.Name + " ");
                this.lstTag.Items.Add(tag.Name);
            }
        }

        /**
         * Event click of lblIngredients, go to frmRecipeIngredients
         **/
        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeIngredients frm_recipeIngredients = new frmRecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        /**
         * Event click of lblStep, go to frmShowRecipeSteps
         **/
        private void lblSteps_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowRecipeSteps form = new frmShowRecipeSteps(this.recipe);
            form.ShowDialog();
            this.Close();
        }

        /**
         * Event click of btnDelete, display a confirmation message, if validated delete the recipe and go to frmHome
         **/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir supprimer cette recette ?", "Veuillez confirmer", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                this.recipe.Remove();
                this.Hide();
                frmHome form = new frmHome();
                form.ShowDialog();
                this.Close();
            }
        }

        /**
         * Event click of btnEdit, toggles between edit and information mode
         **/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(this.btnSave.Visible == false)
            {
                this.txtName.Visible = true;
                this.txtName.Text = this.recipe.Name;
                this.txtTag.Visible = true;
                this.nupNbPersons.Visible = true;
                this.nupNbPersons.Value = this.recipe.NumberOfPersons;
                this.lblNewNbPerson.Visible = true;

                this.btnMinus.Visible = true;
                this.btnPlus.Visible = true;
                this.lstTag.Visible = true;
                this.lblTag.Visible = true;

                this.btnSave.Visible = true;


                this.lblNbPersons.Visible = false;
                this.lblTags.Visible = false;
                this.btnEdit.Text = "Verrouiller";
            }
            else
            {
                this.txtName.Visible = false;
                this.txtTag.Visible = false;
                this.nupNbPersons.Visible = false;
                this.lblNewNbPerson.Visible = false;
                this.lstTag.Visible = false;
                this.lblTag.Visible = false;

                this.btnSave.Visible = false;
                this.btnMinus.Visible = false;
                this.btnPlus.Visible = false;

                this.lblNbPersons.Visible = true;
                this.lblTags.Visible = true;
                this.btnEdit.Text = "Modifier";
            }
        }

        /**
         *When the selection of lstTag changed, pre-filled TxtTag
         **/
        private void lstTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstTag.SelectedIndex != -1)
            {
                this.txtTag.Text = this.recipe.Tags.Find(x => x.Name == this.lstTag.SelectedItem.ToString()).Name;
            }
        }

        /**
         * Event click of btnSave, save the modification of the recipe information
         **/
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.recipe.Name = txtName.Text;
            this.recipe.NumberOfPersons = (int)this.nupNbPersons.Value;
            this.grpRecipeInfos.Text = this.recipe.Name;

            
            if (this.lstTag.SelectedIndex != -1)
            {
                Tag selected = this.recipe.Tags.Find(x => x.Name == this.lstTag.SelectedItem.ToString());
                selected.Name = this.txtTag.Text;

                this.lstTag.Items[this.lstTag.SelectedIndex] = selected.Name;
            }

            this.recipe.Edit();

            loadInformation();
        }

        /**
         * Event click of btnMinus, remove a tag from lstTags and from the recipe
         **/
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.lstTag.SelectedIndex != -1)
            {
                this.recipe.RemoveTagByName(this.lstTag.SelectedItem.ToString());
                this.lstTag.Items.Remove(this.lstTag.SelectedItem);
                this.recipe.Edit();
            }
        }

        /**
         * Event click btnPlus, add a tag to lstTags and to the recipe
         **/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.recipe.Add(new Tag("Nouveau tag"));
            this.lstTag.Items.Add("Nouveau tag");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void picLogo1_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
