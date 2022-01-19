
namespace NotesCook.Forms
{
    partial class frmShowRecipeSteps
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
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.txtNameStep1 = new System.Windows.Forms.TextBox();
            this.txtStep1 = new System.Windows.Forms.TextBox();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.txtNameStep2 = new System.Windows.Forms.TextBox();
            this.txtStep2 = new System.Windows.Forms.TextBox();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnMinus2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.grpStep1.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo1
            // 
            this.picLogo1.Location = new System.Drawing.Point(35, 17);
            this.picLogo1.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(60, 59);
            this.picLogo1.TabIndex = 15;
            this.picLogo1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(161, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 58);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "!Cook";
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
            this.lblRecipe.Size = new System.Drawing.Size(84, 20);
            this.lblRecipe.TabIndex = 6;
            this.lblRecipe.Text = "Recettes";
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblSteps);
            this.grpMenu.Controls.Add(this.lblIngredients);
            this.grpMenu.Controls.Add(this.lblRecipe);
            this.grpMenu.Location = new System.Drawing.Point(9, 119);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenu.Size = new System.Drawing.Size(345, 49);
            this.grpMenu.TabIndex = 16;
            this.grpMenu.TabStop = false;
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.btnMinus1);
            this.grpStep1.Controls.Add(this.txtNameStep1);
            this.grpStep1.Controls.Add(this.txtStep1);
            this.grpStep1.Controls.Add(this.lblStep1);
            this.grpStep1.Location = new System.Drawing.Point(9, 186);
            this.grpStep1.Margin = new System.Windows.Forms.Padding(4);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Padding = new System.Windows.Forms.Padding(4);
            this.grpStep1.Size = new System.Drawing.Size(345, 208);
            this.grpStep1.TabIndex = 17;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "grpStep1";
            this.grpStep1.Visible = false;
            // 
            // txtNameStep1
            // 
            this.txtNameStep1.Location = new System.Drawing.Point(0, 0);
            this.txtNameStep1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameStep1.Name = "txtNameStep1";
            this.txtNameStep1.Size = new System.Drawing.Size(132, 22);
            this.txtNameStep1.TabIndex = 22;
            this.txtNameStep1.Visible = false;
            // 
            // txtStep1
            // 
            this.txtStep1.Location = new System.Drawing.Point(0, 23);
            this.txtStep1.Margin = new System.Windows.Forms.Padding(4);
            this.txtStep1.Multiline = true;
            this.txtStep1.Name = "txtStep1";
            this.txtStep1.Size = new System.Drawing.Size(308, 175);
            this.txtStep1.TabIndex = 1;
            this.txtStep1.Visible = false;
            // 
            // lblStep1
            // 
            this.lblStep1.Location = new System.Drawing.Point(8, 20);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(325, 176);
            this.lblStep1.TabIndex = 0;
            this.lblStep1.Text = "label1";
            this.lblStep1.Visible = false;
            // 
            // grpStep2
            // 
            this.grpStep2.Controls.Add(this.btnMinus2);
            this.grpStep2.Controls.Add(this.txtNameStep2);
            this.grpStep2.Controls.Add(this.txtStep2);
            this.grpStep2.Controls.Add(this.lblStep2);
            this.grpStep2.Location = new System.Drawing.Point(8, 401);
            this.grpStep2.Margin = new System.Windows.Forms.Padding(4);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Padding = new System.Windows.Forms.Padding(4);
            this.grpStep2.Size = new System.Drawing.Size(345, 208);
            this.grpStep2.TabIndex = 18;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "grpStep2";
            this.grpStep2.Visible = false;
            // 
            // txtNameStep2
            // 
            this.txtNameStep2.Location = new System.Drawing.Point(1, 0);
            this.txtNameStep2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameStep2.Name = "txtNameStep2";
            this.txtNameStep2.Size = new System.Drawing.Size(132, 22);
            this.txtNameStep2.TabIndex = 23;
            this.txtNameStep2.Visible = false;
            // 
            // txtStep2
            // 
            this.txtStep2.Location = new System.Drawing.Point(0, 23);
            this.txtStep2.Margin = new System.Windows.Forms.Padding(4);
            this.txtStep2.Multiline = true;
            this.txtStep2.Name = "txtStep2";
            this.txtStep2.Size = new System.Drawing.Size(309, 173);
            this.txtStep2.TabIndex = 2;
            this.txtStep2.Visible = false;
            // 
            // lblStep2
            // 
            this.lblStep2.Location = new System.Drawing.Point(9, 20);
            this.lblStep2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(325, 176);
            this.lblStep2.TabIndex = 1;
            this.lblStep2.Text = "label2";
            this.lblStep2.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(248, 646);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(9, 646);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 28);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Précédant";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(128, 646);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 612);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(270, 612);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 17);
            this.lblPage.TabIndex = 23;
            // 
            // btnMinus1
            // 
            this.btnMinus1.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus1.Location = new System.Drawing.Point(308, 81);
            this.btnMinus1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(35, 34);
            this.btnMinus1.TabIndex = 24;
            this.btnMinus1.Text = "-";
            this.btnMinus1.UseVisualStyleBackColor = true;
            this.btnMinus1.Visible = false;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnMinus2
            // 
            this.btnMinus2.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus2.Location = new System.Drawing.Point(309, 100);
            this.btnMinus2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus2.Name = "btnMinus2";
            this.btnMinus2.Size = new System.Drawing.Size(35, 34);
            this.btnMinus2.TabIndex = 25;
            this.btnMinus2.Text = "-";
            this.btnMinus2.UseVisualStyleBackColor = true;
            this.btnMinus2.Visible = false;
            this.btnMinus2.Click += new System.EventHandler(this.btnMinus2_Click);
            // 
            // frmShowRecipeSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 679);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpStep2);
            this.Controls.Add(this.grpStep1);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShowRecipeSteps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les étapes";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtNameStep1;
        private System.Windows.Forms.TextBox txtStep1;
        private System.Windows.Forms.TextBox txtNameStep2;
        private System.Windows.Forms.TextBox txtStep2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.Button btnMinus2;
    }
}