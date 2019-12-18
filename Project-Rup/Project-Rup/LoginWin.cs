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
    ///
    /// klasa odpowiada za logowanie do systemu, login i hasło jest pobierane z bazy danych
    /// 
    public partial class LoginWin : Form
    {
        private string login = "", password = "";
        public LoginWin()
        {
            InitializeComponent();
        }
        ///
        /// potwierdzenie logowania również poprzez naciśnięcie klawisza Enter w drugim polu tekstowym
        /// 
        private void loginTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connButton.PerformClick();
            }
        }

        /// 
        /// przycisk połączenia
        /// 

        private void connButton_Click(object sender, EventArgs e)
        {
            string connetionString, sql = "";
            login = loginTextBox1.Text;
            password = loginTextBox2.Text;
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Studenci WHERE Imie LIKE '" + login + "' AND Nazwisko LIKE '" + password + "';";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string semester;
                semester = reader.GetValue(3).ToString();
                if (semester.CompareTo("0") != 0)
                {
                    StudentWin next = new StudentWin(login, password, semester);
                    next.Show();
                    this.Hide();
                }
                else
                {
                    AdmWin next = new AdmWin(login, password);
                    next.Show();
                    this.Hide();
                }
               
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
