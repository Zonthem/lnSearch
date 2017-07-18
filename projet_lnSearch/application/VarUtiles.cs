namespace projet_lnSearch.application {

    public class VarUtiles {

        private static string cheminApp = "C:\\Users\\Zonthem\\Documents\\";
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
    }
}
