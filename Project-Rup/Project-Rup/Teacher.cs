using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Rup
{
    ///
    ///klasa definiująca prowadzącego zajęcia, zawiera pola z jego imieniem, nazwiskie oraz id
    ///
    public class Teacher
    {
        int pref, id;
        string name, surname;

        public int Id { get => id; set => id = value; }
        public int Pref { get => pref; set => pref = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        ///
        ///konstruktor przypisujące prowadzącemu imię, nazwisko oraz id podane w parametrach
        ///
        public Teacher(string tName, string tSurname,int tId)
        {
            Name = tName;
            Surname = tSurname;
            Id = tId;
            Pref = 1;
        }
        ///
        ///konstruktor domyślny przypisujący prowadzącemu domyślne wartości
        ///
        public Teacher()
        {
            Pref = 0;
            Id = 0;
            Name = "";
            Surname = "";
        }
    }
}
