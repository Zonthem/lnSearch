using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_lnSearch.fenetres {

    public partial class FenConfig : Form {

        public FenConfig(List<string> listeFiltres, List<string> listeAffich) {
            InitializeComponent();

            InitChemins();

            InitFiltres(listeFiltres);

            InitAffichges(listeAffich);
        }

        private void InitAffichges(List<string> list) {
            foreach (string s in list) {
                AddChamp(s, groupFiltres);
            }
        }

        private void InitFiltres(List<string> list) {
            foreach (string s in list) {
                AddChamp(s, groupFiltres);
            }
        }

        private void InitChemins() {
            textBoxPDF.Text = VarUtiles.Donnees;
            textBoxXML.Text = VarUtiles.Conf;
        }

        private void AddChamp(string s, Control conteneur) {
            Label txt = new Label();
            txt.Location = new Point(30, 35 + 35 * (conteneur.Controls.Count / 2));
            txt.Size = new Size(100, 24);
            txt.Text = s;

            ComboBox cmb = new ComboBox();
            cmb.Location = new Point(150, 35 + 35 * (conteneur.Controls.Count / 2));
            cmb.Size = new Size(350, 24);
            cmb.Items.Add(VarUtiles.ComboValeurNulle);
            cmb.Items.Add("Texte");
            cmb.Items.Add("Liste");
            cmb.Items.Add("Date");
            cmb.SelectedIndex = 0;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            conteneur.Controls.Add(txt);
            conteneur.Controls.Add(cmb);
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void FenConfig_FormClosed(object sender, FormClosedEventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
