namespace projet_lnSearch.application {

    public class VarUtiles {

        private static string cheminApp = "C:\\Users\\Zonthem\\Documents\\";
        private static string filtres = "config\\";
        private static string donnees = "data\\";
        private static string comboValeurNulle = "[ Aucune valeur ]";

        public static string CheminApp {
            get {
                return cheminApp;
            }

            set {
                cheminApp = value;
            }
        }

        public static string ComboValeurNulle {
            get {
                return comboValeurNulle;
            }

            set {
                comboValeurNulle = value;
            }
        }

        public static string Conf {
            get {
                return filtres;
            }

            set {
                filtres = value;
            }
        }

        public static string Donnees {
            get {
                return donnees;
            }

            set {
                donnees = value;
            }
        }
    }
}
