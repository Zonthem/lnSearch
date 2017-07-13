using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Parcours les fichiers XML bases pour en sortir les informations utiles
    /// </summary>
    class LecteurData : FichierXML {

        public LecteurData() : base("data.xml") {

        }
    }
}
