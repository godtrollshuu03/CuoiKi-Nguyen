using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNet
{
    public partial class NapTienWindow : Form
    {
        MyDB mydb = new MyDB();
        string username;
        int sotien;
        public NapTienWindow()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NapTienWindow_Load(object sender, EventArgs e)
        {
            Table_Load();
        }
        public void Table_Load()
        {
            dataGridView_Users.ReadOnly = true;
            dataGridView_Users.RowTemplate.Height = 40;
            dataGridView_Users.DataSource = getUser();
            dataGridView_Users.Columns["userUsername"].HeaderText = "Ten ";
            dataGridView_Users.Columns["userName"].HeaderText = "Tai khoan";
            dataGridView_Users.Columns["accountBalance"].HeaderText = "So tien";
        }
        public DataTable getUser()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM chiTietSoDu", mydb.getConnection);
            DataTable table = fillTable(command);
            return table;
        }
        public DataTable fillTable(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; 
        }


        private void dataGridView_Users_Click(object sender, EventArgs e)
        {
            username = dataGridView_Users.CurrentRow.Cells["userUsername"].Value.ToString();
        }

        private void button_Nap_Click(object sender, EventArgs e)
        {
            sotien = Convert.ToInt32(textBox_Tien.Text.ToString());
            SqlCommand command = new SqlCommand("EXEC addMoneyToCustomer @username, @sotien", mydb.getConnection);
            command.Parameters.Add("@sotien", SqlDbType.Int).Value = sotien;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            Table_Load();
        }
    }
}