using System;
using System.Collections;
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
    /// klasa odpowiedzialna za okienko admina, w których są wyświetlane rekordy studentów którzy mają wygenerowany plan
    /// jego głównym zadaniem jest stworzenie możliwości zaakceptowania lub odrzucenia planu zajęć poszczególnych studentów
    /// 
    public partial class AdmWin : Form
    {
        public AdmWin(string login, string password)
        {
            InitializeComponent();
            loginLabel.Text = "Zalogowano administratora: " + login + " " + password;
            label1.Text = "Oczekujące plany";

            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Plan_Zajec WHERE Status LIKE 'Oczekujący'";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();

            int counter = 0;

            while (reader.Read())
            {
                counter++;
                //wyczytuje ile jest wierszy w stworzonej tabeli
            }
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Plan_Zajec WHERE Status LIKE 'Oczekujący'";
            SqlCommand command1 = new SqlCommand(sql, DBconnect);
            SqlDataReader reader1 = command1.ExecuteReader();
            ArrayList uzyteid = new ArrayList();
            if (counter > 0)
            //jesli jest wiecej niz 0 wierszy, zaczyna czytac
            {
                for (int i = 1; i <= counter; i++)
                {
                    reader1.Read();
                    string id_studenta;
                    id_studenta = reader1.GetValue(1).ToString();


                    if (!uzyteid.Contains(id_studenta))
                    {
                        uzyteid.Add(id_studenta);
                        DBconnect = new SqlConnection(connetionString);
                        DBconnect.Open();
                        sql = "Select * from Studenci where id=" + id_studenta;
                        SqlCommand command2 = new SqlCommand(sql, DBconnect);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader2.Read();
                            string name;
                            string surname;
                            name = reader2.GetValue(1).ToString();

                            surname = reader2.GetValue(2).ToString();

                            string status = "oczekujący";
                            tabela1.Rows.Add(name + " " + surname, status, "Zaakceptuj", "Odrzuć", "Podgląd");
                        }
                        reader2.Close();
                        DBconnect.Close();
                    }
                }
            }
            reader.Close();
            DBconnect.Close();
            reader1.Close();
            DBconnect.Close();
        }

        private void tabela1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 4)
            {
                var wartośćKonkretnejKomórki = senderGrid.Rows[e.RowIndex].Cells[0].Value;
                String[] name = wartośćKonkretnejKomórki.ToString().Split(' ');
                DBconnect = new SqlConnection(connetionString);
                DBconnect.Open();
                sql = "select Id from Studenci where Imie ='" + name[0] + "' and Nazwisko ='" + name[1] + "'";
                SqlCommand command6 = new SqlCommand(sql, DBconnect);
                SqlDataReader reader6 = command6.ExecuteReader();
                if (reader6.HasRows)
                {
                    reader6.Read();
                    string id;
                    id = reader6.GetValue(0).ToString();

                    PreviewShedule shedule = new PreviewShedule(id, name[0], name[1]);
                    shedule.Show();
                }
                reader6.Close();
                DBconnect.Close();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 2)
            {
                var wartośćKonkretnejKomórki = senderGrid.Rows[e.RowIndex].Cells[0].Value;
                String[] name = wartośćKonkretnejKomórki.ToString().Split(' ');
                DBconnect = new SqlConnection(connetionString);
                DBconnect.Open();
                sql = "select Id from Studenci where Imie ='" + name[0] + "' and Nazwisko ='" + name[1] + "'";
                SqlCommand command3 = new SqlCommand(sql, DBconnect);
                SqlDataReader reader3 = command3.ExecuteReader();
                if (reader3.HasRows)
                {
                    reader3.Read();
                    string id;
                    id = reader3.GetValue(0).ToString();
                    DBconnect = new SqlConnection(connetionString);
                    DBconnect.Open();
                    sql = "update Plan_Zajec set status = 'zatwierdzony' where Studenci_Id =" + id;
                    SqlCommand command4 = new SqlCommand(sql, DBconnect);
                    SqlDataReader reader4 = command4.ExecuteReader();

                    DBconnect = new SqlConnection(connetionString);
                    DBconnect.Open();
                    sql = "select Zajecia_Id from Plan_Zajec where Studenci_Id=" + id; ;
                    SqlCommand command5 = new SqlCommand(sql, DBconnect);
                    SqlDataReader reader5 = command5.ExecuteReader();
                    if (reader5.HasRows)
                    {
                        for (int i = 0; i <= 3; i++)
                        {
                            reader5.Read();
                            string zajecia_id;
                            zajecia_id = reader5.GetValue(0).ToString();
                            DBconnect = new SqlConnection(connetionString);
                            DBconnect.Open();
                            sql = "select Ilosc_Miejsc from Zajecia where Id=" + zajecia_id;
                            SqlCommand command6 = new SqlCommand(sql, DBconnect);
                            SqlDataReader reader6 = command6.ExecuteReader();
                            if (reader6.HasRows)
                            {
                                int ilo_miejsc;
                                string ilosc_miejsc;
                                reader6.Read();
                                ilosc_miejsc = reader6.GetValue(0).ToString();
                                ilo_miejsc = Convert.ToInt32(ilosc_miejsc);
                                DBconnect = new SqlConnection(connetionString);
                                DBconnect.Open();
                                sql = "update Zajecia set Ilosc_Miejsc =" + (ilo_miejsc - 1) + " where Id=" + zajecia_id;
                                SqlCommand command7 = new SqlCommand(sql, DBconnect);
                                SqlDataReader reader7 = command7.ExecuteReader();
                                reader7.Close();
                                DBconnect.Close();
                            }
                            reader6.Close();
                            DBconnect.Close();
                        }
                    }
                    reader4.Close();
                    DBconnect.Close();
                    reader5.Close();
                    DBconnect.Close();

                    MessageBox.Show("Zaakceptowano pomyślnie");
                    AdmWin next = new AdmWin("Admin", "Admin");
                    next.Show();
                    this.Hide();
                }
                reader3.Close();
                DBconnect.Close();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3)
            {
                var wartośćKonkretnejKomórki = senderGrid.Rows[e.RowIndex].Cells[0].Value;
                String[] name = wartośćKonkretnejKomórki.ToString().Split(' ');
                DBconnect = new SqlConnection(connetionString);
                DBconnect.Open();
                sql = "select Id from Studenci where Imie ='" + name[0] + "' and Nazwisko ='" + name[1] + "'";
                SqlCommand command5 = new SqlCommand(sql, DBconnect);
                SqlDataReader reader5 = command5.ExecuteReader();
                if (reader5.HasRows)
                {
                    reader5.Read();
                    string id;
                    id = reader5.GetValue(0).ToString();
                    DBconnect = new SqlConnection(connetionString);
                    DBconnect.Open();
                    sql = "delete Plan_Zajec where Studenci_Id =" + id;
                    SqlCommand command6 = new SqlCommand(sql, DBconnect);
                    SqlDataReader reader6 = command6.ExecuteReader();
                    MessageBox.Show("Odrzucono pomyślnie");
                    AdmWin next = new AdmWin("Admin", "Admin");
                    next.Show();
                    this.Hide();
                    reader6.Close();
                    DBconnect.Close();
                }
                reader5.Close();
                DBconnect.Close();
            }
        }
    }
}