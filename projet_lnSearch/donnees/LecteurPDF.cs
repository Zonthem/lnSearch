using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Ouvre et gère les fichiers PDF 
    /// </summary>
    class LecteurPDF {
        private bool enCreation;

        private string rep;

        private List<string> listeFichiers;

        private int Nb;

        public int NbDocuments {
            get {
                return Nb;
            }
            set {
                Nb = value;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="creation">Vrai si l'objet sert à créer la base, faux s'il ne sert qu'à lire</param>
        /// <param name="chemin">Chemin du dossier racine des PDF</param>
        public LecteurPDF(bool creation, string chemin = "/data/") {
            enCreation = creation;
        }

        /// <summary>
        /// Pointe le fichier PDF suivant tant qu'il y en a
        /// </summary>
        /// <returns>renvoi faux si il n'y a pas de PDF suivant, Vrai sinon</returns>
        public bool nextPDF() {
            return false;
        }

        /// <summary>
        /// Lis le fichier selectionné pour récupérer les filtres
        /// </summary>
        /// <returns>les filtres disponibles du fichier</returns>
        public string LireDonneesUnique() {
            return "";
        }

        /// <summary>
        /// Ouvre le fichier PDF sélectionner pour consultation utilisateur
        /// </summary>
        /// <returns>Faux si une erreur apparaît, Vrai sinon</returns>
        public bool Ouvrir() {
            return false;
        }

        /// <summary>
        /// Enregistre les fichiers trouvés dans le répertoire fourni dans listeFichier
        /// (tri récursif sur les sous-dossiers)
        /// </summary>
        /// <param name="cheminRelatif">Chemin à partir de l'application</param>
        /// <returns>Faux si une erreur est apparue, Vrai sinon</returns>
        private bool ImporterDonnees(string cheminRelatif) {
            return false;
        }
    }
}
