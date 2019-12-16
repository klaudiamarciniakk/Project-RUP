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
        string Semester = "";
        public StudentWin(string login, string password, string semester)
        {
            Semester = semester;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            comboBox3.SelectedIndex = 0;
            dataGridView1.Rows.Add("8.15-9.45","","");
            dataGridView1.Rows.Add("10.00-11.30", "", "");
            dataGridView1.Rows.Add("11.45-13.15", "", "");
            dataGridView1.Rows.Add("13.45-15.15", "", "");
            dataGridView1.Rows.Add("15.30-17.00", "", "");
            dataGridView1.Rows.Add("17.15-18.45", "", "");
            statusLabel.Text = "Status : BRAK";
            loginLabel.Text = "Zalogowano urzytkownika : " +login+" "+password+" , semestr : "+semester;

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
            DBconnect.Close();
        }


        private void prefButton_Click(object sender, EventArgs e)
        {
            PrefWin next = new PrefWin(DataKeeper.Teachers);
            next.Show();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Przedmioty WHERE Semestr LIKE '" + Semester + "';";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                string subjectsName, subjectsId;
                while (reader.Read())
                {
                    subjectsName = reader.GetValue(1).ToString();
                    subjectsId = reader.GetValue(0).ToString();
                    DataKeeper.Subjects.Add(new Subject(subjectsName, subjectsId));
                }
            }
            else
            {
                MessageBox.Show("Nie znaleźono rekordu.");
            }
            reader.Close();
            DBconnect.Close();
            Generator generator = new Generator(comboBox1.SelectedIndex,comboBox2.SelectedIndex,comboBox3.SelectedIndex);
            dataGridView1[1, 0].Value = DataKeeper.Plan[0, 0];
            dataGridView1[1, 1].Value = DataKeeper.Plan[0, 1];
            dataGridView1[1, 2].Value = DataKeeper.Plan[0, 2];
            dataGridView1[1, 3].Value = DataKeeper.Plan[0, 3];
            dataGridView1[1, 4].Value = DataKeeper.Plan[0, 4];
            dataGridView1[1, 5].Value = DataKeeper.Plan[0, 5];
            dataGridView1[2, 0].Value = DataKeeper.Plan[1, 0];
            dataGridView1[2, 1].Value = DataKeeper.Plan[1, 1];
            dataGridView1[2, 2].Value = DataKeeper.Plan[1, 2];
            dataGridView1[2, 3].Value = DataKeeper.Plan[1, 3];
            dataGridView1[2, 4].Value = DataKeeper.Plan[1, 4];
            dataGridView1[2, 5].Value = DataKeeper.Plan[1, 5];

            for (int i = 0; i <= 1; i++)
            {
                for(int j = 0; j <= 5; j++)
                {
                    string id_nauczyciela;
                    id_nauczyciela = DataKeeper.Plan[i, j].ToString();
                    DBconnect = new SqlConnection(connetionString);
                    DBconnect.Open();
                    sql = "SELECT Id_Przedmiotu FROM Zajecia WHERE Id_Prowadzacego='" + id_nauczyciela + "'";
                    SqlCommand command1 = new SqlCommand(sql, DBconnect);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        reader1.Read();
                        string id_przedmiotu;
                        id_przedmiotu = reader1.GetValue(0).ToString();
                        DBconnect = new SqlConnection(connetionString);
                        DBconnect.Open();
                        sql = "SELECT Nazwa FROM Przedmioty WHERE Id='" + id_przedmiotu + "'";
                        SqlCommand command2 = new SqlCommand(sql, DBconnect);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            reader2.Read();
                            string nazwa;
                            nazwa = reader2.GetValue(0).ToString();
                            dataGridView1[i + 1, j].Value = nazwa;
                            
                        }
                    }
                }
            }

            saveButton.Visible=true;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] pom = loginLabel.Text.Split(' ');
            string imie;
            string nazwisko;
            imie = pom[3];
            nazwisko = pom[4];


            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT Id FROM Studenci WHERE Imie ='" + imie + "' and Nazwisko='" + nazwisko + "'";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                string id_studenta;
                id_studenta = reader.GetValue(0).ToString();
            

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    string id_przedmiotu;
                    id_przedmiotu = DataKeeper.Plan[i, j].ToString();
                    Console.WriteLine(DataKeeper.Plan[i, j]);
                    if (id_przedmiotu != "0")
                    {
                        DBconnect = new SqlConnection(connetionString);
                        DBconnect.Open();
                        sql = "SELECT Id FROM Zajecia WHERE Id_Przedmiotu ='" + id_przedmiotu + "';";
                        SqlCommand command1 = new SqlCommand(sql, DBconnect);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            reader1.Read();
                            string id_zajec;
                            id_zajec = reader1.GetValue(0).ToString();

                            DBconnect = new SqlConnection(connetionString);
                            DBconnect.Open();
                            sql = "insert into Plan_Zajec (Zajecia_Id, Studenci_Id, Status) values (" + id_zajec + ", " + id_studenta + ", 'oczekujący')";
                            SqlCommand command2 = new SqlCommand(sql, DBconnect);
                            SqlDataReader reader2 = command2.ExecuteReader();
                                
                            }
                    }
                }
            }
                MessageBox.Show("Zapisano plan");
                                statusLabel.Text = " Status: Oczekujący na zatwierdzenie";
                                saveButton.Visible = false;
                                generateButton.Visible = false;
        }
           
        }

        
    }
}
