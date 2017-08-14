using projet_lnSearch.application;
using projet_lnSearch.donnees;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace projet_lnSearch.fenetres {

    public partial class FenConfig : Form {

        private RedacteurXML red;

        public FenConfig(List<string> listeFiltres, List<string> listeAffich, RedacteurXML red) {
            this.red = red;

            InitializeComponent();

            InitChemins();
            InitFiltres(listeFiltres);
            InitAffichges(listeAffich);
        }

        private void InitAffichges(List<string> list) {
            foreach (string s in list) {
                AddChampAff(s, panelAffichages);
            }
        }

        private void InitFiltres(List<string> list) {
            foreach (string s in list) {
                AddChampFiltre(s, panelFiltres);
            }
        }

        private void InitChemins() {
            textBoxPDF.Text = VarUtiles.Donnees;
            textBoxXML.Text = VarUtiles.Conf;
        }

        private void AddChampAff(string s, Panel conteneur) {
            CheckBox cb = new CheckBox();
            cb.Location = new Point(30, 10 + 25 * (conteneur.Controls.Count));
            cb.Size = new Size(100, 24);
            cb.Text = s;

            conteneur.Controls.Add(cb);
        }

        private void AddChampFiltre(string s, Control conteneur) {
            Label txt = new Label();
            txt.Location = new Point(30, 10 + 35 * (conteneur.Controls.Count / 2));
            txt.Size = new Size(100, 24);
            txt.Text = s;

            ComboBox cmb = new ComboBox();
            cmb.Location = new Point(150, 10 + 35 * (conteneur.Controls.Count / 2));
            cmb.Size = new Size(350, 24);
            cmb.Items.Add(VarUtiles.ComboValeurNulle);
            cmb.Items.Add("Texte");
            cmb.Items.Add("Liste");
            cmb.Items.Add("Date");
            cmb.SelectedIndex = 0;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Name = s;

            conteneur.Controls.Add(txt);
            conteneur.Controls.Add(cmb);
        }

        private void button1_Click(object sender, EventArgs e) {
            Dictionary<string, List<string>> dictFiltres = new Dictionary<string, List<string>>();

            //preparer lectPDF pour une seule utilisation
            //Wait, c'est pas à FenConfig d'écrire les XML nan ?
            foreach (Control c in panelFiltres.Controls) {
                if (c is ComboBox && !((ComboBox)c).SelectedItem.Equals(VarUtiles.ComboValeurNulle)) {
                    if (((ComboBox)c).SelectedItem.Equals("Liste")) {
                        red.AddRechercheCombo(c.Name);
                    }
                    red.AddFiltre(c.Name, (string)((ComboBox)c).SelectedItem);
                }
            }
            foreach (Control c in panelAffichages.Controls) {
                if (((CheckBox)c).Checked) red.AddAffich(c.Text);
            }
            //Mettre un message d'attente ICI
            /*Thread th = new Thread(new ThreadStart(red.StartProcessing));
            th.Start();*/
            red.StartProcessing();
            ConfigurationManager.AppSettings["modeCreation"] = "non";
            MessageBox.Show("Fini wesh maggle!");
        }

        private void FenConfig_FormClosed(object sender, FormClosedEventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
