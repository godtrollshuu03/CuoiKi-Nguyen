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
    public partial class AreaList : Form
    {
        MyDB mydb = new MyDB();
        public AreaList()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaList_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT areaId, areaName FROM area");
            fillGrid(command);
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView_listArea.DataSource = DBSQLServerUtils.getTable(command);
            dataGridView_listArea.ReadOnly = true;
            dataGridView_listArea.RowTemplate.Height = 30;
            dataGridView_listArea.Columns["areaName"].HeaderText = "Tên khu vực";

        }
        string area;
        int khuvuc;
        public void Table_Load()
        {
            dataGridView_listCom.ReadOnly = true;
            dataGridView_listCom.RowTemplate.Height = 40;
            dataGridView_listCom.DataSource = getListCom();
        }
        public DataTable getListCom()
        {
            SqlCommand command = new SqlCommand("select computer.comId, configuration.processor, configuration.monitor, configuration.keyboard, configuration.headphone from computer JOIN area ON computer.areaId = area.areaId JOIN configuration ON computer.comId = configuration.comId", mydb.getConnection);
            command.Parameters.Add("@ar", SqlDbType.Int).Value = khuvuc;
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

        private void dataGridView_listArea_Click(object sender, EventArgs e)
        {
            area = dataGridView_listArea.CurrentRow.Cells["areaId"].Value.ToString();
            khuvuc = int.Parse(area);
            Table_Load();
        }

    }
}
