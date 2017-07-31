using System.Windows.Forms;

namespace projet_lnSearch.metier {

    class DateSelecteur : DateTimePicker {

        public ComboBox Operation { get; set; }

        public DateTimePicker Extremite { get; set; }

        public DateSelecteur() : base() {
            Operation = null;
            Extremite = null;
        }
    }
}
