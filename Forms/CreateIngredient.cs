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
    public partial class CreateIngredient : Form
    {
        private Recipe recipe;

        private void setRecipe(ref Recipe recipe)
        {
            this.recipe = recipe;
        }

        public CreateIngredient()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
