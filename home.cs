using System;
using System.Windows.Forms;
using System.Threading;
using NotesCook.Forms;

namespace NotesCook
{
    public partial class frm_home : Form
    {
        Thread th;

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
            this.Close();
            th = new Thread(openCreationRecipe);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
