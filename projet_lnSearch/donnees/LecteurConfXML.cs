using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Écrit et lit le fichier XML de fitrage
    /// </summary>
    class LecteurConfXML : FichierXML {

        private int NbFiltresEntres { get; set; }

        public Dictionary<string, List<string>> ListeFiltres { get; }

        public List<string> ListeAffichage { get; }

        /// <summary>
        /// Contructeur en lecture seule, ne crée pas de fichier si il n'existe pas
        /// </summary>
        public LecteurConfXML() : base(VarUtiles.Conf + "conf.xml") {
            if (document != null) {
                ListeFiltres = new Dictionary<string, List<string>>();
                ListeAffichage = new List<string>();
                List<string> sset;

                foreach (XmlNode node in document.GetElementsByTagName("filtre")) {
                    if (node.Attributes["value"].Value.Equals("Texte")) {

                        sset = new List<string>();
                        sset.Add("text");
                        ListeFiltres.Add(node.Attributes["key"].Value, sset);

                    }
                    else if (node.Attributes["value"].Value.Equals("Liste")) {

                        sset = new List<string>();
                        sset.Add("combo");
                        foreach (XmlNode ssNode in node.ChildNodes) {
                            sset.Add(ssNode.Attributes["value"].Value);
                        }
                        ListeFiltres.Add(node.Attributes["key"].Value, sset);

                    }
                    else if (node.Attributes["value"].Value.Equals("Date")) {

                        sset = new List<string>();
                        sset.Add("date");
                        ListeFiltres.Add(node.Attributes["key"].Value, sset);

                    }
                }

                foreach (XmlNode node in document.GetElementsByTagName("aff")) {
                    ListeAffichage.Add(node.Attributes["key"].Value);
                } 

            } else {
                Debug.Write("Fichier inexistant pour LecteurFiltreXML" + Environment.NewLine);
            }
        }
    }
}
