﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNet
{
    class MyDB
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-B7HFOT3I\\SQLEXPRESS05; Initial Catalog=QLNet; Integrated Security=True");
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-B7HFOT3I\\SQLEXPRESS05; Initial Catalog=QLNet; Integrated Security=True");
        //SqlConnection con = new SqlConnection("Server=DESKTOP-MGN3IP8/MSSQLSERVER01;Database=SV");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
