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
    public partial class FenAide : Form {
        public FenAide() {
            InitializeComponent();

            InitUtilisation();

            InitContact();
        }

        private void InitContact() {
            labelContact.Text =
                "Pour tous problèmes, veuillez envoyer un e-mail à l'adresse suivante\n\n"
                + "                         support@lnse.fr";
        }

        private void InitUtilisation() {
            labelUtilisation.Text =
                "Ce logiciel vous est founi sur un support en accompagnement de fichiers PDF.\n"
                + "Il ne faut surtout pas modifier les noms des dossiers ou des fichiers, ni les déplacer au risque de\n"
                + "rendre le logiciel inopérant.\n\n"
                + "Pour rechercher un PDF, remplir les champs de recherche selon le docment recherché.\n"
                + "Un champ vide n'est pas pris en compte dans la recherche.";
        }

        private void buttonFermerAide_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
