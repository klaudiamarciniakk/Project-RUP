using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Rup
{
    public partial class PreviewShedule : Form
    {
        public PreviewShedule(String id)
        {
            InitializeComponent();
            this.seeSheduleTable.Rows[0].Cells[0].Value ="8:15";
            this.seeSheduleTable.Rows[0].Cells[1].Value = "10:00";
            this.seeSheduleTable.Rows[0].Cells[2].Value = "11:45";
            this.seeSheduleTable.Rows[0].Cells[3].Value = "13:45";
            this.seeSheduleTable.Rows[0].Cells[4].Value = "15:30";
            this.seeSheduleTable.Rows[0].Cells[5].Value = "17:15";
            


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
                for (int i = 0; i <= 4; i++)
                {
                    reader.Read();
                    String id_zajec;

                    id_zajec = reader.GetValue(0).ToString();
                    DBconnect = new SqlConnection(connetionString);
                    DBconnect.Open();
                    sql = "select Id_przedmiotu, Id_dnia, Id_Godziny  from Zajecia where Zajecia_Id =" + id_zajec;
                    SqlCommand command1 = new SqlCommand(sql, DBconnect);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        reader1.Read();
                        String nazwa;
                        String id_przedmiotu;
                        String godzina;
                        String dzien;
                        id_przedmiotu= reader1.GetValue(0).ToString();
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
                           nazwa = reader2.GetValue(0).ToString();
                            if(dzien == "6")
                            {
                                this.seeSheduleTable.Rows[1].Cells[h].Value = nazwa;

                            }
                            if(dzien == "7")
                            {
                                this.seeSheduleTable.Rows[2].Cells[h].Value = nazwa;
                            }
                        }
                        
                    }

                }
        }

    }
        
    }

}
