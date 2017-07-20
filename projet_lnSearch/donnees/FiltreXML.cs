using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Écrit et lit le fichier XML de fitrage
    /// </summary>
    class FiltreXML : FichierXML {

        private int NbFiltresEntres { get; set; }

        public Dictionary<string, SortedSet<string>> ListeFiltres { get; }

        /// <summary>
        /// Contructeur en lecture seule, ne crée pas de fichier si il n'existe pas
        /// </summary>
        public FiltreXML() : base("conf\\filtres.xml") {
            ListeFiltres = new Dictionary<string, SortedSet<string>>();
            SortedSet<string> sset;

            foreach (XmlNode node in document.GetElementsByTagName("filtre")) {
                if (node.Attributes["value"].Value.Equals("text")) {

                    sset = new SortedSet<string>();
                    sset.Add("text");
                    ListeFiltres.Add(node.Attributes["key"].Value, sset);

                } else if (node.Attributes["value"].Value.Equals("combo")) {

                    sset = new SortedSet<string>();
                    sset.Add("combo");
                    foreach (XmlNode ssNode in node.ChildNodes) {
                        sset.Add(ssNode.Attributes["value"].Value);
                    }
                    ListeFiltres.Add(node.Attributes["key"].Value, sset);

                } else if (node.Attributes["value"].Value.Equals("date")) {

                    sset = new SortedSet<string>();
                    sset.Add("date");
                    ListeFiltres.Add(node.Attributes["key"].Value, sset);

                }
            } 
        }

        public bool AddFiltre() {
            return false;
        }
    }
}
