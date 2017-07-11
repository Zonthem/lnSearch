﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projet_lnSearch.donnees {
    /// <summary>
    /// Écrit le fichier XML de fitrage
    /// </summary>
    class FiltreXML : FichierXML {
        private XmlDocument filtreXml;

        private int NbFiltresEntres { get; set; }

        public FiltreXML() : base() {

        }

        public bool AddFiltre() {
            return false;
        }
    }
}
