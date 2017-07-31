using projet_lnSearch.application;
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

        public RedacteurDataXML() : base(VarUtiles.Conf + "data.xml") {
        }

        public bool AddFichier() {
            return false;
        }
    }
}
