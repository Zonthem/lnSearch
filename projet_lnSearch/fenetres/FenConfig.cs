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

    public partial class FenConfig : Form {

        public FenConfig(List<string> listeFiltres, List<string> listeAffich) {
            InitializeComponent();

            InitChemins();

            InitFiltres();
        }

        private void InitFiltres() {
            
        }

        private void InitChemins() {
            textBoxPDF.Text = VarUtiles.Donnees;
            textBoxXML.Text = VarUtiles.Filtres;
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
