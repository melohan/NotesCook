
namespace NotesCook.Forms
{
    partial class CreateRecipe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.grpRecipe = new System.Windows.Forms.GroupBox();
            this.lblNbPeople = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.nupNbPersons = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(42, 28);
            this.pic_logo1.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(60, 59);
            this.pic_logo1.TabIndex = 3;
            this.pic_logo1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(169, 29);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(156, 58);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "!Cook";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSteps);
            this.groupBox1.Controls.Add(this.lblIngredients);
            this.groupBox1.Controls.Add(this.lblRecipe);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(130, 18);
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
            this.lblRecipe.Size = new System.Drawing.Size(84, 20);
            this.lblRecipe.TabIndex = 6;
            this.lblRecipe.Text = "Recettes";
            // 
            // grpRecipe
            // 
            this.grpRecipe.Controls.Add(this.nupNbPersons);
            this.grpRecipe.Controls.Add(this.lblNbPeople);
            this.grpRecipe.Controls.Add(this.btnPlus);
            this.grpRecipe.Controls.Add(this.txtTag);
            this.grpRecipe.Controls.Add(this.lblTag);
            this.grpRecipe.Controls.Add(this.txtName);
            this.grpRecipe.Controls.Add(this.lblName);
            this.grpRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipe.Location = new System.Drawing.Point(22, 211);
            this.grpRecipe.Name = "grpRecipe";
            this.grpRecipe.Size = new System.Drawing.Size(328, 223);
            this.grpRecipe.TabIndex = 5;
            this.grpRecipe.TabStop = false;
            this.grpRecipe.Text = "Recette";
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
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlus.Location = new System.Drawing.Point(251, 98);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 35);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(110, 102);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(119, 27);
            this.txtTag.TabIndex = 3;
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
            this.txtName.Location = new System.Drawing.Point(110, 44);
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
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(132, 612);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 43);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // nupNbPersons
            // 
            this.nupNbPersons.Location = new System.Drawing.Point(233, 160);
            this.nupNbPersons.Name = "nupNbPersons";
            this.nupNbPersons.Size = new System.Drawing.Size(53, 27);
            this.nupNbPersons.TabIndex = 6;
            this.nupNbPersons.ValueChanged += new System.EventHandler(this.nupNbPersons_ValueChanged);
            // 
            // CreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 679);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpRecipe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Name = "CreateRecipe";
            this.Text = "CreateRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpRecipe.ResumeLayout(false);
            this.grpRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblNbPeople;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nupNbPersons;
    }
}