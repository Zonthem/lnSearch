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
    class RedacteurXML {
        private RedacteurDataXML dXml;

        private RedacteurConfXML fXml;

        private LecteurPDF lectPDF;

        public RedacteurXML() {
            dXml = new RedacteurDataXML();
            fXml = new RedacteurConfXML(new List<string>(), new List<string>());
            lectPDF = new LecteurPDF(true);
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
    }
}
