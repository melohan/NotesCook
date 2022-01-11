using NotesCook.Database;
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
    public partial class CreateStep : Form
    {
        private Recipe recipe;

        public void setRecipe(Recipe recipe)
        {
            this.recipe = recipe;
        }
        public CreateStep()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtDescription.Text != null)
            {
                this.recipe.Add(new Step((int)nupNoStep.Value,txtName.Text,txtDescription.Text));
                txtName.Text = "";
                nupNoStep.Value = 0;
                txtDescription.Text = "";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DB db = new DB("NotesCook", "recipes");
            db.Insert(this.recipe);
            this.Hide();
            frm_home h = new frm_home();
            h.ShowDialog();
            this.Close();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {

        }

        private void pic_logo1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {

        }

        private void lblSteps_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
