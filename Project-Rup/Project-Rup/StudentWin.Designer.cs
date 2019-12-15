namespace Project_Rup
{
    partial class StudentWin
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.prefButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLabel = new System.Windows.Forms.Label();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentWinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(281, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Zalogowano użytkownika : _____________ , semestr : __";
            // 
            // prefButton
            // 
            this.prefButton.Location = new System.Drawing.Point(12, 44);
            this.prefButton.Name = "prefButton";
            this.prefButton.Size = new System.Drawing.Size(148, 28);
            this.prefButton.TabIndex = 1;
            this.prefButton.Text = "Nadaj wagi nauczycielom";
            this.prefButton.UseVisualStyleBackColor = true;
            this.prefButton.Click += new System.EventHandler(this.prefButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Brak ograniczeń",
            "od godziny 10.00",
            "od godziny 11.45",
            "od godziny 13.45",
            "od godziny 15.30",
            "od godziny 17.15"});
            this.comboBox1.Location = new System.Drawing.Point(12, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "do godziny 9.45",
            "do godziny 11.30",
            "do godziny 13.15",
            "do godziny 15.15",
            "do godziny 17.00",
            "Brak ograniczeń"});
            this.comboBox2.Location = new System.Drawing.Point(12, 213);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nadaj ograniczenia z dołu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nadaj ograniczenia z góry:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Brak ograniczeń",
            "maksymalnie 3h okienko",
            "maksymalnie 2h okienko",
            "maksymalnie 1h okienko",
            "bez okienek"});
            this.comboBox3.Location = new System.Drawing.Point(12, 309);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nadaj zakres okienek:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(338, 35);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(105, 47);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Wygeneruj";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hourColumn,
            this.saturdayColumn,
            this.sundayColumn});
            this.dataGridView1.Location = new System.Drawing.Point(223, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 210);
            this.dataGridView1.TabIndex = 9;
            // 
            // hourColumn
            // 
            this.hourColumn.HeaderText = "Godziny";
            this.hourColumn.Name = "hourColumn";
            this.hourColumn.ReadOnly = true;
            // 
            // saturdayColumn
            // 
            this.saturdayColumn.HeaderText = "Sobota";
            this.saturdayColumn.Name = "saturdayColumn";
            this.saturdayColumn.ReadOnly = true;
            // 
            // sundayColumn
            // 
            this.sundayColumn.HeaderText = "Niedziela";
            this.sundayColumn.Name = "sundayColumn";
            this.sundayColumn.ReadOnly = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(467, 336);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Status : _________";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Project_Rup.Teacher);
            // 
            // studentWinBindingSource
            // 
            this.studentWinBindingSource.DataSource = typeof(Project_Rup.StudentWin);
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataSource = typeof(Project_Rup.Teacher);
            // 
            // teacherBindingSource2
            // 
            this.teacherBindingSource2.DataSource = typeof(Project_Rup.Teacher);
            // 
            // StudentWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 384);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.prefButton);
            this.Controls.Add(this.loginLabel);
            this.Name = "StudentWin";
            this.Text = "Generator-Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button prefButton;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource studentWinBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private System.Windows.Forms.BindingSource teacherBindingSource2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayColumn;
        private System.Windows.Forms.Label statusLabel;
    }
}