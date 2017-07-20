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

        int Page { get; set; }

        int MaxPage { get; set; }

        public FenResultat(Resultat dataPourAfficher)
        {
            data = dataPourAfficher;
            InitializeComponent();

            InitPages();
            if (data.Count == 1) {
                labelDocTrouv.Text = "1 Document trouvé";
                this.Text = "LnSearch - Resultat : 1 document";
            } else {
                labelDocTrouv.Text = data.Count + " Documents trouvés";
                this.Text = "LnSearch - Resultat : " + data.Count + " documents";
            }
            InitGrid();

        }

        private void InitGrid() {
            int i = 0;
            Fichier fic;

            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            Grid.EnableHeadersVisualStyles = false;
            ((DataGridViewImageColumn)Grid.Columns["PDF"]).DefaultCellStyle.NullValue = null;

            data.SetPage(Page);

            Grid.Rows.Clear();

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

        private void InitPages() {
            MaxPage = (data.Count / 20) + 1;
            Page = 1;
            DisplayPage();
        }

        private void DisplayPage() {
            labelPage.Text = "Page " + Page + " / " + MaxPage;
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

        private void boutFastPrev_Click(object sender, EventArgs e) {
            Page = 1;
            InitGrid();
            DisplayPage();
        }

        private void boutPrev_Click(object sender, EventArgs e) {
            if (Page > 1) {
                Page--;
                InitGrid();
                DisplayPage();
            }
        }

        private void boutSuiv_Click(object sender, EventArgs e) {
            if (Page < MaxPage) {
                Page++;
                InitGrid();
                DisplayPage();
            }
        }

        private void boutFastSuiv_Click(object sender, EventArgs e) {
            Page = MaxPage;
            InitGrid();
            DisplayPage();
        }

        private void buttonNvRecherche_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
