using projet_lnSearch.donnees;
using projet_lnSearch.fenetres;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                } else {
                    acc.AddFiltreCombo(element.Key, element.Value);
                }
            }
        }

        public Accueil setAccueil(Accueil a) {
            acc = a;
            return acc;
        }
    }
}
