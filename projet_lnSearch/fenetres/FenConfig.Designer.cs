namespace projet_lnSearch.fenetres {
    partial class FenConfig {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenConfig));
            this.groupChemins = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxXML = new System.Windows.Forms.TextBox();
            this.labelChemin = new System.Windows.Forms.Label();
            this.textBoxPDF = new System.Windows.Forms.TextBox();
            this.tabControleur = new System.Windows.Forms.TabControl();
            this.tabChem = new System.Windows.Forms.TabPage();
            this.tabFilt = new System.Windows.Forms.TabPage();
            this.groupFiltres = new System.Windows.Forms.GroupBox();
            this.tabAffich = new System.Windows.Forms.TabPage();
            this.buttonValider = new System.Windows.Forms.Button();
            this.groupChemins.SuspendLayout();
            this.tabControleur.SuspendLayout();
            this.tabChem.SuspendLayout();
            this.tabFilt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupChemins
            // 
            this.groupChemins.Controls.Add(this.label1);
            this.groupChemins.Controls.Add(this.textBoxXML);
            this.groupChemins.Controls.Add(this.labelChemin);
            this.groupChemins.Controls.Add(this.textBoxPDF);
            this.groupChemins.Location = new System.Drawing.Point(6, 6);
            this.groupChemins.Name = "groupChemins";
            this.groupChemins.Size = new System.Drawing.Size(540, 160);
            this.groupChemins.TabIndex = 0;
            this.groupChemins.TabStop = false;
            this.groupChemins.Text = "Chemins des dossiers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dossier qui va contenir la base";
            // 
            // textBoxXML
            // 
            this.textBoxXML.Location = new System.Drawing.Point(204, 84);
            this.textBoxXML.Name = "textBoxXML";
            this.textBoxXML.Size = new System.Drawing.Size(317, 20);
            this.textBoxXML.TabIndex = 2;
            // 
            // labelChemin
            // 
            this.labelChemin.AutoSize = true;
            this.labelChemin.Location = new System.Drawing.Point(6, 46);
            this.labelChemin.Name = "labelChemin";
            this.labelChemin.Size = new System.Drawing.Size(171, 13);
            this.labelChemin.TabIndex = 1;
            this.labelChemin.Text = "Nom du dossier contenant les PDF";
            // 
            // textBoxPDF
            // 
            this.textBoxPDF.Location = new System.Drawing.Point(204, 43);
            this.textBoxPDF.Name = "textBoxPDF";
            this.textBoxPDF.Size = new System.Drawing.Size(317, 20);
            this.textBoxPDF.TabIndex = 0;
            // 
            // tabControleur
            // 
            this.tabControleur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControleur.Controls.Add(this.tabChem);
            this.tabControleur.Controls.Add(this.tabFilt);
            this.tabControleur.Controls.Add(this.tabAffich);
            this.tabControleur.Location = new System.Drawing.Point(12, 12);
            this.tabControleur.Name = "tabControleur";
            this.tabControleur.SelectedIndex = 0;
            this.tabControleur.Size = new System.Drawing.Size(560, 417);
            this.tabControleur.TabIndex = 1;
            // 
            // tabChem
            // 
            this.tabChem.Controls.Add(this.groupChemins);
            this.tabChem.Location = new System.Drawing.Point(4, 22);
            this.tabChem.Name = "tabChem";
            this.tabChem.Padding = new System.Windows.Forms.Padding(3);
            this.tabChem.Size = new System.Drawing.Size(552, 391);
            this.tabChem.TabIndex = 0;
            this.tabChem.Text = "Chemins";
            this.tabChem.UseVisualStyleBackColor = true;
            // 
            // tabFilt
            // 
            this.tabFilt.Controls.Add(this.groupFiltres);
            this.tabFilt.Location = new System.Drawing.Point(4, 22);
            this.tabFilt.Name = "tabFilt";
            this.tabFilt.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilt.Size = new System.Drawing.Size(552, 391);
            this.tabFilt.TabIndex = 1;
            this.tabFilt.Text = "Filtres";
            this.tabFilt.UseVisualStyleBackColor = true;
            // 
            // groupFiltres
            // 
            this.groupFiltres.Location = new System.Drawing.Point(6, 6);
            this.groupFiltres.Name = "groupFiltres";
            this.groupFiltres.Size = new System.Drawing.Size(540, 379);
            this.groupFiltres.TabIndex = 0;
            this.groupFiltres.TabStop = false;
            this.groupFiltres.Text = "Filtres à utiliser";
            // 
            // tabAffich
            // 
            this.tabAffich.Location = new System.Drawing.Point(4, 22);
            this.tabAffich.Name = "tabAffich";
            this.tabAffich.Size = new System.Drawing.Size(552, 391);
            this.tabAffich.TabIndex = 2;
            this.tabAffich.Text = "Affichage";
            this.tabAffich.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(460, 431);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(108, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // FenConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.tabControleur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FenConfig";
            this.Text = "LnSearch - Configuration";
            this.groupChemins.ResumeLayout(false);
            this.groupChemins.PerformLayout();
            this.tabControleur.ResumeLayout(false);
            this.tabChem.ResumeLayout(false);
            this.tabFilt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupChemins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxXML;
        private System.Windows.Forms.Label labelChemin;
        private System.Windows.Forms.TextBox textBoxPDF;
        private System.Windows.Forms.TabControl tabControleur;
        private System.Windows.Forms.TabPage tabChem;
        private System.Windows.Forms.TabPage tabFilt;
        private System.Windows.Forms.GroupBox groupFiltres;
        private System.Windows.Forms.TabPage tabAffich;
        private System.Windows.Forms.Button buttonValider;
    }
}