using projet_lnSearch.donnees;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_lnSearch.application {
    /// <summary>
    /// Classe cerveau de l'application, stocke les données et envoie les requètes
    /// vers les autres classes.
    /// </summary>
    public class Controleur {

        private LecteurPDF lectPDF;

        public Controleur() {
            string creation = ConfigurationManager.AppSettings["modeCeation"];
            Debug.Write((creation==null ? "lol" : creation));
        }

        internal void initFiltres() {
            throw new NotImplementedException();
        }

    }
}
