﻿using System;
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
    public partial class LoginWin : Form
    {
        private string login = "", password = "";
        public LoginWin()
        {
            InitializeComponent();
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            string connetionString, sql = "";
            login = loginTextBox1.Text;
            password = loginTextBox2.Text;
            SqlConnection DBconnect;
            connetionString = @"Data Source=mssql-2017.labs.wmi.amu.edu.pl;Initial Catalog=s434903_inzopr2019z;User ID=s444513;Password=Gxrbqfvw7L";
            DBconnect = new SqlConnection(connetionString);
            DBconnect.Open();
            sql = "SELECT * FROM Studenci WHERE Imie LIKE '" + login + "' AND Nazwisko LIKE '" + password + "';";
            SqlCommand command = new SqlCommand(sql, DBconnect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                StudentWin next = new StudentWin(login,password,reader.GetValue(3));
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie znaleźono rekordu.");
            }
            reader.Close();
            DBconnect.Close();
        }
    }
}