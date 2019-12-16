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
    public partial class Form1 : Form
    {
        public Form1(string id, string name, string surname)
        {
            InitializeComponent();
            Console.WriteLine(id + " " + name + " " + surname);
            label1.Text = "Plan lekcji: " + name + " " + surname;
            tabela1.Rows.Add("8:15");
            tabela1.Rows.Add("10:00");
            tabela1.Rows.Add("11:45");
            tabela1.Rows.Add("13:45");
            tabela1.Rows.Add("15:30");
            tabela1.Rows.Add("17:15");
            


            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "select Zajecia_Id from Plan_Zajec where Studenci_Id = " + id;
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                for(int i =1; i <= 4; i++)
                {
                    reader.Read();
                    string id_zajec;
                    id_zajec = reader.GetValue(0).ToString();
                    DBconnect = new SqlConnection(connetionString);
                    DBconnect.Open();
                    sql = "select Id_przedmiotu, Id_dnia, Id_Godziny  from Zajecia where Id =" + id_zajec;
                    SqlCommand command1 = new SqlCommand(sql, DBconnect);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        reader1.Read();
                        string id_przedmiotu;
                        string dzien;
                        string godzina;
                        id_przedmiotu = reader1.GetValue(0).ToString();
                        dzien = reader1.GetValue(1).ToString();
                        godzina = reader1.GetValue(2).ToString();
                        int h = Convert.ToInt32(godzina);
                        DBconnect = new SqlConnection(connetionString);
                        DBconnect.Open();
                        sql = "select  Nazwa from Przedmioty where Id =" + id_przedmiotu;
                        SqlCommand command2 = new SqlCommand(sql, DBconnect);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            reader2.Read();
                            string nazwa;
                            nazwa = reader2.GetValue(0).ToString();

                            if(dzien == "6")
                            {
                                tabela1.Rows[h-1].Cells[1].Value = nazwa;
                            }
                            if (dzien == "7")
                            {
                                tabela1.Rows[h-1].Cells[2].Value = nazwa;
                            }
                        }

                    }
                }
            }
        }
    }
}
