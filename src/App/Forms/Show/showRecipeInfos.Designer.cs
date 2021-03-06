
namespace NotesCook.Forms
{
    partial class frmRecipeInfos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.grpRecipeInfos = new System.Windows.Forms.GroupBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lstTag = new System.Windows.Forms.ListBox();
            this.nupNbPersons = new System.Windows.Forms.NumericUpDown();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblNewNbPerson = new System.Windows.Forms.Label();
            this.lblNbPersons = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.grpRecipeInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo1
            // 
            this.picLogo1.Location = new System.Drawing.Point(37, 20);
            this.picLogo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(60, 59);
            this.picLogo1.TabIndex = 9;
            this.picLogo1.TabStop = false;
            this.picLogo1.Click += new System.EventHandler(this.picLogo1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(164, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 58);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "!Cook";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(256, 17);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(67, 20);
            this.lblSteps.TabIndex = 8;
            this.lblSteps.Text = "Etapes";
            this.lblSteps.Click += new System.EventHandler(this.lblSteps_Click);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(129, 17);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(102, 20);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Ingrédients";
            this.lblIngredients.Click += new System.EventHandler(this.lblIngredients_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(16, 17);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(74, 20);
            this.lblRecipe.TabIndex = 6;
            this.lblRecipe.Text = "Recette";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblSteps);
            this.grpMenu.Controls.Add(this.lblIngredients);
            this.grpMenu.Controls.Add(this.lblRecipe);
            this.grpMenu.Location = new System.Drawing.Point(12, 122);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Size = new System.Drawing.Size(345, 49);
            this.grpMenu.TabIndex = 10;
            this.grpMenu.TabStop = false;
            // 
            // grpRecipeInfos
            // 
            this.grpRecipeInfos.Controls.Add(this.btnPlus);
            this.grpRecipeInfos.Controls.Add(this.btnMinus);
            this.grpRecipeInfos.Controls.Add(this.lblTag);
            this.grpRecipeInfos.Controls.Add(this.txtTag);
            this.grpRecipeInfos.Controls.Add(this.lstTag);
            this.grpRecipeInfos.Controls.Add(this.nupNbPersons);
            this.grpRecipeInfos.Controls.Add(this.lblTags);
            this.grpRecipeInfos.Controls.Add(this.lblNewNbPerson);
            this.grpRecipeInfos.Controls.Add(this.lblNbPersons);
            this.grpRecipeInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipeInfos.Location = new System.Drawing.Point(16, 210);
            this.grpRecipeInfos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRecipeInfos.Name = "grpRecipeInfos";
            this.grpRecipeInfos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRecipeInfos.Size = new System.Drawing.Size(341, 343);
            this.grpRecipeInfos.TabIndex = 11;
            this.grpRecipeInfos.TabStop = false;
            this.grpRecipeInfos.Text = "recipeName";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(244, 226);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 34);
            this.btnPlus.TabIndex = 29;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Visible = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(284, 226);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 34);
            this.btnMinus.TabIndex = 27;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Visible = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(12, 313);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(37, 20);
            this.lblTag.TabIndex = 28;
            this.lblTag.Text = "Tag";
            this.lblTag.Visible = false;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(95, 309);
            this.txtTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(132, 26);
            this.txtTag.TabIndex = 25;
            this.txtTag.Visible = false;
            // 
            // lstTag
            // 
            this.lstTag.FormattingEnabled = true;
            this.lstTag.ItemHeight = 20;
            this.lstTag.Location = new System.Drawing.Point(4, 73);
            this.lstTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTag.Name = "lstTag";
            this.lstTag.Size = new System.Drawing.Size(323, 184);
            this.lstTag.TabIndex = 27;
            this.lstTag.Visible = false;
            this.lstTag.SelectedIndexChanged += new System.EventHandler(this.lstTag_SelectedIndexChanged);
            // 
            // nupNbPersons
            // 
            this.nupNbPersons.Location = new System.Drawing.Point(219, 37);
            this.nupNbPersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupNbPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNbPersons.Name = "nupNbPersons";
            this.nupNbPersons.Size = new System.Drawing.Size(53, 26);
            this.nupNbPersons.TabIndex = 26;
            this.nupNbPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNbPersons.Visible = false;
            // 
            // lblTags
            // 
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(8, 62);
            this.lblTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(325, 208);
            this.lblTags.TabIndex = 1;
            // 
            // lblNewNbPerson
            // 
            this.lblNewNbPerson.AutoSize = true;
            this.lblNewNbPerson.Location = new System.Drawing.Point(7, 39);
            this.lblNewNbPerson.Name = "lblNewNbPerson";
            this.lblNewNbPerson.Size = new System.Drawing.Size(174, 20);
            this.lblNewNbPerson.TabIndex = 25;
            this.lblNewNbPerson.Text = "Nombre de personnes";
            this.lblNewNbPerson.Visible = false;
            // 
            // lblNbPersons
            // 
            this.lblNbPersons.AutoSize = true;
            this.lblNbPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPersons.Location = new System.Drawing.Point(9, 37);
            this.lblNbPersons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbPersons.Name = "lblNbPersons";
            this.lblNbPersons.Size = new System.Drawing.Size(140, 20);
            this.lblNbPersons.TabIndex = 0;
            this.lblNbPersons.Text = "Pour x personnes";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDelete.Location = new System.Drawing.Point(16, 636);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 602);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(128, 636);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 210);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Visible = false;
            // 
            // frmRecipeInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(369, 679);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpRecipeInfos);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecipeInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recette";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpRecipeInfos.ResumeLayout(false);
            this.grpRecipeInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.GroupBox grpRecipeInfos;
        private System.Windows.Forms.Label lblNbPersons;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nupNbPersons;
        private System.Windows.Forms.Label lblNewNbPerson;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.ListBox lstTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
    }
}