namespace Project_Rup
{
    partial class AdmWin
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabela1 = new System.Windows.Forms.DataGridView();
            this.idStudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 10);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(93, 17);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Zalogowano :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tabela1
            // 
            this.tabela1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentColumn,
            this.sheduleStatus,
            this.accept,
            this.reject});
            this.tabela1.Location = new System.Drawing.Point(41, 112);
            this.tabela1.Margin = new System.Windows.Forms.Padding(4);
            this.tabela1.Name = "tabela1";
            this.tabela1.RowHeadersWidth = 51;
            this.tabela1.Size = new System.Drawing.Size(787, 288);
            this.tabela1.TabIndex = 2;
            this.tabela1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela1_CellContentClick);
            // 
            // idStudentColumn
            // 
            this.idStudentColumn.HeaderText = "Imię i nazwisko";
            this.idStudentColumn.MinimumWidth = 6;
            this.idStudentColumn.Name = "idStudentColumn";
            this.idStudentColumn.ReadOnly = true;
            this.idStudentColumn.Width = 125;
            // 
            // sheduleStatus
            // 
            this.sheduleStatus.HeaderText = "Status planu";
            this.sheduleStatus.MinimumWidth = 6;
            this.sheduleStatus.Name = "sheduleStatus";
            this.sheduleStatus.Width = 125;
            // 
            // accept
            // 
            this.accept.HeaderText = "Akceptacja";
            this.accept.MinimumWidth = 6;
            this.accept.Name = "accept";
            this.accept.Text = "Zaakceptuj";
            this.accept.Width = 125;
            // 
            // reject
            // 
            this.reject.HeaderText = "Odrzucenie";
            this.reject.MinimumWidth = 6;
            this.reject.Name = "reject";
            this.reject.Text = "Odrzuć";
            this.reject.Width = 125;
            // 
            // AdmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.tabela1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdmWin";
            this.Text = "AdmWin";
            
            ((System.ComponentModel.ISupportInitialize)(this.tabela1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabela1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheduleStatus;
        private System.Windows.Forms.DataGridViewButtonColumn accept;
        private System.Windows.Forms.DataGridViewButtonColumn reject;
    }
}