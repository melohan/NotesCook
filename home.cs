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
            Application.Run(new frmCreateRecipe());
        }

        // Clos this process and open new thread for recipe 
        private void btn_new_recipe_Click(object sender, EventArgs e)
        {
            frmCreateRecipe cs = new frmCreateRecipe();
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }
    }
}
