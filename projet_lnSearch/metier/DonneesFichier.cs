using System.Collections.Generic;

namespace projet_lnSearch.metier {

    public class DonneesFichier {

        private Dictionary<string, string> filtres;

        private Dictionary<string, string> donnees;

        public DonneesFichier(Dictionary<string, string> f, Dictionary<string, string> d) {
            filtres = f;
            donnees = d;
        }

    }
}