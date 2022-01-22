
namespace NotesCook.Forms
{
    partial class frmRecipeIngredients
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
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblTableIngredients = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUnity = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo1
            // 
            this.picLogo1.Location = new System.Drawing.Point(26, 14);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(45, 48);
            this.picLogo1.TabIndex = 12;
            this.picLogo1.TabStop = false;
            this.picLogo1.Click += new System.EventHandler(this.picLogo1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(121, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 46);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "!Cook";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblSteps);
            this.grpMenu.Controls.Add(this.lblIngredients);
            this.grpMenu.Controls.Add(this.lblRecipe);
            this.grpMenu.Location = new System.Drawing.Point(7, 97);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(2);
            this.grpMenu.Size = new System.Drawing.Size(259, 40);
            this.grpMenu.TabIndex = 13;
            this.grpMenu.TabStop = false;
            // 
            // lstIngredients
            // 
            this.lstIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 16;
            this.lstIngredients.Location = new System.Drawing.Point(11, 184);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIngredients.Size = new System.Drawing.Size(254, 196);
            this.lstIngredients.TabIndex = 14;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 517);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nupQuantity
            // 
            this.nupQuantity.DecimalPlaces = 2;
            this.nupQuantity.Location = new System.Drawing.Point(166, 432);
            this.nupQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(100, 20);
            this.nupQuantity.TabIndex = 24;
            this.nupQuantity.Visible = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(166, 458);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 23;
            this.txtUnit.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 406);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 22;
            this.txtName.Visible = false;
            // 
            // lblUnity
            // 
            this.lblUnity.AutoSize = true;
            this.lblUnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnity.Location = new System.Drawing.Point(12, 458);
            this.lblUnity.Name = "lblUnity";
            this.lblUnity.Size = new System.Drawing.Size(39, 16);
            this.lblUnity.TabIndex = 21;
            this.lblUnity.Text = "Unité";
            this.lblUnity.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(12, 432);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 16);
            this.lblQuantity.TabIndex = 20;
            this.lblQuantity.Text = "Quantité";
            this.lblQuantity.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 407);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 16);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Nom";
            this.lblName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(231, 344);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(26, 28);
            this.btnMinus.TabIndex = 26;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Visible = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(198, 344);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(26, 28);
            this.btnPlus.TabIndex = 30;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Visible = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // frmRecipeIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUnity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblTableIngredients);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.picLogo1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRecipeIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrédient";
            this.Load += new System.EventHandler(this.frmRecipeIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
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
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblTableIngredients;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUnity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
    }
}