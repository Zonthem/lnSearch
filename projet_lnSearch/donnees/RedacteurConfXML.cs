using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {

    class RedacteurConfXML : FichierXML {

        public Dictionary<string, SortedSet<string>> ListeFiltres { get; private set; }

        public List<string> ListeAffichage { get; private set; }

        public RedacteurConfXML(List<string> filtres, List<string> affichage) : base(VarUtiles.Conf + "conf.xml", true) {
            ListeAffichage = affichage;
            ListeFiltres = new Dictionary<string, SortedSet<string>>();
            foreach (string s in filtres) {
                ListeFiltres.Add(s, new SortedSet<string>());
            }
        }

        public void ModifierListeFiltres(Dictionary<string, SortedSet<string>> dict) {
            ListeFiltres = dict;
        }

        public void ModifierListeAffichage(List<string> list) {
            ListeAffichage = list;
        }

        public new bool Sauvegarder() {
            XmlElement root = document.CreateElement(string.Empty, "config", string.Empty);
            document.AppendChild(root);
            XmlElement filtres = document.CreateElement(string.Empty, "filtres", string.Empty);
            root.AppendChild(filtres);
            //add les filtres
            XmlElement filtre;
            XmlElement val;
            XmlAttribute key;
            XmlAttribute value;
            foreach (KeyValuePair<string, SortedSet<string>> kvp in ListeFiltres) {
                filtre = document.CreateElement(string.Empty, "filtre", string.Empty);

                key = document.CreateAttribute("key");
                key.Value = kvp.Key;
                filtre.Attributes.Append(key);

                value = document.CreateAttribute("value");
                value.Value = kvp.Value.ElementAt(0);
                filtre.Attributes.Append(value);
                if (kvp.Value.Count > 1) {
                    for (int i = 1; i < kvp.Value.Count; i++) {
                        val = document.CreateElement(string.Empty, "val", string.Empty);
                        value = document.CreateAttribute("value");
                        value.Value = kvp.Value.ElementAt(i);
                        val.Attributes.Append(value);
                        filtre.AppendChild(val);
                    }
                }
                filtres.AppendChild(filtre);
            }

            XmlElement affichages = document.CreateElement(string.Empty, "affichages", string.Empty);
            root.AppendChild(affichages);
            //add les affichages
            XmlElement aff;
            foreach(string s in ListeAffichage) {
                aff = document.CreateElement(string.Empty, "aff", string.Empty);
                key = document.CreateAttribute("key");
                key.Value = s;
                aff.Attributes.Append(key);
                affichages.AppendChild(aff);
            }

            return base.Sauvegarder();
        }
    }
}
