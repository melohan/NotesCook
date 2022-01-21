
namespace NotesCook
{
    partial class frm_home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.btnRecipes = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picLogo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(128, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "!Cook";
            // 
            // picLogo1
            // 
            this.picLogo1.Location = new System.Drawing.Point(12, 12);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(100, 73);
            this.picLogo1.TabIndex = 1;
            this.picLogo1.TabStop = false;
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecipe.Location = new System.Drawing.Point(22, 109);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(228, 61);
            this.btnNewRecipe.TabIndex = 2;
            this.btnNewRecipe.Text = "Nouvelle recette";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btn_new_recipe_Click);
            // 
            // btnRecipes
            // 
            this.btnRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipes.Location = new System.Drawing.Point(22, 204);
            this.btnRecipes.Name = "btnRecipes";
            this.btnRecipes.Size = new System.Drawing.Size(228, 61);
            this.btnRecipes.TabIndex = 3;
            this.btnRecipes.Text = "Recettes";
            this.btnRecipes.UseVisualStyleBackColor = true;
            this.btnRecipes.Click += new System.EventHandler(this.btnRecipes_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(22, 302);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(228, 61);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picLogo2
            // 
            this.picLogo2.Location = new System.Drawing.Point(62, 397);
            this.picLogo2.Name = "picLogo2";
            this.picLogo2.Size = new System.Drawing.Size(146, 121);
            this.picLogo2.TabIndex = 5;
            this.picLogo2.TabStop = false;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.picLogo2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRecipes);
            this.Controls.Add(this.btnNewRecipe);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotesCook";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo1;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.Button btnRecipes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picLogo2;
    }
}

