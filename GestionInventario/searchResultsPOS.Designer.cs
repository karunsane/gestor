﻿namespace GestionInventario
{
    partial class searchResultsPOS
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
            this.searchResultGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResultGrid
            // 
            this.searchResultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.searchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGrid.Location = new System.Drawing.Point(13, 13);
            this.searchResultGrid.Name = "searchResultGrid";
            this.searchResultGrid.Size = new System.Drawing.Size(775, 425);
            this.searchResultGrid.TabIndex = 0;
            // 
            // searchResultsPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchResultGrid);
            this.Name = "searchResultsPOS";
            this.Text = "Buscar Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchResultGrid;
    }
}