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
        ///
        /// ustalanie wagi dla każdego nauczyciela oraz zapisanie tych wag
        /// 
        private void saveButton_Click(object sender, EventArgs e)
        {
            string pom;
            int pom2 = 0;
            for (int i = 0; i < count; i++)
            {
                pom = dataGridView1[3, i].Value.ToString();
                if(System.Convert.ToInt32(pom)<1|| System.Convert.ToInt32(pom)>10)
                {
                    MessageBox.Show("Wartości muszą być w zakresie od 1 do 10.");
                    pom2++;
                    break;
                }
                DataKeeper.Teachers[i].Pref = System.Convert.ToInt32(pom);
            }
            if (pom2 == 0)
            {
                this.Close();
            }
        }
    }
}
