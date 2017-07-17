using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Parcours les fichiers XML bases pour en sortir les informations utiles
    /// </summary>
    class LecteurXML : FichierXML {

        private List<Dictionary<string, string>> Res { get; set; }

        public LecteurXML() : base("data.xml") {

        }

        public void Filtrer(object valeursFiltres) {
            Dictionary<string, string> valeurs = valeursFiltres as Dictionary<string, string>;
            Res = new List<Dictionary<string, string>>();
            Dictionary<string, string> dataAjout;

            //Nombre de filtres
            int nbFiltres = 0;
            foreach(XmlNode node in document.GetElementsByTagName("fichier").Item(0).ChildNodes) {
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
                    if (valeurTemporaire.Equals(node.ChildNodes[nbCourant].Attributes["value"].Value)) {
                        nbCourant++;
                    } else {
                        valide = false;
                    }
                }

                //Ajout si correct
                if (valide) {
                    dataAjout = new Dictionary<string, string>();
                    foreach (XmlNode ssNode in node["donnees"].ChildNodes) {
                        dataAjout.Add(ssNode.Name, ssNode.InnerText);
                    }
                    Res.Add(dataAjout);
                }

            }

            Runner._bg.RunWorkerAsync("Message à travers l'espace : " + Res);
        }
    }
}
