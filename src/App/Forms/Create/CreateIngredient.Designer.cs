
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
            this.lbl_title = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btmMinus = new System.Windows.Forms.Button();
            this.lstIngredient = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.grpRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(28, 19);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(45, 48);
            this.pic_logo1.TabIndex = 7;
            this.pic_logo1.TabStop = false;
            this.pic_logo1.Click += new System.EventHandler(this.pic_logo1_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(123, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(126, 46);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "!Cook";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(193, 15);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(58, 17);
            this.lblSteps.TabIndex = 8;
            this.lblSteps.Text = "Etapes";
            this.lblSteps.Click += new System.EventHandler(this.lblSteps_Click);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(98, 15);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(89, 17);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Ingrédients";
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(13, 15);
            this.lblRecipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(72, 17);
            this.lblRecipe.TabIndex = 6;
            this.lblRecipe.Text = "Recettes";
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
            this.grpRecipe.Location = new System.Drawing.Point(16, 171);
            this.grpRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.grpRecipe.Name = "grpRecipe";
            this.grpRecipe.Padding = new System.Windows.Forms.Padding(2);
            this.grpRecipe.Size = new System.Drawing.Size(246, 181);
            this.grpRecipe.TabIndex = 9;
            this.grpRecipe.TabStop = false;
            this.grpRecipe.Text = "Ingrédients";
            // 
            // nupQuantity
            // 
            this.nupQuantity.DecimalPlaces = 2;
            this.nupQuantity.Location = new System.Drawing.Point(137, 68);
            this.nupQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(100, 23);
            this.nupQuantity.TabIndex = 10;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(137, 98);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 23);
            this.txtUnit.TabIndex = 9;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblUnity
            // 
            this.lblUnity.AutoSize = true;
            this.lblUnity.Location = new System.Drawing.Point(12, 101);
            this.lblUnity.Name = "lblUnity";
            this.lblUnity.Size = new System.Drawing.Size(41, 17);
            this.lblUnity.TabIndex = 6;
            this.lblUnity.Text = "Unité";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 17);
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
            this.btnPlus.Location = new System.Drawing.Point(211, 135);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(26, 28);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 37);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSteps);
            this.groupBox1.Controls.Add(this.lblIngredients);
            this.groupBox1.Controls.Add(this.lblRecipe);
            this.groupBox1.Location = new System.Drawing.Point(9, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(259, 40);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(99, 497);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
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
            this.btmMinus.Location = new System.Drawing.Point(234, 411);
            this.btmMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btmMinus.Name = "btmMinus";
            this.btmMinus.Size = new System.Drawing.Size(26, 28);
            this.btmMinus.TabIndex = 11;
            this.btmMinus.Text = "-";
            this.btmMinus.UseVisualStyleBackColor = true;
            this.btmMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lstIngredient
            // 
            this.lstIngredient.FormattingEnabled = true;
            this.lstIngredient.Location = new System.Drawing.Point(18, 357);
            this.lstIngredient.Name = "lstIngredient";
            this.lstIngredient.Size = new System.Drawing.Size(212, 134);
            this.lstIngredient.TabIndex = 12;
            // 
            // frmCreateIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.btmMinus);
            this.Controls.Add(this.lstIngredient);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.grpRecipe);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreateIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer une recette";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.grpRecipe.ResumeLayout(false);
            this.grpRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
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