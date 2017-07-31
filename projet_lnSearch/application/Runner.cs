
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using projet_lnSearch.fenetres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_lnSearch.application {

    static class Runner {

        private static Controleur c;

        public static BackgroundWorker _bg = new BackgroundWorker();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VarUtiles.Donnees = ConfigurationManager.AppSettings["cheminPdf"] ?? "data\\";
            VarUtiles.Filtres = ConfigurationManager.AppSettings["cheminXml"] ?? "config\\";

            int pdf = PdfReader.TestPdfFile("test.pdf");
            Debug.Write(pdf);

            c = new Controleur();
            _bg.DoWork += c.bg_DoWork;

            Application.Run(new Accueil(c));
        }
    }
}
