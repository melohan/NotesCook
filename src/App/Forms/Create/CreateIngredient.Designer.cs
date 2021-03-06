
namespace NotesCook.Forms
{
    partial class frmCreateIngredient
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
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.grpRecipe = new System.Windows.Forms.GroupBox();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUnity = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btmMinus = new System.Windows.Forms.Button();
            this.lstIngredient = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.grpRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(37, 23);
            this.pic_logo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(60, 59);
            this.pic_logo1.TabIndex = 7;
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
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "!Cook";
            this.lblTitle.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(257, 18);
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
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // grpRecipe
            // 
            this.grpRecipe.Controls.Add(this.nupQuantity);
            this.grpRecipe.Controls.Add(this.txtUnit);
            this.grpRecipe.Controls.Add(this.txtName);
            this.grpRecipe.Controls.Add(this.lblUnity);
            this.grpRecipe.Controls.Add(this.lblQuantity);
            this.grpRecipe.Controls.Add(this.btnPlus);
            this.grpRecipe.Controls.Add(this.lblName);
            this.grpRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipe.Location = new System.Drawing.Point(21, 210);
            this.grpRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipe.Name = "grpRecipe";
            this.grpRecipe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipe.Size = new System.Drawing.Size(328, 223);
            this.grpRecipe.TabIndex = 9;
            this.grpRecipe.TabStop = false;
            this.grpRecipe.Text = "Ingrédients";
            // 
            // nupQuantity
            // 
            this.nupQuantity.DecimalPlaces = 2;
            this.nupQuantity.Location = new System.Drawing.Point(183, 84);
            this.nupQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(133, 27);
            this.nupQuantity.TabIndex = 10;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(183, 121);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(132, 27);
            this.txtUnit.TabIndex = 9;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 27);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblUnity
            // 
            this.lblUnity.AutoSize = true;
            this.lblUnity.Location = new System.Drawing.Point(16, 124);
            this.lblUnity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnity.Name = "lblUnity";
            this.lblUnity.Size = new System.Drawing.Size(48, 20);
            this.lblUnity.TabIndex = 6;
            this.lblUnity.Text = "Unité";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 86);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantité";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Enabled = false;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(281, 166);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 34);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
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
            this.grpMenu.TabIndex = 8;
            this.grpMenu.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(132, 612);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 43);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btmMinus
            // 
            this.btmMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btmMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btmMinus.Location = new System.Drawing.Point(312, 506);
            this.btmMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmMinus.Name = "btmMinus";
            this.btmMinus.Size = new System.Drawing.Size(35, 34);
            this.btmMinus.TabIndex = 11;
            this.btmMinus.Text = "-";
            this.btmMinus.UseVisualStyleBackColor = true;
            this.btmMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lstIngredient
            // 
            this.lstIngredient.FormattingEnabled = true;
            this.lstIngredient.ItemHeight = 16;
            this.lstIngredient.Location = new System.Drawing.Point(24, 439);
            this.lstIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIngredient.Name = "lstIngredient";
            this.lstIngredient.Size = new System.Drawing.Size(281, 164);
            this.lstIngredient.TabIndex = 12;
            // 
            // frmCreateIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 679);
            this.Controls.Add(this.btmMinus);
            this.Controls.Add(this.lstIngredient);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpRecipe);
            this.Controls.Add(this.grpMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreateIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer les ingrédients";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.grpRecipe.ResumeLayout(false);
            this.grpRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUnity;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Button btmMinus;
        private System.Windows.Forms.ListBox lstIngredient;
    }
}