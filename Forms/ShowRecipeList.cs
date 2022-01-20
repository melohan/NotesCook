using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using NotesCook.Models;
using NotesCook.Forms;


namespace NotesCook.Forms
{
    public partial class frmShowRecipeList : Form
    {
        private int page;
        private List<Recipe> recipes;
        private OrderedDictionary groups;
        private OrderedDictionary labels;
        public frmShowRecipeList()
        {
            this.recipes = Recipe.All<Recipe>();
            this.page = 1;
            InitializeComponent();
            this.groups = new OrderedDictionary();
            this.labels = new OrderedDictionary();
            this.ListElements();
            this.LoadPage();
        }

        private void ShowRecipeList_Load(object sender, EventArgs e)
        {
            this.grpRecipe1.MouseClick += GrpRecipe1_MouseClick;
            this.grpRecipe2.MouseClick += GrpRecipe2_MouseClick;
            this.grpRecipe3.MouseClick += GrpRecipe3_MouseClick;
            this.grpRecipe4.MouseClick += GrpRecipe4_MouseClick;
        }

        

        private void ListElements()
        {
            this.groups.Add("grp1",grpRecipe1);
            this.groups.Add("grp2", grpRecipe2);
            this.groups.Add("grp3", grpRecipe3);
            this.groups.Add("grp4", grpRecipe4);

            this.labels.Add("lbl11", lblTag11);
            this.labels.Add("lbl12", lblTag12);
            this.labels.Add("lbl13", lblTag13);
            this.labels.Add("lbl14", lblTag14);
            this.labels.Add("lbl21", lblTag21);
            this.labels.Add("lbl22", lblTag22);
            this.labels.Add("lbl23", lblTag23);
            this.labels.Add("lbl24", lblTag24);
            this.labels.Add("lbl31", lblTag31);
            this.labels.Add("lbl32", lblTag32);
            this.labels.Add("lbl33", lblTag33);
            this.labels.Add("lbl34", lblTag34);
            this.labels.Add("lbl41", lblTag41);
            this.labels.Add("lbl42", lblTag42);
            this.labels.Add("lbl43", lblTag43);
            this.labels.Add("lbl44", lblTag44);

        }

        private void LoadPage()
        {
            // Hide everything
            grpRecipe1.Visible = false;
            lblTag11.Visible = false;
            lblTag12.Visible = false;
            lblTag13.Visible = false;
            lblTag14.Visible = false;

            grpRecipe2.Visible = false;
            lblTag21.Visible = false;
            lblTag22.Visible = false;
            lblTag23.Visible = false;
            lblTag24.Visible = false;

            grpRecipe3.Visible = false;
            lblTag31.Visible = false;
            lblTag32.Visible = false;
            lblTag33.Visible = false;
            lblTag34.Visible = false;

            grpRecipe4.Visible = false;
            lblTag41.Visible = false;
            lblTag42.Visible = false;
            lblTag43.Visible = false;
            lblTag44.Visible = false;

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            for (int i = 0; i <= 3; i++)
            {
                if (this.recipes.Count >= ((4 * this.page) - (3-i)))
                {
                    ((GroupBox)groups["grp" + (i+1).ToString()]).Text = this.recipes[(4 * this.page) - (3-i) - 1].Name;

                    ((GroupBox)groups["grp" + (i + 1).ToString()]).Visible = true;

                   for (int y = 0; y <= 3 && y+1 <= recipes[((4 * this.page) - (3 - i) - 1)].Tags.Count(); y++)
                    {
                        ((Label)labels["lbl" + (i + 1) + (y + 1)]).Text = recipes[((4 * this.page) - (3 - i) - 1)].Tags[y].Name;
                        ((Label)labels["lbl" + (i + 1) + (y + 1)]).Visible = true;
                    }

                }
            }

            if(this.page != 1)
            {
                btnPrevious.Enabled = true;
            }

            if(4 * (this.page + 1) - 3 <= this.recipes.Count)
            {
                btnNext.Enabled = true;
            }

            
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.page--;
            this.LoadPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.page++;
            this.LoadPage();
        }

        private void GrpRecipe1_MouseClick(Object sender, MouseEventArgs e)
        {
            this.Hide();
            frmRecipeInfos fri = new frmRecipeInfos(this.recipes[(4 * this.page) - 3 - 1]);
            fri.ShowDialog();
            this.Close();
        }

        private void GrpRecipe2_MouseClick(Object sender, MouseEventArgs e)
        {
            this.Hide();
            frmRecipeInfos fri = new frmRecipeInfos(this.recipes[(4 * this.page) - 2 - 1]);
            fri.ShowDialog();
            this.Close();
        }

        private void GrpRecipe3_MouseClick(Object sender, MouseEventArgs e)
        {
            this.Hide();
            frmRecipeInfos fri = new frmRecipeInfos(this.recipes[(4 * this.page) - 1 - 1]);
            fri.ShowDialog();
            this.Close();
        }

        private void GrpRecipe4_MouseClick(Object sender, MouseEventArgs e)
        {
            this.Hide();
            frmRecipeInfos fri = new frmRecipeInfos(this.recipes[(4 * this.page) - 1]);
            fri.ShowDialog();
            this.Close();
        }
    }
}
