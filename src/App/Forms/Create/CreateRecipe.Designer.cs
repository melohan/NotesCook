
namespace NotesCook.Forms
{
    partial class frmCreateRecipe
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
            this.pic_logo1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.grpRecipe = new System.Windows.Forms.GroupBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.nupNbPersons = new System.Windows.Forms.NumericUpDown();
            this.lblNbPeople = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstTag = new System.Windows.Forms.ListBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.grpRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(37, 23);
            this.pic_logo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(60, 59);
            this.pic_logo1.TabIndex = 3;
            this.pic_logo1.TabStop = false;
            this.pic_logo1.Click += new System.EventHandler(this.pic_logo1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(164, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 58);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "!Cook";
            this.lblTitle.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblSteps);
            this.grpMenu.Controls.Add(this.lblIngredients);
            this.grpMenu.Controls.Add(this.lblRecipe);
            this.grpMenu.Location = new System.Drawing.Point(12, 126);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Size = new System.Drawing.Size(345, 49);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.TabStop = false;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Enabled = false;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(257, 18);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(67, 20);
            this.lblSteps.TabIndex = 8;
            this.lblSteps.Text = "Etapes";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Enabled = false;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(131, 18);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(102, 20);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Ingrédients";
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(17, 18);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(74, 20);
            this.lblRecipe.TabIndex = 6;
            this.lblRecipe.Text = "Recette";
            // 
            // grpRecipe
            // 
            this.grpRecipe.Controls.Add(this.btnPlus);
            this.grpRecipe.Controls.Add(this.nupNbPersons);
            this.grpRecipe.Controls.Add(this.lblNbPeople);
            this.grpRecipe.Controls.Add(this.txtTag);
            this.grpRecipe.Controls.Add(this.lblTag);
            this.grpRecipe.Controls.Add(this.txtName);
            this.grpRecipe.Controls.Add(this.lblName);
            this.grpRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipe.Location = new System.Drawing.Point(21, 210);
            this.grpRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipe.Name = "grpRecipe";
            this.grpRecipe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipe.Size = new System.Drawing.Size(328, 223);
            this.grpRecipe.TabIndex = 5;
            this.grpRecipe.TabStop = false;
            this.grpRecipe.Text = "Recette";
            // 
            // btnPlus
            // 
            this.btnPlus.Enabled = false;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(252, 103);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 34);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // nupNbPersons
            // 
            this.nupNbPersons.Location = new System.Drawing.Point(233, 160);
            this.nupNbPersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupNbPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNbPersons.Name = "nupNbPersons";
            this.nupNbPersons.Size = new System.Drawing.Size(53, 27);
            this.nupNbPersons.TabIndex = 6;
            this.nupNbPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNbPeople
            // 
            this.lblNbPeople.AutoSize = true;
            this.lblNbPeople.Location = new System.Drawing.Point(23, 162);
            this.lblNbPeople.Name = "lblNbPeople";
            this.lblNbPeople.Size = new System.Drawing.Size(174, 20);
            this.lblNbPeople.TabIndex = 5;
            this.lblNbPeople.Text = "Nombre de personnes";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(109, 102);
            this.txtTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(119, 27);
            this.txtTag.TabIndex = 3;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(16, 103);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(37, 20);
            this.lblTag.TabIndex = 2;
            this.lblTag.Text = "Tag";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(132, 612);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 43);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lstTag
            // 
            this.lstTag.FormattingEnabled = true;
            this.lstTag.ItemHeight = 16;
            this.lstTag.Location = new System.Drawing.Point(24, 439);
            this.lstTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTag.Name = "lstTag";
            this.lstTag.Size = new System.Drawing.Size(281, 164);
            this.lstTag.TabIndex = 7;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(312, 506);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 34);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btmMinus_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(20, 658);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 8;
            // 
            // frmCreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 679);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lstTag);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpRecipe);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreateRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer une recette";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpRecipe.ResumeLayout(false);
            this.grpRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblNbPeople;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nupNbPersons;
        private System.Windows.Forms.ListBox lstTag;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnPlus;
    }
}