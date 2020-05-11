﻿namespace BacklogKiller
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSubstitutions = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAnalyze = new System.Windows.Forms.ToolStripButton();
            this.txtProjectDirectoryRoot = new System.Windows.Forms.TextBox();
            this.btnOpenDirectoryDialog = new System.Windows.Forms.Button();
            this.lblRootDirectory = new System.Windows.Forms.Label();
            this.txtFilters = new System.Windows.Forms.TextBox();
            this.lblFilters = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSubstitutions = new System.Windows.Forms.TabPage();
            this.tabAfterSubstitutions = new System.Windows.Forms.TabPage();
            this.dgvAfterSubstitutions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubstitutions)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSubstitutions.SuspendLayout();
            this.tabAfterSubstitutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfterSubstitutions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubstitutions
            // 
            this.dgvSubstitutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubstitutions.Location = new System.Drawing.Point(6, 9);
            this.dgvSubstitutions.Name = "dgvSubstitutions";
            this.dgvSubstitutions.Size = new System.Drawing.Size(915, 311);
            this.dgvSubstitutions.TabIndex = 3;
            this.dgvSubstitutions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubstitutions_CellEndEdit);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAnalyze});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAnalyze
            // 
            this.tsbAnalyze.Image = global::BacklogKiller.Properties.Resources.png_play_32_32;
            this.tsbAnalyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnalyze.Name = "tsbAnalyze";
            this.tsbAnalyze.Size = new System.Drawing.Size(68, 22);
            this.tsbAnalyze.Text = "Analyze";
            this.tsbAnalyze.Click += new System.EventHandler(this.tsbAnalyze_Click);
            // 
            // txtProjectDirectoryRoot
            // 
            this.txtProjectDirectoryRoot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjectDirectoryRoot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtProjectDirectoryRoot.Location = new System.Drawing.Point(12, 48);
            this.txtProjectDirectoryRoot.Name = "txtProjectDirectoryRoot";
            this.txtProjectDirectoryRoot.Size = new System.Drawing.Size(437, 20);
            this.txtProjectDirectoryRoot.TabIndex = 0;
            // 
            // btnOpenDirectoryDialog
            // 
            this.btnOpenDirectoryDialog.Image = global::BacklogKiller.Properties.Resources.png_search_16_16;
            this.btnOpenDirectoryDialog.Location = new System.Drawing.Point(455, 46);
            this.btnOpenDirectoryDialog.Name = "btnOpenDirectoryDialog";
            this.btnOpenDirectoryDialog.Size = new System.Drawing.Size(24, 24);
            this.btnOpenDirectoryDialog.TabIndex = 1;
            this.btnOpenDirectoryDialog.UseVisualStyleBackColor = true;
            this.btnOpenDirectoryDialog.Click += new System.EventHandler(this.btnOpenDirectoryDialog_Click);
            // 
            // lblRootDirectory
            // 
            this.lblRootDirectory.AutoSize = true;
            this.lblRootDirectory.Location = new System.Drawing.Point(9, 32);
            this.lblRootDirectory.Name = "lblRootDirectory";
            this.lblRootDirectory.Size = new System.Drawing.Size(104, 13);
            this.lblRootDirectory.TabIndex = 13;
            this.lblRootDirectory.Text = "Project root directory";
            // 
            // txtFilters
            // 
            this.txtFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilters.Location = new System.Drawing.Point(485, 48);
            this.txtFilters.Name = "txtFilters";
            this.txtFilters.Size = new System.Drawing.Size(462, 20);
            this.txtFilters.TabIndex = 2;
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(482, 32);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(34, 13);
            this.lblFilters.TabIndex = 15;
            this.lblFilters.Text = "Filters";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSubstitutions);
            this.tabControl1.Controls.Add(this.tabAfterSubstitutions);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 352);
            this.tabControl1.TabIndex = 16;
            // 
            // tabSubstitutions
            // 
            this.tabSubstitutions.Controls.Add(this.dgvSubstitutions);
            this.tabSubstitutions.Location = new System.Drawing.Point(4, 22);
            this.tabSubstitutions.Name = "tabSubstitutions";
            this.tabSubstitutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubstitutions.Size = new System.Drawing.Size(927, 326);
            this.tabSubstitutions.TabIndex = 0;
            this.tabSubstitutions.Text = "Substitutions";
            this.tabSubstitutions.UseVisualStyleBackColor = true;
            // 
            // tabAfterSubstitutions
            // 
            this.tabAfterSubstitutions.Controls.Add(this.dgvAfterSubstitutions);
            this.tabAfterSubstitutions.Location = new System.Drawing.Point(4, 22);
            this.tabAfterSubstitutions.Name = "tabAfterSubstitutions";
            this.tabAfterSubstitutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabAfterSubstitutions.Size = new System.Drawing.Size(927, 326);
            this.tabAfterSubstitutions.TabIndex = 1;
            this.tabAfterSubstitutions.Text = "After substitutions";
            this.tabAfterSubstitutions.UseVisualStyleBackColor = true;
            // 
            // dgvAfterSubstitutions
            // 
            this.dgvAfterSubstitutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAfterSubstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfterSubstitutions.Location = new System.Drawing.Point(6, 8);
            this.dgvAfterSubstitutions.Name = "dgvAfterSubstitutions";
            this.dgvAfterSubstitutions.Size = new System.Drawing.Size(915, 311);
            this.dgvAfterSubstitutions.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 440);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.txtFilters);
            this.Controls.Add(this.lblRootDirectory);
            this.Controls.Add(this.btnOpenDirectoryDialog);
            this.Controls.Add(this.txtProjectDirectoryRoot);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backlog Killer - DDS Sistemas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubstitutions)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSubstitutions.ResumeLayout(false);
            this.tabAfterSubstitutions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfterSubstitutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubstitutions;        
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAnalyze;
        private System.Windows.Forms.TextBox txtProjectDirectoryRoot;
        private System.Windows.Forms.Button btnOpenDirectoryDialog;
        private System.Windows.Forms.Label lblRootDirectory;
        private System.Windows.Forms.TextBox txtFilters;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSubstitutions;
        private System.Windows.Forms.TabPage tabAfterSubstitutions;
        private System.Windows.Forms.DataGridView dgvAfterSubstitutions;
    }
}

