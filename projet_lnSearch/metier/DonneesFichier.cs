using System.Collections.Generic;

namespace projet_lnSearch.metier {

    public class DonneesFichier {

        private Dictionary<string, string> filtres;

        private Dictionary<string, string> donnees;

        public DonneesFichier(Dictionary<string, string> f, Dictionary<string, string> d) {
            filtres = f;
            donnees = d;
        }

        public DonneesFichier() {
            filtres = new Dictionary<string, string>();
            donnees = new Dictionary<string, string>();
        }

        public void AddFiltre(string cle, string val) {
            filtres.Add(cle, val);
        }

        public void AddDonnees(string cle, string val) {
            donnees.Add(cle, val);
        }

        public Dictionary<string, string> GetDonnees() {
            return donnees;
        }

        public Dictionary<string, string> GetFiltres() {
            return filtres;
        }

    }
}