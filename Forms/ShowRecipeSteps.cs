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
    public partial class frmShowRecipeSteps : Form
    {
        private Recipe recipe;
        private int page=1;
        private Step even;
        private Step odd;

        /**
         * Constructor
         * @param Recipe
         **/
        public frmShowRecipeSteps(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            loadPage();
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
         * Event click of lblRecipe, go to frmRecipeInfos
         **/
        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeInfos frm_recipeInfos = new frmRecipeInfos(recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        /**
         * Event click of btnNext, load the next page
         **/
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.page++;
            loadPage();
        }

        /**
         * Event click of btnPrevious, load the previous page
         **/
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.page--;
            loadPage();
        }

        /**
         * Load the information of the odd step in the form
         **/
        private void loadOdd()
        {
            this.grpStep1.Text = ("Etape " + this.odd.Position + " : " + this.odd.Name);
            this.lblStep1.Text = this.odd.Description;
            this.grpStep1.Visible = true;
            this.lblStep1.Visible = true;

            this.txtNameStep1.Visible = false;
            this.txtStep1.Visible = false;
        }

        /**
         * Load the information of the even step in the form
         **/
        private void loadEven()
        {
            this.grpStep2.Text = ("Etape " + this.even.Position + " : " + this.even.Name);
            this.lblStep2.Text = this.even.Description;
            this.grpStep2.Visible = true;
            this.lblStep2.Visible = true;

            this.txtNameStep2.Visible = false;
            this.txtStep2.Visible = false;
        }

        /**
         * Load the information in the form
         **/
        private void loadPage()
        {
            this.grpStep1.Visible = false;
            this.grpStep2.Visible = false;
            this.lblStep1.Visible = false;
            this.lblStep2.Visible = false;
            this.btnEdit.Text = "Modifier";
            this.btnSave.Visible = false;
            this.btnMinus1.Visible = false;
            this.btnMinus2.Visible = false;
            this.btnPlus1.Visible = false;
            this.btnPlus2.Visible = false;
            this.lblPage.Text = "Page " + this.page;
            this.txtNameStep1.Text = "";
            this.txtNameStep2.Text = "";
            this.txtStep1.Text = "";
            this.txtStep2.Text = "";

            this.odd = this.recipe.Steps.Find(x => x.Position == this.page * 2 - 1);
            this.even = this.recipe.Steps.Find(x => x.Position == this.page * 2);

            if (this.odd != null)
            {
                loadOdd();
            }

            if (this.even != null)
            {
                loadEven();
            }

            this.btnNext.Enabled = (this.recipe.Steps.Find(x => x.Position > this.page * 2) != null);
            this.btnPrevious.Enabled = (this.page != 1);
        }

        /**
         * Event click of btnEdit, toggles between edit and locked mode
         **/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.btnSave.Visible == false)
            {
                this.grpStep1.Text = "";
                this.grpStep2.Text = "";
                this.lblStep1.Visible = false;
                this.lblStep2.Visible = false;
                this.btnEdit.Text = "Verrouiller";
                this.btnSave.Visible = true;

                if (this.odd != null)
                {
                    this.txtNameStep1.Visible = true;
                    this.txtNameStep1.Text = this.odd.Name;

                    this.txtStep1.Visible = true;
                    this.txtStep1.Text = this.odd.Description;
                    this.btnMinus1.Visible = true;
                }

                else
                {
                    this.grpStep1.Visible = true;
                    this.btnPlus1.Visible = true;
                }

                if (this.even != null)
                {
                    this.txtNameStep2.Visible = true;
                    this.txtNameStep2.Text = this.even.Name;

                    this.txtStep2.Visible = true;
                    this.txtStep2.Text = this.even.Description;
                    this.btnMinus2.Visible = true;
                }

                else
                {
                    this.grpStep2.Visible = true;
                    this.btnPlus2.Visible = true;
                }

                if (this.odd != null && this.even != null)
                {
                    this.btnNext.Enabled = true;
                }
            }
            else
            {

                this.btnEdit.Text = "Modifier";
                this.btnSave.Visible = false;
                this.btnMinus1.Visible = false;
                this.btnMinus2.Visible = false;

                loadPage();
            }
        }

        /**
         * Event click of btnSave, save the modification of the step in the database
         **/
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.odd != null)
            {
                this.odd.Name = this.txtNameStep1.Text;
                this.odd.Description = this.txtStep1.Text;
                this.lblStep1.Text = this.odd.Description;
            }
            if (this.even != null)
            {
                this.even.Name = this.txtNameStep2.Text;
                this.even.Description = this.txtStep2.Text;
                this.lblStep2.Text = this.even.Description;
            }
            this.recipe.Edit();
        }

        /**
         * Event click of btnMinus1, remove the odd step of the page in the database
         **/
        private void btnMinus1_Click(object sender, EventArgs e)
        {
            this.recipe.RemoveStepByPosition(this.odd.Position);
            if(this.even == null)
                this.page = 1;
            this.recipe.Edit();
            loadPage();
        }

        /**
         * Event click of btnMinus2, remove the even step of the page in the database
         **/
        private void btnMinus2_Click(object sender, EventArgs e)
        {
            this.recipe.RemoveStepByPosition(this.even.Position);
            if (this.odd == null)
                this.page = 1;
            this.recipe.Edit();
            loadPage();
        }

        /**
         * Event click of btnPlus1, add a step in the database which position = page*2-1
         **/
        private void btnPlus1_Click(object sender, EventArgs e)
        {
            this.recipe.Add(new Step((this.page * 2 - 1), this.txtNameStep1.Text, this.txtStep1.Text));
            this.recipe.Edit();
            loadPage();
        }

        /**
         * Event click of btnPlus2, add a step in the database which position = page*2
         **/
        private void btnPlus2_Click(object sender, EventArgs e)
        {
            this.recipe.Add(new Step((this.page * 2), this.txtNameStep2.Text, this.txtStep2.Text));
            this.recipe.Edit();
            loadPage();
        }
    }
}
