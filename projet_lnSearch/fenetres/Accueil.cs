using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projet_lnSearch.fenetres {

    public partial class Accueil : Form {

        private Controleur c;

        public Accueil(Controleur c) {
            c.setAccueil(this);
            InitializeComponent();
            filtres = new ControlCollection(this);
            labelFiltres = new ControlCollection(this);
            c.initFiltres();
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e) {
            Dictionary<string, string> valeursFiltres = new Dictionary<string, string>();
            for (int i = 0; i < filtres.Count; i++) {
                string cle = (labelFiltres[i].Text.Equals(VarUtiles.ComboValeurNulle) ? "" : labelFiltres[i].Text);

                string val = (filtres[i].Text.Equals("") ? "*" : filtres[i].Text);

                valeursFiltres.Add(cle, val);
            }
            c.Recherche(valeursFiltres);
        }

        internal void AddFiltreTexte(string key) {
            TextBox tb = new TextBox();
            tb.Location = new Point(200, (filtres.Count + 1)*35);
            tb.Name = "textBox" + key;
            tb.Size = new Size(boxFiltres.Width-275, 23);
            tb.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            tb.KeyPress += Accueil_KeyPress;
            tb.TabIndex = filtres.Count;
            filtres.Add(tb);
            filtrePanel.Controls.Add(tb);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(55, 3 + (labelFiltres.Count + 1) * 35);
            lbl.Name = "lbl" + key;
            lbl.Size = new Size(46, 16);
            lbl.Text = key;
            labelFiltres.Add(lbl);
            filtrePanel.Controls.Add(lbl);
        }

        internal void AddFiltreCombo(string key, SortedSet<string> values) {
            ComboBox cmb = new ComboBox();
            cmb.FormattingEnabled = true;
            values.Remove("combo");
            cmb.Items.Add(VarUtiles.ComboValeurNulle);
            cmb.Items.AddRange(values.Cast<Object>().ToArray());
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = 0;
            cmb.Location = new Point(200, (filtres.Count + 1) * 35);
            cmb.Name = "comboBox" + key;
            cmb.Size = new Size(boxFiltres.Width - 275, 24);
            cmb.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            cmb.KeyPress += Accueil_KeyPress;
            cmb.TabIndex = filtres.Count;
            filtres.Add(cmb);
            filtrePanel.Controls.Add(cmb);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(55, 3 + (labelFiltres.Count + 1) * 35);
            lbl.Name = "lbl" + key;
            lbl.Size = new Size(46, 16);
            lbl.Text = key;
            labelFiltres.Add(lbl);
            filtrePanel.Controls.Add(lbl);
        }

        private void Accueil_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                button1.PerformClick();
            }
        }
    }
}
