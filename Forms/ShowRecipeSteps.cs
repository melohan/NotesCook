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
        Step pair;
        Step impair;
        public frmShowRecipeSteps(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            loadPage();
        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeIngredients frm_recipeIngredients = new frmRecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipeInfos frm_recipeInfos = new frmRecipeInfos(recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.page++;
            loadPage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.page--;
            loadPage();
        }

        private void loadImpair()
        {
            grpStep1.Text = ("Etape " + impair.Position + " : " + impair.Name);
            lblStep1.Text = impair.Description;
            grpStep1.Visible = true;
            lblStep1.Visible = true;

            txtNameStep1.Visible = false;
            txtStep1.Visible = false;
        }

        private void loadPaire()
        {
            grpStep2.Text = ("Etape " + pair.Position + " : " + pair.Name);
            lblStep2.Text = pair.Description;
            grpStep2.Visible = true;
            lblStep2.Visible = true;

            txtNameStep2.Visible = false;
            txtStep2.Visible = false;
        }

        private void loadPage()
        {
            grpStep1.Visible = false;
            grpStep2.Visible = false;
            lblStep1.Visible = false;
            lblStep2.Visible = false;
            btnEdit.Text = "Modifier";
            btnSave.Visible = false;
            btnMinus1.Visible = false;
            btnMinus2.Visible = false;
            lblPage.Text = "Page " + page;

            impair = recipe.Steps.Find(x => x.Position == page * 2 - 1);
            pair = recipe.Steps.Find(x => x.Position == page * 2);

            if (impair != null)
            {
                loadImpair();
            }

            if (pair != null)
            {
                loadPaire();
            }
            
            btnNext.Enabled = (recipe.Steps.Find(x => x.Position > page * 2) != null);
            btnPrevious.Enabled = (page != 1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (impair != null || pair != null)
            {
                if (btnSave.Visible == false)
                {
                    grpStep1.Text = "";
                    grpStep2.Text = "";
                    lblStep1.Visible = false;
                    lblStep2.Visible = false;

                    if (impair != null)
                    {
                        txtNameStep1.Visible = true;
                        txtNameStep1.Text = impair.Name;

                        txtStep1.Visible = true;
                        txtStep1.Text = impair.Description;
                        btnMinus1.Visible = true;
                    }

                    if (pair != null)
                    {
                        txtNameStep2.Visible = true;
                        txtNameStep2.Text = pair.Name;

                        txtStep2.Visible = true;
                        txtStep2.Text = pair.Description;
                        btnMinus2.Visible = true;
                    }
                   
                    btnEdit.Text = "Verrouiller";
                    btnSave.Visible = true;
                }
                else
                {

                    btnEdit.Text = "Modifier";
                    btnSave.Visible = false;
                    btnMinus1.Visible = false;
                    btnMinus2.Visible = false;

                    if (pair != null)
                    {
                        loadPaire();
                    }

                    if(impair != null)
                    {
                        loadImpair();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (impair != null)
            {
                impair.Name = txtNameStep1.Text;
                impair.Description = txtStep1.Text;
                lblStep1.Text = impair.Description;
            }
            if (pair != null)
            {
                pair.Name = txtNameStep2.Text;
                pair.Description = txtStep2.Text;
                lblStep2.Text = pair.Description;
            }
            recipe.Edit();
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            this.recipe.RemoveStepByPosition(impair.Position);
            if(pair == null)
                page = 1;
            recipe.Edit();
            loadPage();
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            this.recipe.RemoveStepByPosition(pair.Position);
            if (impair == null)
                page = 1;
            recipe.Edit();
            loadPage();
        }
    }
}
