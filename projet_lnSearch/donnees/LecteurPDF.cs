using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using projet_lnSearch.application;
using System;
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
        /// Lis le fichier selectionné pour récupérer les valeurs des filtres
        /// </summary>
        /// <returns>les filtres disponibles du fichier</returns>
        public Dictionary<string, string> LireDonneesUnique(string mode) {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (enCreation == true && NbDocuments > 0) {
                try {
                    PdfDocument doc = PdfReader.Open(listeFichiers[0]);
                    foreach (KeyValuePair<string, PdfItem> kvp in doc.Info) {
                        Debug.Write(kvp.Key + " - " + kvp.Value + Environment.NewLine);
                    }
                }
                catch (Exception ex) {
                    Debug.Write(ex.Message + Environment.NewLine);
                }
            }
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
        /// <param name="sDir">Chemin à partir de l'application</param>
        /// <returns>la liste des fichiers</returns>
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
