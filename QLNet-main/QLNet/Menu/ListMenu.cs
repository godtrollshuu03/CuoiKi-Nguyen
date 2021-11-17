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
    public partial class ListMenu : Form
    {
        MyDB mydb = new MyDB();
        public ListMenu()
        {
            InitializeComponent();
        }

        private void ListMenu_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        private void Load_data()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM menu");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridViewMenu.DataSource = DBSQLServerUtils.getTable(command);
            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.RowTemplate.Height = 30;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_Id.Text.ToString());
                int price = Convert.ToInt32(textBox_Price.Text.ToString());
                string name = textBox_FoodName.Text;
                if (textBox_FoodName.Text == "" || textBox_Id.Text == "" || textBox_Price.Text == "")
                {
                    MessageBox.Show("Chưa nhập số liệu đầy đủ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
                else
                {         
                    SqlCommand command = new SqlCommand("EXEC insertMenu @id, @name, @price", mydb.getConnection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@price", SqlDbType.Int).Value = price;
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = name;
                    mydb.openConnection();

                    if ((command.ExecuteNonQuery() == 1))
                    {
                        mydb.closeConnection();
                        
                    }
                    else
                    {
                        mydb.closeConnection();
                        MessageBox.Show("Lỗi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }                 
            }
            catch
            {
                MessageBox.Show("Lỗi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_data();
        }
        int id;
        int price ;
        string name;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_Id.Text.ToString());
                int price = Convert.ToInt32(textBox_Price.Text.ToString());
                string name = textBox_FoodName.Text;
                if (textBox_FoodName.Text == "" || textBox_Id.Text == "" || textBox_Price.Text == "")
                {
                    MessageBox.Show("Chưa nhập số liệu đầy đủ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("EXEC updateMenu @id, @name, @price", mydb.getConnection);
                    // SqlCommand command = new SqlCommand("EXEC updateMenu @id, @name, @price", mydb.getConnection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@price", SqlDbType.Int).Value = price;
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = name;
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        MessageBox.Show("Đã chỉnh sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mydb.closeConnection();

                    }
                    else
                    {
                        mydb.closeConnection();
                        MessageBox.Show("Lỗi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_data();

        }

        private void dataGridViewMenu_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = dataGridViewMenu.CurrentRow.Cells["foodId"].Value.ToString();
            textBox_FoodName.Text = dataGridViewMenu.CurrentRow.Cells["foodName"].Value.ToString();
            textBox_Price.Text = dataGridViewMenu.CurrentRow.Cells["foodPrice"].Value.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_Id.Text.ToString());
            SqlCommand command = new SqlCommand("DELETE FROM menu WHERE foodId = @ID ", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
        }
    }
}
