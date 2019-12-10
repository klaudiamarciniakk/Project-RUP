namespace Project_Rup
{
    partial class PrefWin
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentWinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentWinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.SurnameColumn,
            this.PrefColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Imie";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Nazwisko";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // PrefColumn
            // 
            this.PrefColumn.HeaderText = "Waga";
            this.PrefColumn.Name = "PrefColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Project_Rup.Teacher);
            // 
            // studentWinBindingSource
            // 
            this.studentWinBindingSource.DataSource = typeof(Project_Rup.StudentWin);
            // 
            // studentWinBindingSource1
            // 
            this.studentWinBindingSource1.DataSource = typeof(Project_Rup.StudentWin);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(211, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 42);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PrefWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 530);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrefWin";
            this.Text = "PrefWin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentWinBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource studentWinBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrefColumn;
        private System.Windows.Forms.Button saveButton;
    }
}