using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Rup
{
    public class Subject
    {
        string name,id;
        int[,] grid = new int[2,6];
        public Subject(string sName, string sId)
        {
            Name = sName;
            Id = sId;
            FillGrid();
        }
        private void FillGrid()
        {
            string connetionString, sql = "";
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Zajecia WHERE Id_Przedmiotu LIKE '" + Id + "';";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int day, hour, teacherId;
                while (reader.Read())
                {
                    day = reader.GetInt32(3)-6;
                    hour = reader.GetInt32(4)-1;
                    teacherId = reader.GetInt32(2);
                    if (grid[day, hour] == 0)
                    {
                        grid[day, hour] = teacherId;
                    }
                    else
                    {
                        if(DataKeeper.Teachers.Where(i => i.Id==grid[day,hour]).FirstOrDefault().Pref> DataKeeper.Teachers.Where(i => i.Id == teacherId).FirstOrDefault().Pref)
                        {
                            grid[day, hour] = teacherId;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie znaleźono rekordu.");
            }
            reader.Close();
            DBconnect.Close();
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
    }
}
