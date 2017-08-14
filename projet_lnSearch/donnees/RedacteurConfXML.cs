using projet_lnSearch.application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {

    class RedacteurConfXML : FichierXML {

        public Dictionary<string, List<string>> ListeFiltres { get; private set; }

        public List<string> ListeAffichage { get; private set; }

        public RedacteurConfXML(List<string> filtres, List<string> affichage) : base(VarUtiles.Conf + "conf.xml", true) {
            ListeAffichage = affichage;
            ListeFiltres = new Dictionary<string, List<string>>();
            foreach (string s in filtres) {
                ListeFiltres.Add(s, new List<string>());
            }
        }

        public void ModifierListeFiltres(Dictionary<string, List<string>> dict) {
            ListeFiltres = dict;
        }

        public void ModifierListeFiltres(Dictionary<string, string> filtres, Dictionary<string, List<string>> combos) {
            ListeFiltres = new Dictionary<string, List<string>>();
            List<string> lst;
            foreach (KeyValuePair<string, string> kvp in filtres) {
                if (!kvp.Value.Equals("Liste")) {
                    ListeFiltres.Add(kvp.Key, new List<string> { kvp.Value });
                } else {
                    lst = new List<string>();
                    lst.Add(kvp.Value);
                    lst.AddRange(combos[kvp.Key]);
                    ListeFiltres.Add(kvp.Key, new List<string>(lst));
                }
            }
        }

        public void ModifierListeAffichage(List<string> list) {
            ListeAffichage = list;
        }

        public new bool Sauvegarder() {
            XmlElement root = document.DocumentElement;
            XmlElement filtres = document.CreateElement(string.Empty, "filtres", string.Empty);
            root.AppendChild(filtres);
            //add les filtres
            XmlElement filtre;
            XmlElement val;
            XmlAttribute key;
            XmlAttribute value;
            foreach (KeyValuePair<string, List<string>> kvp in ListeFiltres) {
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
            foreach (string s in ListeAffichage) {
                aff = document.CreateElement(string.Empty, "aff", string.Empty);
                key = document.CreateAttribute("key");
                key.Value = s[0] == '/' ? s.Substring(1) : s;
                aff.Attributes.Append(key);
                affichages.AppendChild(aff);
            }

            return base.Sauvegarder();
        }
    }
}
