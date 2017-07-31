using PdfSharp.Pdf.IO;
using projet_lnSearch.application;
using projet_lnSearch.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projet_lnSearch.fenetres {

    public partial class Accueil : Form {

        private Controleur c;

        private int compteurF = 0;

        public Accueil(Controleur c) {
            c.setAccueil(this);
            InitializeComponent();
            filtres = new ControlCollection(this);
            labelFiltres = new ControlCollection(this);
            if (!c.ModeCreation) {
                c.initFiltres(); 
            }
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e) {
            Dictionary<string, string> valeursFiltres = new Dictionary<string, string>();
            string cle, val;
            for (int i = 0; i < filtres.Count; i++) {
                cle = labelFiltres[i].Text;

                if (filtres[i] is TextBox) {
                    val = (filtres[i].Text.Equals("") ? "*" : filtres[i].Text);
                } else if (filtres[i] is ComboBox) {
                    val = (((ComboBox)filtres[i]).SelectedItem.Equals(VarUtiles.ComboValeurNulle) ? "" : ((ComboBox)filtres[i]).SelectedItem.ToString());
                } else if (filtres[i] is DateSelecteur) {
                    if (((DateSelecteur)filtres[i]).Operation.SelectedItem.Equals("Après")) {
                        val = ">" + ((DateSelecteur)filtres[i]).Text;
                    } else if (((DateSelecteur)filtres[i]).Operation.SelectedItem.Equals("Avant")) {
                        val = "<" + ((DateSelecteur)filtres[i]).Text;
                    } else if (((DateSelecteur)filtres[i]).Operation.SelectedItem.Equals("Entre")) {
                        val = "&" + ((DateSelecteur)filtres[i]).Text + "=" + ((DateSelecteur)filtres[i]).Extremite.Text;
                    } else {
                        val = "";
                    }
                } else {
                    val = "";
                }
                

                valeursFiltres.Add(cle, val);
            }
            c.Recherche(valeursFiltres);
        }

        internal void AddFiltreTexte(string key) {
            TextBox tb = new TextBox();
            tb.Location = new Point(200, (compteurF + 1)*35);
            tb.Name = "textBox" + key;
            tb.Size = new Size(boxFiltres.Width-275, 24);
            tb.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            tb.KeyPress += Accueil_KeyPress;
            tb.TabIndex = filtres.Count;
            filtres.Add(tb);
            filtrePanel.Controls.Add(tb);
            compteurF++;

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
            cmb.Location = new Point(200, (compteurF + 1) * 35);
            cmb.Name = "comboBox" + key;
            cmb.Size = new Size(boxFiltres.Width - 275, 24);
            cmb.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            cmb.KeyPress += Accueil_KeyPress;
            cmb.TabIndex = filtres.Count;
            filtres.Add(cmb);
            filtrePanel.Controls.Add(cmb);
            compteurF++;

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(55, 3 + (labelFiltres.Count + 1) * 35);
            lbl.Name = "lbl" + key;
            lbl.Size = new Size(46, 16);
            lbl.Text = key;
            labelFiltres.Add(lbl);
            filtrePanel.Controls.Add(lbl);
        }

        internal void AddFiltreDate(string key) {

            DateSelecteur dtp = new DateSelecteur();
            dtp.Size = new Size(boxFiltres.Width - 463, 24);
            dtp.Location = new Point(200, (compteurF + 1) * 35);
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Name = "DatePicker" + key;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyymmdd";
            dtp.KeyPress += Accueil_KeyPress;
            dtp.TabIndex = filtres.Count;
            filtres.Add(dtp);
            filtrePanel.Controls.Add(dtp);

            DateTimePicker last = new DateTimePicker();
            last.Size = new Size(boxFiltres.Width - 463, 24);
            last.Location = new Point(boxFiltres.Width - 75 - dtp.Size.Width, (compteurF + 1) * 35);
            last.Format = DateTimePickerFormat.Short;
            last.Name = "DateBox" + key;
            last.Format = DateTimePickerFormat.Custom;
            last.CustomFormat = "yyyymmdd";
            last.KeyPress += Accueil_KeyPress;
            last.TabIndex = filtres.Count;
            last.Visible = false;
            filtrePanel.Controls.Add(last);

            ComboBox cmb = new ComboBox();
            cmb.FormattingEnabled = true;
            cmb.Items.Add("Après");
            cmb.Items.Add("Avant");
            cmb.Items.Add("Entre");
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = 0;
            cmb.Size = new Size(62, 24);
            cmb.Location = new Point(dtp.Location.X + dtp.Size.Width + 6, (compteurF + 1) * 35);
            cmb.Name = "Box" + key;
            cmb.KeyPress += Accueil_KeyPress;
            cmb.TabIndex = filtres.Count;
            cmb.SelectedValueChanged += dateComboChange;
            filtrePanel.Controls.Add(cmb);

            dtp.Extremite = last;
            dtp.Operation = cmb;
            
            compteurF++;

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Location = new Point(55, 3 + (labelFiltres.Count + 1) * 35);
            lbl.Name = "lbl" + key;
            lbl.Size = new Size(46, 16);
            lbl.Text = key;
            labelFiltres.Add(lbl);
            filtrePanel.Controls.Add(lbl);
        }

        private void OuvreFenConfig() {
            this.Invoke(new Action(() => {
                new FenConfig(c.getFiltresPossibles(), c.getAffichagesPossibles()).ShowDialog();
            }));
        }

        internal void AfficheMessage(string msg) {
            MessageBox.Show(msg);
        }

        private void dateComboChange(object sender, EventArgs e) {
            foreach (Control c in filtres) {
                if (c is DateSelecteur && ((DateSelecteur)c).Operation.Equals((ComboBox)sender)) {
                    if (((DateSelecteur)c).Operation.SelectedItem.Equals("Entre")) {
                        ((DateSelecteur)c).Extremite.Visible = true;
                    } else {
                        ((DateSelecteur)c).Extremite.Visible = false;
                    }
                }
            }
            
        }

        private void Accueil_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                button1.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Invoke(new Action(() => {
                new FenAide().Show();
            }));
        }

        private void button2_Click(object sender, EventArgs e) {
            foreach (Control c in filtres) {
                if (c is TextBox) {
                    ((TextBox)c).Text = "";
                } else if (c is ComboBox) {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
        }

        private void Accueil_Load(object sender, EventArgs e) {
            if (c.ModeCreation && MessageBox.Show("Voulez-vous configurer l'outil ?", "Initialisation", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                OuvreFenConfig();
            } else if (c.ModeCreation) {
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}
