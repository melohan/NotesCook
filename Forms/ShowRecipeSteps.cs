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
    public partial class frm_ShowRecipeSteps : Form
    {
        private Recipe recipe;
        private int page=1;
        Step pair;
        Step impair;
        public frm_ShowRecipeSteps(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            loadPage();
        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeIngredients frm_recipeIngredients = new frm_RecipeIngredients(this.recipe);
            frm_recipeIngredients.ShowDialog();
            this.Close();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RecipeInfos frm_recipeInfos = new frm_RecipeInfos(recipe);
            frm_recipeInfos.ShowDialog();
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
                this.page++;
                loadPage();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            this.page--;
            loadPage();
        }

        private void loadPage()
        {
            grp_Step1.Visible = false;
            grp_Step2.Visible = false;
            lbl_Step1.Visible = false;
            lbl_Step2.Visible = false;

            if (recipe.Steps.Count >= (page * 2 - 1))
            {
                impair = recipe.Steps.Find(x => x.Position == page * 2 - 1);
                grp_Step1.Text = ("Etape " + impair.Position + " : " + impair.Name);
                lbl_Step1.Text = impair.Description;
                grp_Step1.Visible = true;
                lbl_Step1.Visible = true;
            }

            if (recipe.Steps.Count >= (page * 2))
            {
                pair = recipe.Steps.Find(x => x.Position == page * 2);
                grp_Step2.Text = ("Etape " + pair.Position + " : " + pair.Name);
                lbl_Step2.Text = pair.Description;
                grp_Step2.Visible = true;
                lbl_Step2.Visible = true;
            }

            if (recipe.Steps.Count < ((page+1) * 2 - 1))
            {
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Next.Enabled = true;
            }

            if (page == 1)
            {
                btn_Previous.Enabled = false;
            }
            else
            {
                btn_Previous.Enabled = true;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (impair != null)
            {
                if (txtNameStep1.Visible == false)
                {
                    grp_Step1.Text = "";
                    grp_Step2.Text = "";
                    lbl_Step1.Visible = false;
                    lbl_Step2.Visible = false;

                    txtNameStep1.Visible = true;
                    txtNameStep1.Text = impair.Name;

                    txt_step1.Visible = true;
                    txt_step1.Text = impair.Description;

                    if (pair != null)
                    {
                        txtNameStep2.Visible = true;
                        txtNameStep2.Text = pair.Name;
                        txt_step2.Visible = true;
                        txt_step2.Text = pair.Description;
                    }
                   
                    btn_edit.Text = "Verrouiller";
                    btnSave.Visible = true;
                }
                else
                {
                    if (pair != null)
                    {
                        grp_Step2.Text = ("Etape " + pair.Position + " : " + pair.Name);
                        lbl_Step2.Visible = true;
                        txt_step2.Visible = false;
                        txtNameStep2.Visible = false;
                    }

                    grp_Step1.Text = ("Etape " + impair.Position + " : " + impair.Name);
                    lbl_Step1.Visible = true;
                    txtNameStep1.Visible = false;
                    txt_step1.Visible = false;

                    btn_edit.Text = "Modifier";
                    btnSave.Visible = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (impair != null)
            {
                impair.Name = txtNameStep1.Text;
                impair.Description = txt_step1.Text;
                lbl_Step1.Text = impair.Description;
            }
            if (pair != null)
            {
                pair.Name = txtNameStep2.Text;
                pair.Description = txt_step2.Text;
                lbl_Step2.Text = pair.Description;
            }

            recipe.Edit();
        }
    }
}
