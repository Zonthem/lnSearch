using projet_lnSearch.application;
using projet_lnSearch.metier;
using System;
using System.Collections.Generic;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Parcours les fichiers XML bases pour en sortir les informations utiles
    /// </summary>
    class LecteurXML : FichierXML {

        internal Resultat Res { get; set; }

        internal string Erreur { get; private set; }

        public LecteurXML() : base("conf\\data.xml") {

        }

        public void Filtrer(object valeursFiltres) {
            try {
                Dictionary<string, string> valeurs = valeursFiltres as Dictionary<string, string>;
                Res = new Resultat();
                Dictionary<string, string> dataAjout;

                //Nombre de filtres
                int nbFiltres = 0;
                foreach (XmlNode node in document.GetElementsByTagName("fichier").Item(0).ChildNodes) {
                    if (node.Name.Equals("filtre")) nbFiltres++;
                }

                //Variables de check de parcous de fichier
                int nbCourant;
                bool valide;
                string valeurTemporaire;

                foreach (XmlNode node in document.GetElementsByTagName("fichier")) {

                    valide = true;
                    nbCourant = 0;

                    //Check de chaque filtre avec interruption si necessaire
                    while (valide && nbCourant < nbFiltres) {
                        valeurs.TryGetValue(node.ChildNodes[nbCourant].Attributes["key"].Value, out valeurTemporaire);
                        if (FiltreAccepte(valeurTemporaire, node.ChildNodes[nbCourant].Attributes["value"].Value)) {
                            nbCourant++;
                        }
                        else {
                            valide = false;
                        }
                    }

                    //Ajout si correct
                    if (valide) {
                        dataAjout = new Dictionary<string, string>();
                        foreach (XmlNode ssNode in node["donnees"].ChildNodes) {
                            dataAjout.Add(ssNode.Name, ssNode.InnerText);
                        }
                        Res.AddResultat(dataAjout);
                    }

                }

                Runner._bg.RunWorkerAsync("fin");
            } catch (Exception ex) {
                Erreur = ex.Message;
                Runner._bg.RunWorkerAsync("erreur");
            }
        }

        private bool FiltreAccepte(string valeurTemporaire, string value) {
            if (valeurTemporaire.Equals("*") || valeurTemporaire.Equals(VarUtiles.ComboValeurNulle)) return true;

            if (valeurTemporaire.Equals(value)) return true;

            return false;
        }
    }
}
