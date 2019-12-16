namespace Project_Rup
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabela1 = new System.Windows.Forms.DataGridView();
            this.godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niedziela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan lekcji: ";
            // 
            // tabela1
            // 
            this.tabela1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.godzina,
            this.sobota,
            this.niedziela});
            this.tabela1.Location = new System.Drawing.Point(228, 85);
            this.tabela1.Name = "tabela1";
            this.tabela1.Size = new System.Drawing.Size(341, 331);
            this.tabela1.TabIndex = 1;
            // 
            // godzina
            // 
            this.godzina.HeaderText = "Godzina";
            this.godzina.Name = "godzina";
            this.godzina.ReadOnly = true;
            // 
            // sobota
            // 
            this.sobota.HeaderText = "Sobota";
            this.sobota.Name = "sobota";
            this.sobota.ReadOnly = true;
            // 
            // niedziela
            // 
            this.niedziela.HeaderText = "Niedziela";
            this.niedziela.Name = "niedziela";
            this.niedziela.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabela1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabela1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabela1;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobota;
        private System.Windows.Forms.DataGridViewTextBoxColumn niedziela;
    }
}