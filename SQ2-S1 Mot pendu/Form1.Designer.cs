
namespace SQ2_S1_Mot_pendu
{
    partial class frmPendu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendu));
            this.cmbAlphabet = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.lblMotAChercher = new System.Windows.Forms.Label();
            this.lblLettres = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAlphabet
            // 
            this.cmbAlphabet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbAlphabet.FormattingEnabled = true;
            this.cmbAlphabet.Location = new System.Drawing.Point(0, 63);
            this.cmbAlphabet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAlphabet.Name = "cmbAlphabet";
            this.cmbAlphabet.Size = new System.Drawing.Size(173, 33);
            this.cmbAlphabet.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTest.Location = new System.Drawing.Point(34, 109);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(113, 41);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Tester";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejouer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRejouer.Image = ((System.Drawing.Image)(resources.GetObject("btnRejouer.Image")));
            this.btnRejouer.Location = new System.Drawing.Point(257, 31);
            this.btnRejouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(107, 94);
            this.btnRejouer.TabIndex = 5;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMot.Location = new System.Drawing.Point(54, 73);
            this.txtMot.Margin = new System.Windows.Forms.Padding(4);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(290, 44);
            this.txtMot.TabIndex = 1;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // lblMotAChercher
            // 
            this.lblMotAChercher.AutoSize = true;
            this.lblMotAChercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMotAChercher.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotAChercher.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMotAChercher.Location = new System.Drawing.Point(70, 44);
            this.lblMotAChercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotAChercher.Name = "lblMotAChercher";
            this.lblMotAChercher.Size = new System.Drawing.Size(265, 24);
            this.lblMotAChercher.TabIndex = 0;
            this.lblMotAChercher.Text = "Écrivez un mot à chercher !";
            this.lblMotAChercher.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLettres
            // 
            this.lblLettres.AutoSize = true;
            this.lblLettres.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettres.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLettres.Location = new System.Drawing.Point(7, 27);
            this.lblLettres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(204, 24);
            this.lblLettres.TabIndex = 0;
            this.lblLettres.Text = "Lettres dèja utilisées";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(344, 65);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(105, 46);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLettres);
            this.groupBox1.Controls.Add(this.cmbAlphabet);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.btnRejouer);
            this.groupBox1.Location = new System.Drawing.Point(54, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 706);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMotAChercher);
            this.Controls.Add(this.txtMot);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPendu";
            this.Text = "Jeu du pendu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlphabet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Label lblMotAChercher;
        private System.Windows.Forms.Label lblLettres;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

