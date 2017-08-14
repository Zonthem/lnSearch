using projet_lnSearch.application;
using projet_lnSearch.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Ecrit le fichier XML de data
    /// </summary>
    class RedacteurDataXML : FichierXML {

        private int NbDocumentsEntres { get; set; }

        private List<DonneesFichier> liste;

        public RedacteurDataXML() : base(VarUtiles.Conf + "data.xml", true) {
            liste = new List<DonneesFichier>();
        }

        public void AddData(List<DonneesFichier> lst) {
            liste = lst;
        }

        public new bool Sauvegarder() {
            XmlNode root = document.DocumentElement;
            XmlNode fichier, filtre, donnees, d;
            XmlAttribute key, val;
            foreach (DonneesFichier df in liste) {
                fichier = document.CreateElement(string.Empty, "fichier", string.Empty);
                //filtres
                foreach (KeyValuePair<string, string> kvp in df.GetFiltres()) {
                    filtre = document.CreateElement(string.Empty, "filtre", string.Empty);
                    key = document.CreateAttribute("key");
                    key.Value = kvp.Key[0] == '/' ? kvp.Key.Substring(1) : kvp.Key;
                    filtre.Attributes.Append(key);
                    val = document.CreateAttribute("value");
                    val.Value = kvp.Value;
                    filtre.Attributes.Append(val);

                    fichier.AppendChild(filtre);
                }

                donnees = document.CreateElement(string.Empty, "donnees", string.Empty);
                //donnees
                foreach (KeyValuePair<string, string> kvp in df.GetDonnees()) {
                    d = document.CreateElement(string.Empty, kvp.Key.Substring(1).ToLower(), string.Empty);
                    d.InnerText = kvp.Value;

                    donnees.AppendChild(d);
                }
                fichier.AppendChild(donnees);
                root.AppendChild(fichier);
                
            }
            return base.Sauvegarder();
        }
    }
}
