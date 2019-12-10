using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Rup
{
    public class DataKeeper
    {
        static List<Subject> subjects = new List<Subject>();
        static List<Teacher> teachers = new List<Teacher>();

        public static List<Teacher> Teachers { get => teachers; set => teachers = value; }
        public static List<Subject> Subjects { get => subjects; set => subjects = value; }
    }
}
