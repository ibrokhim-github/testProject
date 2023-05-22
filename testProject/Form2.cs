using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testProject
{

    enum RowStat
    {
        Existed,
        New,
        Moodifed,
        MoodifedNew,
        Deleted
    }

    public partial class Form2 : Form
    {

        DataBase database = new DataBase();

        int selectedRow;


        private void Form2_Load_1(object sender, EventArgs e)
        {
            CreateColumns();

            RefreshDataGrid(dataGridView2);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM dbo.dateTable WHERE payment='True'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetValue(2), RowState.MoodifedNew);
        }

        private void CreateColumns()
        {

            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("tableNum", "number");
            dataGridView2.Columns.Add("payment", "Payment");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }

        private void back_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM dbo.dateTable  WHERE CONCAT (id, tableNum, payment) LIKE '%" + searchBox.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSinglRow(dgw, read);
            }
            read.Close();
        }
        private void search_but_Click(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }
    }
}
