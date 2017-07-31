using projet_lnSearch.application;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Ouvre et gère les fichiers PDF 
    /// </summary>
    class LecteurPDF {
        private bool enCreation;

        public string Err { get; set; }

        private List<string> listeFichiers;

        public int NbDocuments { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="creation">Vrai si l'objet sert à créer la base, faux s'il ne sert qu'à lire</param>
        /// <param name="chemin">Chemin du dossier racine des PDF</param>
        public LecteurPDF(bool creation) {
            enCreation = creation;
            listeFichiers = ImporterDonnees(VarUtiles.CheminApp +  VarUtiles.Donnees);
            Err = "";
        }

        /// <summary>
        /// Pointe le fichier PDF suivant tant qu'il y en a
        /// </summary>
        /// <returns>renvoi faux si il n'y a pas de PDF suivant, Vrai sinon</returns>
        public bool nextPDF() {
            return false;
        }

        /// <summary>
        /// Lis le fichier selectionné pour récupérer les valeurs des filtres
        /// </summary>
        /// <returns>les filtres disponibles du fichier</returns>
        public Dictionary<string, string> LireDonneesUnique() {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Nom", "nom du doc");
            dict.Add("Code", "192 168 0 1");
            return dict;
        }

        /// <summary>
        /// Ouvre le fichier PDF sélectionner pour consultation utilisateur
        /// </summary>
        /// <returns>Faux si une erreur apparaît, Vrai sinon</returns>
        public bool Ouvrir() {
            return false;
        }

        /// <summary>
        /// Remplis la classe avec les pdf dans le dossier fourni
        /// (tri récursif sur les sous-dossiers)
        /// </summary>
        /// <param name="cheminRelatif">Chemin à partir de l'application</param>
        /// <returns>Faux si une erreur est apparue, Vrai sinon</returns>
        private List<string> ImporterDonnees(string sDir) {
            {
                List<string> files = new List<string>();
                try {
                    foreach (string f in Directory.GetFiles(sDir)) {
                        files.Add(f);
                        NbDocuments++;
                    }
                    foreach (string d in Directory.GetDirectories(sDir)) {
                        files.AddRange(ImporterDonnees(d));
                    }
                }
                catch (System.Exception excpt) {
                    Debug.Write("exception dans ImporterDonnees()");
                    Err = excpt.Message;
                    Runner._bg.RunWorkerAsync("ImporterDonnees");
                }

                return files;
            };
        }
    }
}
