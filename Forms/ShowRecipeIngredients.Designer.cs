
namespace NotesCook.Forms
{
    partial class frm_RecipeIngredients
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
            this.grp_menu = new System.Windows.Forms.GroupBox();
            this.lst_Ingredients = new System.Windows.Forms.ListBox();
            this.lblTableIngredients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.grp_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(26, 14);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(45, 48);
            this.pic_logo1.TabIndex = 12;
            this.pic_logo1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(121, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(126, 46);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "!Cook";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(192, 14);
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
            this.lblIngredients.Location = new System.Drawing.Point(97, 14);
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
            this.lblRecipe.Location = new System.Drawing.Point(12, 14);
            this.lblRecipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(72, 17);
            this.lblRecipe.TabIndex = 6;
            this.lblRecipe.Text = "Recettes";
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // grp_menu
            // 
            this.grp_menu.Controls.Add(this.lblSteps);
            this.grp_menu.Controls.Add(this.lblIngredients);
            this.grp_menu.Controls.Add(this.lblRecipe);
            this.grp_menu.Location = new System.Drawing.Point(7, 97);
            this.grp_menu.Margin = new System.Windows.Forms.Padding(2);
            this.grp_menu.Name = "grp_menu";
            this.grp_menu.Padding = new System.Windows.Forms.Padding(2);
            this.grp_menu.Size = new System.Drawing.Size(259, 40);
            this.grp_menu.TabIndex = 13;
            this.grp_menu.TabStop = false;
            // 
            // lst_Ingredients
            // 
            this.lst_Ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Ingredients.FormattingEnabled = true;
            this.lst_Ingredients.ItemHeight = 16;
            this.lst_Ingredients.Location = new System.Drawing.Point(11, 184);
            this.lst_Ingredients.Name = "lst_Ingredients";
            this.lst_Ingredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_Ingredients.Size = new System.Drawing.Size(254, 244);
            this.lst_Ingredients.TabIndex = 14;
            // 
            // lblTableIngredients
            // 
            this.lblTableIngredients.AutoSize = true;
            this.lblTableIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableIngredients.Location = new System.Drawing.Point(12, 156);
            this.lblTableIngredients.Name = "lblTableIngredients";
            this.lblTableIngredients.Size = new System.Drawing.Size(74, 16);
            this.lblTableIngredients.TabIndex = 16;
            this.lblTableIngredients.Text = "Ingrédients";
            // 
            // frm_RecipeIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.lblTableIngredients);
            this.Controls.Add(this.lst_Ingredients);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.grp_menu);
            this.Name = "frm_RecipeIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_RecipeIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.grp_menu.ResumeLayout(false);
            this.grp_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.GroupBox grp_menu;
        private System.Windows.Forms.ListBox lst_Ingredients;
        private System.Windows.Forms.Label lblTableIngredients;
    }
}