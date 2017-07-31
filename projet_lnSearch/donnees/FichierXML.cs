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

        protected string cheminDoc;

        public FichierXML(string nom, bool creation = false) {
            document = new XmlDocument();
            cheminDoc = VarUtiles.CheminApp + nom;
            try {
                if (!creation) {
                    document.Load(cheminDoc); 
                } else {
                    XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = document.DocumentElement;
                    document.InsertBefore(xmlDeclaration, root);

                    document.Save(cheminDoc);
                }
            } catch (Exception ex) {
                Debug.Write(ex.Message + Environment.NewLine);
                document = null;
            }
        }
        
        public bool Sauvegarder() {
            try {
                document.Save(cheminDoc);
                return true;
            } catch (Exception ex) {
                Debug.Write(ex.Message + Environment.NewLine);
                return false;
            }
        }
    }
}
