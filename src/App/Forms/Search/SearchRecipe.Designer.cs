
namespace NotesCook.Forms
{
    partial class frmSearchRecipe
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.btmMinus = new System.Windows.Forms.Button();
            this.lstTag = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNoResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(40, 25);
            this.pic_logo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(60, 59);
            this.pic_logo1.TabIndex = 10;
            this.pic_logo1.TabStop = false;
            this.pic_logo1.Click += new System.EventHandler(this.pic_logo1_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(167, 26);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(156, 58);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "!Cook";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(308, 161);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 34);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(47, 161);
            this.txtTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(248, 22);
            this.txtTag.TabIndex = 11;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(43, 128);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(118, 17);
            this.lblTag.TabIndex = 9;
            this.lblTag.Text = "Tag à rechercher";
            // 
            // btmMinus
            // 
            this.btmMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btmMinus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btmMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btmMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btmMinus.Location = new System.Drawing.Point(308, 218);
            this.btmMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmMinus.Name = "btmMinus";
            this.btmMinus.Size = new System.Drawing.Size(35, 34);
            this.btmMinus.TabIndex = 14;
            this.btmMinus.Text = "-";
            this.btmMinus.UseVisualStyleBackColor = true;
            this.btmMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lstTag
            // 
            this.lstTag.FormattingEnabled = true;
            this.lstTag.ItemHeight = 16;
            this.lstTag.Location = new System.Drawing.Point(47, 218);
            this.lstTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTag.Name = "lstTag";
            this.lstTag.Size = new System.Drawing.Size(248, 164);
            this.lstTag.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(135, 478);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 43);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Location = new System.Drawing.Point(52, 427);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(0, 17);
            this.lblNoResults.TabIndex = 16;
            // 
            // frmSearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 679);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.btmMinus);
            this.Controls.Add(this.lstTag);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSearchRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Button btmMinus;
        private System.Windows.Forms.ListBox lstTag;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNoResults;
    }
}