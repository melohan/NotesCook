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
    public partial class SearchRecipe : Form
    {

        private List<Tag> tags;
        List<Recipe> results;

        public SearchRecipe()
        {
            tags  = new List<Tag>();
            results = new List<Recipe>();
            InitializeComponent();
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            string tagName = txtTag.Text.ToString();
            lstTag.Items.Add(tagName);
            tags.Add(new Tag(tagName));
            txtTag.Text = "";
        }

        private void btmMinus_Click(object sender, EventArgs e)
        {
            if (lstTag.SelectedIndex != -1)
            {
                Tag toRemove = this.tags.Find(x => x.Name == lstTag.SelectedItem.ToString());
                tags.Remove(toRemove);
                lstTag.Items.Remove(lstTag.SelectedItem);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tags.Count > 0)
            {
                List<Recipe> results = new List<Recipe>();
                foreach (Tag tag in tags)
                {
                    if (results.Count > 0)
                    {
                        // TODO find matches
                        /* results = results.FindAll(
                        delegate(Recipe r) { 
                        return r.Tags.Find(match: x => x.Name == tag.Name)?r:null; 
                        });*/
                    }
                }
                if (results.Count > 0)
                {
                    this.displayResult(results);
                }
            }
        }
        
        private void displayResult(List<Recipe> results)
        {
            frmShowRecipeList sr = new frmShowRecipeList(results);
            this.Hide();
            sr.ShowDialog();
            this.Close();
        }

    }

}
