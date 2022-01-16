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
            this.recipe.Add(new Step((int)nupNoStep.Value,txtName.Text,txtDescription.Text));
            lstStep.Items.Add(nupNoStep.Value.ToString() + ". " + txtName.Text);
            txtName.Text = "";
            nupNoStep.Value += 1;
            txtDescription.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.recipe.Create();
            this.Hide();
            frm_home h = new frm_home();
            h.ShowDialog();
            this.Close();
        }

        private bool btnEnabler()
        {
            string name = txtName.Text.ToString();
            if (name != "")
            {
                foreach (Step step in recipe.Steps)
                {
                    if (nupNoStep.Value == step.Position)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
                return false;
        }

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (lstStep.SelectedIndex != -1)
            {
                int position = Convert.ToInt32(lstStep.SelectedItem.ToString().Split('.')[0]);
                this.recipe.RemoveStepByPosition(position);
                lstStep.Items.Remove(lstStep.SelectedItem);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnPlus.Enabled = btnEnabler();
        }

        private void nupNoStep_ValueChanged(object sender, EventArgs e)
        {
            btnPlus.Enabled = btnEnabler();
        }
    }
}
