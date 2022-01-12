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
                lstStep.Items.Add(nupNoStep.Value.ToString() + " " + txtName.Text);
                txtName.Text = "";
                nupNoStep.Value += 1;
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

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (lstStep.SelectedIndex != -1)
            {
                this.recipe.RemoveStepByPosition(Convert.ToInt32(lstStep.SelectedItem.ToString().Split(' ', '1')[0]));
                lstStep.Items.Remove(lstStep.SelectedItem);
            }
        }
    }
}
