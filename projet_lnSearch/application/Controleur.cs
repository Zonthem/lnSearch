using projet_lnSearch.donnees;
using projet_lnSearch.fenetres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;

namespace projet_lnSearch.application {
    /// <summary>
    /// Classe cerveau de l'application, stocke les données et envoie les requètes
    /// vers les autres classes.
    /// </summary>
    public class Controleur {

        private LecteurPDF lectPDF;

        private LecteurXML lectXML;

        private FiltreXML filtre;

        private DataXML data;

        private Accueil acc;

        private FenResultat resultatForm;

        public Controleur() {
            string creation = ConfigurationManager.AppSettings["modeCreation"] ?? "NON";
            Debug.Write(creation);

            if (creation.Equals("OUI")) {
                lectPDF     = new LecteurPDF(true);
                lectXML     = new LecteurXML();
                filtre      = new FiltreXML();
                data        = new DataXML();
            }

        }

        internal void Recherche(Dictionary<string, string> valeursFiltres) {
            Thread thFiltrage = new Thread(new ParameterizedThreadStart(lectXML.Filtrer));
            thFiltrage.Start(valeursFiltres);
        }

        internal void initFiltres() {
            /*
             * Temporaire, création toute faite
             */
             foreach(KeyValuePair<string, SortedSet<string>> element in filtre.ListeFiltres) {
                if (element.Value.ElementAt(0).Equals("text")) {
                    acc.AddFiltreTexte(element.Key);
                } else if (element.Value.ElementAt(0).Equals("combo")) {
                    acc.AddFiltreCombo(element.Key, element.Value);
                } else if (element.Value.ElementAt(0).Equals("date")) {
                    acc.AddFiltreDate(element.Key);
                }
            }
        }

        public Accueil setAccueil(Accueil a) {
            acc = a;
            return acc;
        }

        public void bg_DoWork(object sender, DoWorkEventArgs e) {
            if (e.Argument.Equals("fin")) {
                if (lectXML.Res.Count == 0) {
                    MessageBox.Show("Aucun document trouvé !");
                    return;
                }
                acc.Invoke(new Action(() => {
                    new FenResultat(lectXML.Res).Show();
                }));
                
            } else if (e.Argument.Equals("erreur")) {
                Debug.Write(lectXML.Erreur);
            }
        }
    }
}
