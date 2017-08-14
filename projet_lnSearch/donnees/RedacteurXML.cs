using projet_lnSearch.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Classe de gestion des classes d'écriture des données.
    /// À n'utiliser que lors de la configuration
    /// </summary>
    public class RedacteurXML {
        private RedacteurDataXML dXml;

        private RedacteurConfXML fXml;

        private LecteurPDF lectPDF;

        private Dictionary<string, List<string>> listesCombo;

        private Dictionary<string, string> listeFiltres;

        private List<string> listeAffich;

        private List<DonneesFichier> listeFichier;

        public RedacteurXML() {
            dXml = new RedacteurDataXML();
            fXml = new RedacteurConfXML(new List<string>(), new List<string>());
            lectPDF = new LecteurPDF(true);
            listesCombo = new Dictionary<string, List<string>>();
            listeFiltres = new Dictionary<string, string>();
            listeAffich = new List<string>();
            listeFichier = new List<DonneesFichier>();
        }

        public bool SetFiltres() {
            return false;
        }

        public bool SetDatas() {
            return false;
        }

        internal List<string> getAffichagesPossibles() {
            return new List<string>(lectPDF.LireDonneesUnique("a").Keys);
        }

        internal List<string> getFiltresPossibles() {
            return new List<string>(lectPDF.LireDonneesUnique("f").Keys);
        }

        internal void AddRechercheCombo(string cle) {
            listesCombo.Add(cle, new List<string>());
        }

        internal void AddFiltre(string cle, string forme) {
            listeFiltres.Add(cle, forme);
        }

        internal void AddAffich(string cle) {
            listeAffich.Add(cle);
        }

        internal void StartProcessing() {
            lectPDF.RechercheGlobale(new List<string>(listeFiltres.Keys), listeAffich, new List<string>(listesCombo.Keys),
                ref listesCombo, ref listeFichier);

            dXml.AddData(listeFichier);
            dXml.Sauvegarder();

            fXml.ModifierListeAffichage(listeAffich);
            fXml.ModifierListeFiltres(listeFiltres, listesCombo);
            fXml.Sauvegarder();
        }
    }
}