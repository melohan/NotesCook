
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_logo1 = new System.Windows.Forms.PictureBox();
            this.btn_new_recepe = new System.Windows.Forms.Button();
            this.btn_recently_consulted = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.pic_logo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(128, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(126, 46);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "!Cook";
            // 
            // pic_logo1
            // 
            this.pic_logo1.Location = new System.Drawing.Point(12, 12);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(100, 73);
            this.pic_logo1.TabIndex = 1;
            this.pic_logo1.TabStop = false;
            // 
            // btn_new_recepe
            // 
            this.btn_new_recepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_recepe.Location = new System.Drawing.Point(22, 109);
            this.btn_new_recepe.Name = "btn_new_recepe";
            this.btn_new_recepe.Size = new System.Drawing.Size(228, 61);
            this.btn_new_recepe.TabIndex = 2;
            this.btn_new_recepe.Text = "Nouvelles recettes";
            this.btn_new_recepe.UseVisualStyleBackColor = true;
            // 
            // btn_recently_consulted
            // 
            this.btn_recently_consulted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recently_consulted.Location = new System.Drawing.Point(22, 204);
            this.btn_recently_consulted.Name = "btn_recently_consulted";
            this.btn_recently_consulted.Size = new System.Drawing.Size(228, 61);
            this.btn_recently_consulted.TabIndex = 3;
            this.btn_recently_consulted.Text = "Recement consultées";
            this.btn_recently_consulted.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(22, 302);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(228, 61);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Rechercher";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // pic_logo2
            // 
            this.pic_logo2.Location = new System.Drawing.Point(62, 397);
            this.pic_logo2.Name = "pic_logo2";
            this.pic_logo2.Size = new System.Drawing.Size(146, 121);
            this.pic_logo2.TabIndex = 5;
            this.pic_logo2.TabStop = false;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 552);
            this.Controls.Add(this.pic_logo2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_recently_consulted);
            this.Controls.Add(this.btn_new_recepe);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_home";
            this.Text = "NotesCook";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.Button btn_new_recepe;
        private System.Windows.Forms.Button btn_recently_consulted;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pic_logo2;
    }
}

