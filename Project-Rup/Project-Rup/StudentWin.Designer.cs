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
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentWinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(9, 6);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(128, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Zalogowano użytkownika";
            // 
            // prefButton
            // 
            this.prefButton.Location = new System.Drawing.Point(12, 49);
            this.prefButton.Name = "prefButton";
            this.prefButton.Size = new System.Drawing.Size(148, 23);
            this.prefButton.TabIndex = 1;
            this.prefButton.Text = "Nadaj wagi nauczycielom";
            this.prefButton.UseVisualStyleBackColor = true;
            this.prefButton.Click += new System.EventHandler(this.prefButton_Click);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Project_Rup.Teacher);
            // 
            // studentWinBindingSource
            // 
            this.studentWinBindingSource.DataSource = typeof(Project_Rup.StudentWin);
            // 
            // StudentWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 285);
            this.Controls.Add(this.prefButton);
            this.Controls.Add(this.loginLabel);
            this.Name = "StudentWin";
            this.Text = "StudentWin";
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button prefButton;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingSource studentWinBindingSource;
    }
}