using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotesCook.Forms
{
    public partial class CreateRecipe : Form
    {
        private GroupBox grpAddedTag;
        private readonly int GRP_START_X = 10;
        private readonly int GRP_START_Y = 20;
        private int tagX = 0;
        private int tagY = 0;

        public CreateRecipe()
        {
            grpAddedTag = new GroupBox();
            this.grpAddedTag.SetBounds(20, 450, 328, 100);
            this.grpAddedTag.Font = new Font("Microsoft Sans Serif", 10);

            this.tagX = GRP_START_X;
            this.tagY = GRP_START_Y;

            this.Controls.Add(grpAddedTag);
            InitializeComponent();
        }

        // Todo make this event available multiple times
        // and add a way to manage labels positions
        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (txtTag.Text.Length != 0)
            {
                grpAddedTag.Text = "Clic pour supprimer un tag";
                Label lblCompleted = new Label { Name = "lblDel" + txtTag.Text, Text = txtTag.Text + " (x)" };
                lblCompleted.Location = new Point(tagX, tagY);
                this.tagX += lblCompleted.Text.Length+5;
                this.grpAddedTag.Controls.Add(lblCompleted);
            }
        }
    }
}
