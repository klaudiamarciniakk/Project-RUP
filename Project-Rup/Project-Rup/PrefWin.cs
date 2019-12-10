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
    public partial class PrefWin : Form
    {
        int count=0;

        public PrefWin(List<Teacher> teachers)
        {
            InitializeComponent();
            foreach(Teacher teacher in teachers)
            {
                dataGridView1.Rows.Add(teacher.Id,teacher.Name, teacher.Surname, teacher.Pref);
                count++;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string pom;
            for (int i = 0; i < count; i++)
            {
                pom = dataGridView1[3, i].Value.ToString();
                DataKeeper.Teachers[i].Pref = System.Convert.ToInt32(pom);
            }
            this.Close();
        }
    }
}
