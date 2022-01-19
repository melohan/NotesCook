using System;
using System.Windows.Forms;
using System.Threading;
using NotesCook.Forms;

namespace NotesCook
{
    public partial class frm_home : Form
    {

        public frm_home()
        {
            InitializeComponent();
        }

        public void openCreationRecipe(Object obj)
        {
            Application.Run(new CreateRecipe());
        }

        // Clos this process and open new thread for recipe 
        private void btn_new_recipe_Click(object sender, EventArgs e)
        {
            CreateRecipe cs = new CreateRecipe();
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            ShowRecipeList srl = new ShowRecipeList();
            this.Hide();
            srl.ShowDialog();
            this.Close();
        }
    }
}
