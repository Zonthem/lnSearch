using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_lnSearch.metier {

    public class Fichier {

        public string Nom { get; set; }

        public string Path { get; set; }

        Dictionary<string, string> donneesComplementaires;

        public Fichier(string nom, string path, Dictionary<string, string> dc = null) {
            Nom = nom;
            Path = path;

            donneesComplementaires = dc ?? new Dictionary<string, string>();
            
        }
        
        public Fichier(Dictionary<string, string> dcs) {
            Nom = dcs["nom"];
            Path = dcs["path"];
            dcs.Remove("nom");
            dcs.Remove("path");
            if (dcs.Count > 0) {
                donneesComplementaires = dcs;
            } else {

            }
            
        }

        public string Get (string key) {
            if (key.Equals("nom")) {
                return Nom;
            }

            if (key.Equals("path")) {
                    return Path;
            }

            return donneesComplementaires[key];
        }

    }
}
