﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_lnSearch.application {

    public class VarUtiles {

        private static string cheminXML = "C:\\Users\\Zonthem\\Documents\\";

        public static string CheminXML {
            get {
                return cheminXML;
            }

            set {
                cheminXML = value;
            }
        }
    }
}