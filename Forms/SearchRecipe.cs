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

        private List<Tag> tags;                  // Tag added in lst
            
        /**
         * Constructor, init tag list
         **/ 
        public SearchRecipe()
        {
            tags  = new List<Tag>();
            InitializeComponent();
        }

        /**
         * Add tag in lstTag
         **/ 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            string tagName = txtTag.Text.ToString();
            lstTag.Items.Add(tagName);
            tags.Add(new Tag(tagName));
            txtTag.Text = "";
        }

        /**
         * Remove tag from lstTag
         * @param object sender
         * @param EventArgs e
         **/
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lstTag.SelectedIndex != -1)
            {
                Tag toRemove = this.tags.Find(x => x.Name == lstTag.SelectedItem.ToString());
                tags.Remove(toRemove);
                lstTag.Items.Remove(lstTag.SelectedItem);
            }

        }

        /**
         * Starts the search and redirects to the display form if all tags are present in a recipe.
         * @param object sender
         * @param EventArgs e
         **/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tags.Count > 0)
            {
                List<Recipe> results = Recipe.All<Recipe>();
                foreach (Tag tag in tags)
                {
                    if (results.Count > 0)
                    {
                        results = results.FindAll(
                        delegate(Recipe r) { 
                        return r.TagMatched(tag); 
                        });
                    }
                }
                if (results.Count > 0)
                {
                    this.displayResult(results);
                }
            }
        }

        /**
         * Close this form and open RecipeList
         * @param List<Recipe> results
         **/
        private void displayResult(List<Recipe> results)
        {
            frmShowRecipeList sr = new frmShowRecipeList(results);
            this.Hide();
            sr.ShowDialog();
            this.Close();
        }

    }

}
