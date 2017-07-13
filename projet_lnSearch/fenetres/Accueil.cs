using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            tb.TabIndex = filtres.Count;
            filtres.Add(tb);
            boxFiltres.Controls.Add(tb);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(55, 3 + (labelFiltres.Count + 1) * 35);
            lbl.Name = "lbl" + key;
            lbl.Size = new Size(46, 16);
            lbl.Text = key;
            labelFiltres.Add(lbl);
            boxFiltres.Controls.Add(lbl);
        }

        internal void AddFiltreCombo(string key, SortedSet<string> values) {
            ComboBox cmb = new ComboBox();
            cmb.FormattingEnabled = true;
            values.Remove("combo");
            cmb.Items.Add(VarUtiles.ComboValeurNulle.Cast<object>());
            cmb.Items.AddRange(values.Cast<Object>().ToArray());
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Location = new Point(200, (filtres.Count + 1) * 35);
            cmb.Name = "comboBox" + key;
            cmb.Size = new Size(boxFiltres.Width - 275, 24);
            cmb.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            cmb.TabIndex = filtres.Count;
            filtres.Add(cmb);
            boxFiltres.Controls.Add(cmb);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(55, 3 + (labelFiltres.Count + 1) * 35);
            lbl.Name = "lbl" + key;
            lbl.Size = new Size(46, 16);
            lbl.Text = key;
            labelFiltres.Add(lbl);
            boxFiltres.Controls.Add(lbl);
        }
    }
}
