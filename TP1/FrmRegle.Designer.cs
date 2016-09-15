namespace TP1
{
    partial class Regles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regles));
            this.pctPageGauche = new System.Windows.Forms.PictureBox();
            this.pctPageDroite = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctPageGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPageDroite)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPageGauche
            // 
            this.pctPageGauche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctPageGauche.BackgroundImage")));
            this.pctPageGauche.Location = new System.Drawing.Point(83, 15);
            this.pctPageGauche.Name = "pctPageGauche";
            this.pctPageGauche.Size = new System.Drawing.Size(597, 801);
            this.pctPageGauche.TabIndex = 0;
            this.pctPageGauche.TabStop = false;
            // 
            // pctPageDroite
            // 
            this.pctPageDroite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctPageDroite.BackgroundImage")));
            this.pctPageDroite.Location = new System.Drawing.Point(728, 16);
            this.pctPageDroite.Name = "pctPageDroite";
            this.pctPageDroite.Size = new System.Drawing.Size(617, 801);
            this.pctPageDroite.TabIndex = 1;
            this.pctPageDroite.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMenu.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(96, 766);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 40);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Fermer";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrecedent.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(234, 766);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(120, 40);
            this.btnPrecedent.TabIndex = 3;
            this.btnPrecedent.Text = "<<";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSuivant.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(373, 766);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(120, 40);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = ">>";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // Regles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1424, 831);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pctPageDroite);
            this.Controls.Add(this.pctPageGauche);
            this.Name = "Regles";
            this.Text = "Règles";
            ((System.ComponentModel.ISupportInitialize)(this.pctPageGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPageDroite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPageGauche;
        private System.Windows.Forms.PictureBox pctPageDroite;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
    }
}