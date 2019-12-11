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
    public partial class StudentWin : Form
    {
        public StudentWin(string login, string password, string semester)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dataGridView1.Rows.Add("8.15-9.45","","");
            dataGridView1.Rows.Add("10.00-11.30", "", "");
            dataGridView1.Rows.Add("11.45-13.15", "", "");
            dataGridView1.Rows.Add("13.45-15.15", "", "");
            dataGridView1.Rows.Add("15.30-17.00", "", "");
            dataGridView1.Rows.Add("17.15-18.45", "", "");
            statusLabel.Text = "Status : BRAK";
            loginLabel.Text = "Zalogowano urzytkownika : " +login+" "+password+", semestr : "+semester;

            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "Select DISTINCT prowadzacy.imie, prowadzacy.nazwisko, prowadzacy.Id from prowadzacy,zajecia,Przedmioty where zajecia.Id_Prowadzacego=Prowadzacy.Id and zajecia.Id_Przedmiotu=Przedmioty.Id and Przedmioty.Semestr='"+semester+"' order by Nazwisko";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                string teacherName, teacherSurname;
                int teacherId;
                while (reader.Read())
                {
                    teacherName = reader.GetValue(0).ToString();
                    teacherSurname = reader.GetValue(1).ToString();
                    teacherId = reader.GetInt32(2);
                    DataKeeper.Teachers.Add(new Teacher(teacherName, teacherSurname, teacherId));
                }
            }
            else
            {
                MessageBox.Show("Nie znaleźono rekordu.");
            }
            reader.Close();
            sql = "SELECT * FROM Przedmioty WHERE Semestr LIKE '"+semester+"';";
            command = new SqlCommand(sql, DBconnect);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                string subjectsName, subjectsId;
                while (reader.Read())
                {
                    subjectsName=reader.GetValue(1).ToString();
                    subjectsId=reader.GetValue(0).ToString();
                    DataKeeper.Subjects.Add(new Subject(subjectsName, subjectsId));
                }
            }
            else
            {
                MessageBox.Show("Nie znaleźono rekordu.");
            }
            reader.Close();
            DBconnect.Close();
        }


        private void prefButton_Click(object sender, EventArgs e)
        {
            PrefWin next = new PrefWin(DataKeeper.Teachers);
            next.Show();
        }
    }
}
