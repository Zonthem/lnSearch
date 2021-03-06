﻿using projet_lnSearch.donnees;
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

        private LecteurDataXML data;

        private LecteurConfXML filtre;

        public RedacteurXML Redacteur { get; private set; }

        private Accueil acc;

        public bool ModeCreation;

        public Controleur() {
            string creation = ConfigurationManager.AppSettings["modeCreation"] ?? "NON";

            if (creation.Equals("OUI")) {
                lectPDF     = new LecteurPDF(false);
                Redacteur   = new RedacteurXML();
                ModeCreation = true;
            } else {
                lectPDF     = new LecteurPDF(false);
                data        = new LecteurDataXML();
                filtre      = new LecteurConfXML();
                ModeCreation = false;
            }

        }

        internal void Recherche(Dictionary<string, string> valeursFiltres) {
            Thread thFiltrage = new Thread(new ParameterizedThreadStart(data.Filtrer));
            thFiltrage.Start(valeursFiltres);
        }

        internal void initFiltres() {
             foreach(KeyValuePair<string, List<string>> element in filtre.ListeFiltres) {
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

        /// <summary>
        /// Recupere la liste des champs possibles pour afficher dans la datagrid
        /// </summary>
        /// <returns>bah, les champs dans une liste, sans format car string dans tous les cas</returns>
        internal List<string> getAffichagesPossibles() {
            return Redacteur.getAffichagesPossibles();
            //return new List<string>();
        }

        /// <summary>
        /// Recupere la liste des champs possibles sur lesquels filtrer les docs
        /// </summary>
        /// <returns>liste des filtres possibles, non typés (string)</returns>
        internal List<string> getFiltresPossibles() {
            return Redacteur.getFiltresPossibles();
            //return a;
        }

        public void bg_DoWork(object sender, DoWorkEventArgs e) {
            if (e.Argument.Equals("fin")) {
                if (data.Res.Count == 0) {
                    MessageBox.Show("Aucun document trouvé !");
                    return;
                }
                acc.Invoke(new Action(() => {
                    new FenResultat(data.Res).Show();
                }));

            }
            else if (e.Argument.Equals("erreur")) {
                Debug.Write(data.Erreur);
            }
            else if (e.Argument.Equals("ImporterDonnees")) {
                acc.AfficheMessage(lectPDF.Err);
            }
        }
    }
}
