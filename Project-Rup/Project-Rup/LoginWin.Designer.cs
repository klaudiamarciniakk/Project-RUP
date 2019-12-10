namespace Project_Rup
{
    partial class LoginWin
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.loginTextBox2 = new System.Windows.Forms.TextBox();
            this.connButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko :";
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.Location = new System.Drawing.Point(154, 88);
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox1.TabIndex = 2;
            // 
            // loginTextBox2
            // 
            this.loginTextBox2.Location = new System.Drawing.Point(154, 132);
            this.loginTextBox2.Name = "loginTextBox2";
            this.loginTextBox2.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox2.TabIndex = 3;
            this.loginTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox2_KeyDown);
            // 
            // connButton
            // 
            this.connButton.Location = new System.Drawing.Point(133, 201);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(75, 23);
            this.connButton.TabIndex = 4;
            this.connButton.Text = "Połącz";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // LoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 279);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.loginTextBox2);
            this.Controls.Add(this.loginTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginWin";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTextBox1;
        private System.Windows.Forms.TextBox loginTextBox2;
        private System.Windows.Forms.Button connButton;
    }
}

