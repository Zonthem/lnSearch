using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using projet_lnSearch.application;
using System.Diagnostics;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Classe mere des classes XML
    /// </summary>
    class FichierXML {

        protected XmlDocument document;

        public FichierXML(string nom, bool creation = false) {
            document = new XmlDocument();
            try {
                document.Load(VarUtiles.CheminApp + nom);
            } catch (Exception ex) {
                Debug.Write(ex.Message + Environment.NewLine);
                document = null;
            }
        }
        
        public bool SaveXML() {
            return false;
        }
    }
}
