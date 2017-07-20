namespace projet_lnSearch.fenetres {
    partial class FenAide {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenAide));
            this.groupUtilisation = new System.Windows.Forms.GroupBox();
            this.labelUtilisation = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.buttonFermerAide = new System.Windows.Forms.Button();
            this.groupUtilisation.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUtilisation
            // 
            this.groupUtilisation.Controls.Add(this.labelUtilisation);
            this.groupUtilisation.Location = new System.Drawing.Point(12, 12);
            this.groupUtilisation.Name = "groupUtilisation";
            this.groupUtilisation.Size = new System.Drawing.Size(504, 225);
            this.groupUtilisation.TabIndex = 0;
            this.groupUtilisation.TabStop = false;
            this.groupUtilisation.Text = "Utilisation";
            // 
            // labelUtilisation
            // 
            this.labelUtilisation.AutoSize = true;
            this.labelUtilisation.Location = new System.Drawing.Point(20, 27);
            this.labelUtilisation.Name = "labelUtilisation";
            this.labelUtilisation.Size = new System.Drawing.Size(94, 13);
            this.labelUtilisation.TabIndex = 0;
            this.labelUtilisation.Text = "Texte non-initialisé";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(20, 27);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(94, 13);
            this.labelContact.TabIndex = 0;
            this.labelContact.Text = "Texte non-initialisé";
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.labelContact);
            this.groupContact.Location = new System.Drawing.Point(12, 243);
            this.groupContact.Name = "groupContact";
            this.groupContact.Size = new System.Drawing.Size(504, 88);
            this.groupContact.TabIndex = 1;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "Contact";
            // 
            // buttonFermerAide
            // 
            this.buttonFermerAide.Location = new System.Drawing.Point(430, 337);
            this.buttonFermerAide.Name = "buttonFermerAide";
            this.buttonFermerAide.Size = new System.Drawing.Size(86, 23);
            this.buttonFermerAide.TabIndex = 2;
            this.buttonFermerAide.Text = "Fermer";
            this.buttonFermerAide.UseVisualStyleBackColor = true;
            this.buttonFermerAide.Click += new System.EventHandler(this.buttonFermerAide_Click);
            // 
            // FenAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 366);
            this.Controls.Add(this.buttonFermerAide);
            this.Controls.Add(this.groupContact);
            this.Controls.Add(this.groupUtilisation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 405);
            this.MinimumSize = new System.Drawing.Size(544, 405);
            this.Name = "FenAide";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Aide";
            this.groupUtilisation.ResumeLayout(false);
            this.groupUtilisation.PerformLayout();
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUtilisation;
        private System.Windows.Forms.Label labelUtilisation;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.Button buttonFermerAide;
    }
}