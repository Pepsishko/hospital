﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Laba1_IBEXpert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            FbConnection fbConn = new FbConnection();

            cs.DataSource = "localhost"; // имя компьютера, на котором находится база данных
            cs.UserID = "SYSDBA"; // имя пользователя, который может производить манипуляции с базой
            cs.Password = "masterkey"; // паоль пользователя, который может производить манипуляции с базой
            cs.Database = "C:/Users/Студент/Desktop/Laba3_IBEXpert/BD/TEST.FDB"; // путь к файлу базы данных
            cs.Port = 3050; // порт подключения к базе
            cs.Charset = "win1251"; // кодировка символов
            string ConnString = cs.ToString();

            fbConn.ConnectionString = ConnString;
            fbConn.Open();


            DataTable dt = new DataTable();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand("select * from STUDENT", fbConn);
            cmd.CommandType = CommandType.Text;
            FbDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            fbConn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
