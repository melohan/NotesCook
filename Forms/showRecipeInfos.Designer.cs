﻿
namespace NotesCook.Forms
{
    partial class frm_RecipeInfos
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
            this.grp_recipeInfos = new System.Windows.Forms.GroupBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.lbl_NbPeople = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.grp_menu.SuspendLayout();
            this.grp_recipeInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(28, 16);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(45, 48);
            this.pic_logo1.TabIndex = 9;
            this.pic_logo1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(123, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(126, 46);
            this.lbl_title.TabIndex = 8;
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
            this.lblIngredients.Click += new System.EventHandler(this.lblIngredients_Click);
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
            // 
            // grp_menu
            // 
            this.grp_menu.Controls.Add(this.lblSteps);
            this.grp_menu.Controls.Add(this.lblIngredients);
            this.grp_menu.Controls.Add(this.lblRecipe);
            this.grp_menu.Location = new System.Drawing.Point(9, 99);
            this.grp_menu.Margin = new System.Windows.Forms.Padding(2);
            this.grp_menu.Name = "grp_menu";
            this.grp_menu.Padding = new System.Windows.Forms.Padding(2);
            this.grp_menu.Size = new System.Drawing.Size(259, 40);
            this.grp_menu.TabIndex = 10;
            this.grp_menu.TabStop = false;
            // 
            // grp_recipeInfos
            // 
            this.grp_recipeInfos.Controls.Add(this.lblTags);
            this.grp_recipeInfos.Controls.Add(this.lbl_NbPeople);
            this.grp_recipeInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_recipeInfos.Location = new System.Drawing.Point(12, 171);
            this.grp_recipeInfos.Name = "grp_recipeInfos";
            this.grp_recipeInfos.Size = new System.Drawing.Size(256, 279);
            this.grp_recipeInfos.TabIndex = 11;
            this.grp_recipeInfos.TabStop = false;
            this.grp_recipeInfos.Text = "recipeName";
            // 
            // lblTags
            // 
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(6, 50);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(244, 169);
            this.lblTags.TabIndex = 1;
            // 
            // lbl_NbPeople
            // 
            this.lbl_NbPeople.AutoSize = true;
            this.lbl_NbPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NbPeople.Location = new System.Drawing.Point(7, 30);
            this.lbl_NbPeople.Name = "lbl_NbPeople";
            this.lbl_NbPeople.Size = new System.Drawing.Size(112, 16);
            this.lbl_NbPeople.TabIndex = 0;
            this.lbl_NbPeople.Text = "Pour x personnes";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(12, 517);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(81, 23);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Supprimer";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_RecipeInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.grp_recipeInfos);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.grp_menu);
            this.Name = "frm_RecipeInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.grp_menu.ResumeLayout(false);
            this.grp_menu.PerformLayout();
            this.grp_recipeInfos.ResumeLayout(false);
            this.grp_recipeInfos.PerformLayout();
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
        private System.Windows.Forms.GroupBox grp_recipeInfos;
        private System.Windows.Forms.Label lbl_NbPeople;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Button btn_Delete;
    }
}