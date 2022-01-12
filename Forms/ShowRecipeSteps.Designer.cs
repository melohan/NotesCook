
namespace NotesCook.Forms
{
    partial class frm_ShowRecipeSteps
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
            this.grp_Step1 = new System.Windows.Forms.GroupBox();
            this.lbl_Step1 = new System.Windows.Forms.Label();
            this.grp_Step2 = new System.Windows.Forms.GroupBox();
            this.lbl_Step2 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.grp_menu.SuspendLayout();
            this.grp_Step1.SuspendLayout();
            this.grp_Step2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(26, 14);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(45, 48);
            this.pic_logo1.TabIndex = 15;
            this.pic_logo1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(121, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(126, 46);
            this.lbl_title.TabIndex = 14;
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
            this.grp_menu.TabIndex = 16;
            this.grp_menu.TabStop = false;
            // 
            // grp_Step1
            // 
            this.grp_Step1.Controls.Add(this.lbl_Step1);
            this.grp_Step1.Location = new System.Drawing.Point(7, 151);
            this.grp_Step1.Name = "grp_Step1";
            this.grp_Step1.Size = new System.Drawing.Size(259, 169);
            this.grp_Step1.TabIndex = 17;
            this.grp_Step1.TabStop = false;
            this.grp_Step1.Text = "grp_step1";
            this.grp_Step1.Visible = false;
            // 
            // lbl_Step1
            // 
            this.lbl_Step1.Location = new System.Drawing.Point(6, 16);
            this.lbl_Step1.Name = "lbl_Step1";
            this.lbl_Step1.Size = new System.Drawing.Size(244, 143);
            this.lbl_Step1.TabIndex = 0;
            this.lbl_Step1.Text = "label1";
            this.lbl_Step1.Visible = false;
            // 
            // grp_Step2
            // 
            this.grp_Step2.Controls.Add(this.lbl_Step2);
            this.grp_Step2.Location = new System.Drawing.Point(6, 326);
            this.grp_Step2.Name = "grp_Step2";
            this.grp_Step2.Size = new System.Drawing.Size(259, 169);
            this.grp_Step2.TabIndex = 18;
            this.grp_Step2.TabStop = false;
            this.grp_Step2.Text = "grp_step2";
            this.grp_Step2.Visible = false;
            // 
            // lbl_Step2
            // 
            this.lbl_Step2.Location = new System.Drawing.Point(7, 16);
            this.lbl_Step2.Name = "lbl_Step2";
            this.lbl_Step2.Size = new System.Drawing.Size(244, 143);
            this.lbl_Step2.TabIndex = 1;
            this.lbl_Step2.Text = "label2";
            this.lbl_Step2.Visible = false;
            // 
            // btn_Next
            // 
            this.btn_Next.Enabled = false;
            this.btn_Next.Location = new System.Drawing.Point(186, 511);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 19;
            this.btn_Next.Text = "Suivant";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Enabled = false;
            this.btn_Previous.Location = new System.Drawing.Point(7, 511);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 20;
            this.btn_Previous.Text = "Précédant";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // frm_ShowRecipeSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.grp_Step2);
            this.Controls.Add(this.grp_Step1);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.grp_menu);
            this.Name = "frm_ShowRecipeSteps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ShowRecipeSteps";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.grp_menu.ResumeLayout(false);
            this.grp_menu.PerformLayout();
            this.grp_Step1.ResumeLayout(false);
            this.grp_Step2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grp_Step1;
        private System.Windows.Forms.GroupBox grp_Step2;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Label lbl_Step1;
        private System.Windows.Forms.Label lbl_Step2;
    }
}