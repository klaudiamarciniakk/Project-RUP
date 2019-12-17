using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Rup
{
    ///
    /// klasa odpowiedzialna za przechowywanie danych w poszczególnych strukrurach danych
    /// wykorzystuje listy oraz tablice wielowymiarowe
    /// 
    public class DataKeeper
    {
        static List<Subject> subjects = new List<Subject>();
        static List<Teacher> teachers = new List<Teacher>();
        static int[,] plan = new int[2, 6];

        public static List<Teacher> Teachers { get => teachers; set => teachers = value; }
        public static List<Subject> Subjects { get => subjects; set => subjects = value; }
        public static int[,] Plan { get => plan; set => plan = value; }

    }
}
