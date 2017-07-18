using projet_lnSearch.application;
using projet_lnSearch.metier;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace projet_lnSearch {
    public partial class FenResultat : Form
    {
        Resultat data;

        public FenResultat(Resultat dataPourAfficher)
        {
            data = dataPourAfficher;
            InitializeComponent();

            InitGrid();
        }

        private void InitGrid() {
            int i = 0;
            Fichier fic;

            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            Grid.EnableHeadersVisualStyles = false;

            Grid.Rows.Add(20 - Grid.Rows.Count);

            do {
                fic = data.Get();

                Grid.Rows[i].Cells[0].Value = Properties.Resources.pdfTr;
                Grid.Rows[i].Cells[1].Value = fic.Get("nom");
                Grid.Rows[i].Cells[Grid.Rows[i].Cells.Count - 2].Value = "Ouvrir PDF";
                Grid.Rows[i].Cells[Grid.Rows[i].Cells.Count - 1].Value = fic.Get("path");

                i++;
            } while (i < 20 && data.Next());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                try {
                    Process.Start(VarUtiles.CheminApp +  Grid.Rows[e.RowIndex].Cells["path"].Value.ToString());
                } catch (Exception) {
                    MessageBox.Show("Impossible d'ouvrir ce fichier");
                }
            }
            
        }
    }
}
