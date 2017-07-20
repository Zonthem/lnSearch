using System.Collections.Generic;

namespace projet_lnSearch.metier {

    public class Resultat {

        public int Count { get; private set; }

        private List<Fichier> donnees;

        public List<string> Headers { get; private set; }

        public Fichier FichierCourant { get; set; }

        private int indiceCourant = 0;

        public Resultat() {
            donnees = new List<Fichier>();
            Count = 0;
            Headers = new List<string>();
            Headers.Add("Nom");
            Headers.Add("Path");

            indiceCourant = 0;
        }

        public Resultat(List<Dictionary<string, string>> entree) {
            donnees = new List<Fichier>();
            Count = entree.Count;
            foreach (Dictionary<string,string> dict in entree) {

                donnees.Add(new Fichier(dict));

                if (Headers == null) {
                    Headers = new List<string>(dict.Keys);
                }
            }

            indiceCourant = 0;
        }

        internal void SetPage(int page) {
            indiceCourant = 20 * (page-1);
            if (indiceCourant > Count) {
                throw new System.Exception("SetPage -> Out of bounds");
            }
        }

        public void AddResultat(Dictionary<string,string> ajout) {
            donnees.Add(new Fichier(ajout));
            Count++;
        }

        public Fichier Get() {
            return (Count < 1 ? null : donnees[indiceCourant]);
        }

        public bool Next() {
            indiceCourant++;
            if (indiceCourant >= Count) {
                indiceCourant = 0;
                return false;
            }
            return true;
        }
    }
}
