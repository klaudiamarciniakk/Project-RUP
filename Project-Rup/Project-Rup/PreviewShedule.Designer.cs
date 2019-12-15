namespace Project_Rup
{
    partial class PreviewShedule
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
            this.seeSheduleTable = new System.Windows.Forms.DataGridView();
            this.godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niedziela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seeSheduleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // seeSheduleTable
            // 
            this.seeSheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seeSheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.godzina,
            this.sobota,
            this.niedziela});
            this.seeSheduleTable.Location = new System.Drawing.Point(159, 108);
            this.seeSheduleTable.Name = "seeSheduleTable";
            this.seeSheduleTable.RowHeadersWidth = 51;
            this.seeSheduleTable.RowTemplate.Height = 24;
            this.seeSheduleTable.Size = new System.Drawing.Size(478, 242);
            this.seeSheduleTable.TabIndex = 0;
            // 
            // godzina
            // 
            this.godzina.HeaderText = "Godzina";
            this.godzina.MinimumWidth = 6;
            this.godzina.Name = "godzina";
            this.godzina.ReadOnly = true;
            this.godzina.Width = 125;
            // 
            // sobota
            // 
            this.sobota.HeaderText = "Sobota";
            this.sobota.MinimumWidth = 6;
            this.sobota.Name = "sobota";
            this.sobota.ReadOnly = true;
            this.sobota.Width = 125;
            // 
            // niedziela
            // 
            this.niedziela.HeaderText = "Niedziela";
            this.niedziela.MinimumWidth = 6;
            this.niedziela.Name = "niedziela";
            this.niedziela.ReadOnly = true;
            this.niedziela.Width = 125;
            // 
            // PreviewShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seeSheduleTable);
            this.Name = "PreviewShedule";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.seeSheduleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seeSheduleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobota;
        private System.Windows.Forms.DataGridViewTextBoxColumn niedziela;
    }
}