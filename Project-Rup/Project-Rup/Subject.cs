using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Rup
{
    ///
    ///klasa przedmiot mająca na celu wypełnienie siatki godzin danego przedmiotu
    ///
    public class Subject
    {
        string name,id;
        int[,] grid = new int[2,6];
        ///
        ///konstruktor poprzez który wybierany jest dany przedmiot
        ///
        public Subject(string sName, string sId)
        {
            Name = sName;
            Id = sId;
            FillGrid();
        }
        ///
        ///metoda łącząca się z bazą danych
        ///zaczytuje do tablicy pomocniczej nauczycieli prowadzących dany przedmiot
        ///wypełnia siatkę godzin na dany przedmiot
        ///
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
                int day, hour, teacherId,space;
                while (reader.Read())
                {
                    day = reader.GetInt32(3)-6;
                    hour = reader.GetInt32(4)-1;
                    teacherId = reader.GetInt32(2);
                    space = reader.GetInt32(5);
                    if (space > 0)
                    {
                        if (Grid[day, hour] == 0)
                        {
                            Grid[day, hour] = teacherId;
                        }
                        else
                        {
                            if (DataKeeper.Teachers.Where(i => i.Id == Grid[day, hour]).FirstOrDefault().Pref > DataKeeper.Teachers.Where(i => i.Id == teacherId).FirstOrDefault().Pref)
                            {
                                Grid[day, hour] = teacherId;
                            }
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
        public int[,] Grid { get => grid; set => grid = value; }
    }
}
