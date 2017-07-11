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
    class RedacteurData {
        private DataXML dXml;

        private FiltreXML fXml;

        private LecteurPDF lectPDF;

        public RedacteurData() {

        }

        public bool SetFiltres() {
            return false;
        }

        public bool SetDatas() {
            return false;
        }
    }
}
