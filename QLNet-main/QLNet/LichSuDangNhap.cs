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
    public partial class LichSuDangNhap : Form
    {
        MyDB mydb = new MyDB();
        string user;
        public LichSuDangNhap()
        {
            InitializeComponent();
        }

        public void Table_Load()
        {
            dataGridView_History.ReadOnly = true;
            dataGridView_History.RowTemplate.Height = 40;
            dataGridView_History.DataSource = getHistory();
            dataGridView_History.Columns["logId"].HeaderText = "Mã số đăng nhập";
            dataGridView_History.Columns["userId"].HeaderText = "Tài khoản ";
            dataGridView_History.Columns["comId"].HeaderText = "Máy tính";
            dataGridView_History.Columns["logStart"].HeaderText = "Thời gian bắt đầu";
            dataGridView_History.Columns["logEnd"].HeaderText = "Thời gian kết thúc";
        }
        public DataTable getHistory()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM userHistory (@us)", mydb.getConnection);
            command.Parameters.Add("@us", SqlDbType.NVarChar).Value = user;
            DataTable table = fillTable(command);
            return table;
        }
        public DataTable getUser()
        {
            SqlCommand command = new SqlCommand("SELECT userUsername FROM users where userRole ='kh' ", mydb.getConnection);
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
        
        private void button_Tim_Click(object sender, EventArgs e)
        {
            user = textBox_UserName.Text;
            Table_Load();
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LichSuDangNhap_Load(object sender, EventArgs e)
        {
            dataGridView_user.ReadOnly = true;
            dataGridView_user.RowTemplate.Height = 40;
            dataGridView_user.DataSource = getUser();
        }

        private void dataGridView_user_Click(object sender, EventArgs e)
        {
            textBox_UserName.Text = dataGridView_user.CurrentRow.Cells["userUsername"].Value.ToString();
        }
    }
}
