using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Rup
{
    public partial class LoginWin : Form
    {
        public LoginWin()
        {
            InitializeComponent();
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            string connetionString, login = "", password = "", sql = "";
            login = loginTextBox1.Text;
            password = loginTextBox2.Text;
            SqlConnection DBconnect;
            //connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            connetionString = @"Data Source=DESKTOP-07NQD3C\SQLEXPRESS;Initial Catalog=Projekty;User ID=zjaro00x3db;Password=Z66ttfccj00x3!";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Pracownicy WHERE nazwisko LIKE '" + login + "' AND stanowisko LIKE '" + password + "';";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                StudentWin next = new StudentWin();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie znaleźono rekordu.");
            }
            reader.Close();
            DBconnect.Close();
        }
    }
}
