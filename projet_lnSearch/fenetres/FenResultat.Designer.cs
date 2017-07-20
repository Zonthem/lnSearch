namespace projet_lnSearch
{
    partial class FenResultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenResultat));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Pdf = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Go = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPage = new System.Windows.Forms.Label();
            this.boutSuiv = new System.Windows.Forms.Button();
            this.boutFastSuiv = new System.Windows.Forms.Button();
            this.boutPrev = new System.Windows.Forms.Button();
            this.boutFastPrev = new System.Windows.Forms.Button();
            this.labelDocTrouv = new System.Windows.Forms.Label();
            this.buttonNvRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeight = 30;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pdf,
            this.FileName,
            this.Go,
            this.Path});
            this.Grid.Location = new System.Drawing.Point(12, 78);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.RowTemplate.Height = 27;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(760, 572);
            this.Grid.TabIndex = 0;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Pdf
            // 
            this.Pdf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pdf.FillWeight = 27.894F;
            this.Pdf.HeaderText = "PDF";
            this.Pdf.Name = "Pdf";
            this.Pdf.ReadOnly = true;
            this.Pdf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pdf.Width = 50;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.FillWeight = 172.106F;
            this.FileName.HeaderText = "Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Go
            // 
            this.Go.HeaderText = "Ouvrir";
            this.Go.Name = "Go";
            this.Go.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "Chemin du pdf";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            // 
            // labelPage
            // 
            this.labelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.Location = new System.Drawing.Point(596, 47);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(81, 14);
            this.labelPage.TabIndex = 1;
            this.labelPage.Text = "Page x de x";
            // 
            // boutSuiv
            // 
            this.boutSuiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutSuiv.Location = new System.Drawing.Point(698, 43);
            this.boutSuiv.Name = "boutSuiv";
            this.boutSuiv.Size = new System.Drawing.Size(30, 23);
            this.boutSuiv.TabIndex = 2;
            this.boutSuiv.Text = ">";
            this.boutSuiv.UseVisualStyleBackColor = true;
            this.boutSuiv.Click += new System.EventHandler(this.boutSuiv_Click);
            // 
            // boutFastSuiv
            // 
            this.boutFastSuiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutFastSuiv.Location = new System.Drawing.Point(734, 43);
            this.boutFastSuiv.Name = "boutFastSuiv";
            this.boutFastSuiv.Size = new System.Drawing.Size(30, 23);
            this.boutFastSuiv.TabIndex = 3;
            this.boutFastSuiv.Text = ">>";
            this.boutFastSuiv.UseVisualStyleBackColor = true;
            this.boutFastSuiv.Click += new System.EventHandler(this.boutFastSuiv_Click);
            // 
            // boutPrev
            // 
            this.boutPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutPrev.Location = new System.Drawing.Point(542, 43);
            this.boutPrev.Name = "boutPrev";
            this.boutPrev.Size = new System.Drawing.Size(30, 23);
            this.boutPrev.TabIndex = 5;
            this.boutPrev.Text = "<";
            this.boutPrev.UseVisualStyleBackColor = true;
            this.boutPrev.Click += new System.EventHandler(this.boutPrev_Click);
            // 
            // boutFastPrev
            // 
            this.boutFastPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutFastPrev.Location = new System.Drawing.Point(506, 43);
            this.boutFastPrev.Name = "boutFastPrev";
            this.boutFastPrev.Size = new System.Drawing.Size(30, 23);
            this.boutFastPrev.TabIndex = 4;
            this.boutFastPrev.Text = "<<";
            this.boutFastPrev.UseVisualStyleBackColor = true;
            this.boutFastPrev.Click += new System.EventHandler(this.boutFastPrev_Click);
            // 
            // labelDocTrouv
            // 
            this.labelDocTrouv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDocTrouv.AutoSize = true;
            this.labelDocTrouv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocTrouv.Location = new System.Drawing.Point(12, 47);
            this.labelDocTrouv.Name = "labelDocTrouv";
            this.labelDocTrouv.Size = new System.Drawing.Size(140, 14);
            this.labelDocTrouv.TabIndex = 6;
            this.labelDocTrouv.Text = "x Documents trouvés";
            // 
            // buttonNvRecherche
            // 
            this.buttonNvRecherche.Location = new System.Drawing.Point(12, 12);
            this.buttonNvRecherche.Name = "buttonNvRecherche";
            this.buttonNvRecherche.Size = new System.Drawing.Size(135, 23);
            this.buttonNvRecherche.TabIndex = 7;
            this.buttonNvRecherche.Text = "Nouvelle recherche";
            this.buttonNvRecherche.UseVisualStyleBackColor = true;
            this.buttonNvRecherche.Click += new System.EventHandler(this.buttonNvRecherche_Click);
            // 
            // FenResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.buttonNvRecherche);
            this.Controls.Add(this.labelDocTrouv);
            this.Controls.Add(this.boutPrev);
            this.Controls.Add(this.boutFastPrev);
            this.Controls.Add(this.boutFastSuiv);
            this.Controls.Add(this.boutSuiv);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 701);
            this.Name = "FenResultat";
            this.Text = "Resultat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewImageColumn Pdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewButtonColumn Go;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button boutSuiv;
        private System.Windows.Forms.Button boutFastSuiv;
        private System.Windows.Forms.Button boutPrev;
        private System.Windows.Forms.Button boutFastPrev;
        private System.Windows.Forms.Label labelDocTrouv;
        private System.Windows.Forms.Button buttonNvRecherche;
    }
}