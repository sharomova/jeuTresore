namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.SuperBoutonC = new WindowsFormsApplication3.SuperBouton();
            this.SuperBoutonH = new WindowsFormsApplication3.SuperBouton();
            this.SuperBoutonB = new WindowsFormsApplication3.SuperBouton();
            this.SuperBoutonD = new WindowsFormsApplication3.SuperBouton();
            this.SuperBoutonG = new WindowsFormsApplication3.SuperBouton();
            this.SuspendLayout();
            // 
            // SuperBoutonC
            // 
            this.SuperBoutonC.Location = new System.Drawing.Point(92, 66);
            this.SuperBoutonC.Name = "SuperBoutonC";
            this.SuperBoutonC.Size = new System.Drawing.Size(75, 23);
            this.SuperBoutonC.TabIndex = 0;
            this.SuperBoutonC.Text = "SuperBouton1";
            this.SuperBoutonC.UseVisualStyleBackColor = true;
            this.SuperBoutonC.Click += new System.EventHandler(this.superBouton1_Click);
            // 
            // SuperBoutonH
            // 
            this.SuperBoutonH.Enabled = false;
            this.SuperBoutonH.Location = new System.Drawing.Point(92, 37);
            this.SuperBoutonH.Name = "SuperBoutonH";
            this.SuperBoutonH.Size = new System.Drawing.Size(75, 23);
            this.SuperBoutonH.TabIndex = 1;
            this.SuperBoutonH.Text = "superBouton2";
            this.SuperBoutonH.UseVisualStyleBackColor = true;
            // 
            // SuperBoutonB
            // 
            this.SuperBoutonB.Enabled = false;
            this.SuperBoutonB.Location = new System.Drawing.Point(92, 95);
            this.SuperBoutonB.Name = "SuperBoutonB";
            this.SuperBoutonB.Size = new System.Drawing.Size(75, 23);
            this.SuperBoutonB.TabIndex = 2;
            this.SuperBoutonB.Text = "superBouton3";
            this.SuperBoutonB.UseVisualStyleBackColor = true;
            // 
            // SuperBoutonD
            // 
            this.SuperBoutonD.Enabled = false;
            this.SuperBoutonD.Location = new System.Drawing.Point(173, 66);
            this.SuperBoutonD.Name = "SuperBoutonD";
            this.SuperBoutonD.Size = new System.Drawing.Size(75, 23);
            this.SuperBoutonD.TabIndex = 3;
            this.SuperBoutonD.Text = "superBouton4";
            this.SuperBoutonD.UseVisualStyleBackColor = true;
            // 
            // SuperBoutonG
            // 
            this.SuperBoutonG.Enabled = false;
            this.SuperBoutonG.Location = new System.Drawing.Point(12, 66);
            this.SuperBoutonG.Name = "SuperBoutonG";
            this.SuperBoutonG.Size = new System.Drawing.Size(75, 23);
            this.SuperBoutonG.TabIndex = 4;
            this.SuperBoutonG.Text = "superBouton5";
            this.SuperBoutonG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 290);
            this.Controls.Add(this.SuperBoutonG);
            this.Controls.Add(this.SuperBoutonD);
            this.Controls.Add(this.SuperBoutonB);
            this.Controls.Add(this.SuperBoutonH);
            this.Controls.Add(this.SuperBoutonC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SuperBouton SuperBoutonC;
        private SuperBouton SuperBoutonH;
        private SuperBouton SuperBoutonB;
        private SuperBouton SuperBoutonD;
        private SuperBouton SuperBoutonG;
    }
}

