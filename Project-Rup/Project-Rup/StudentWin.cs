using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Rup
{
    public partial class StudentWin : Form
    {
        public StudentWin(string login, string password, object semester)
        {
            InitializeComponent();
            loginLabel.Text = "Zalogowano urzytkownika: " +login+" "+password+", semestr: "+semester.ToString();
        }
    }
}
