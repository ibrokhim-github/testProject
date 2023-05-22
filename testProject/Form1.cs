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

    enum RowState
    {
        Existed,
        New,
        Moodifed,
        MoodifedNew,
        Deleted
    }



    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        int selectedRow;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            CreateColumns();

            RefreshDataGrid(dataGridView1);



            /*
            
            comboBox1.Items.Add("False"); */
            string sas = "dsd0";
            numDrop.Items.Add("False");
            numDrop.Items.Add("dadada");

            




        }
        private void CreateColumns()
        {

            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("date", "date");
            dataGridView1.Columns.Add("tableNum", "number");
            dataGridView1.Columns.Add("mainDish", "MainDish");

            dataGridView1.Columns.Add("snak", "snak");
            dataGridView1.Columns.Add("total", "Total");
            dataGridView1.Columns.Add("payment", "Payment");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetDateTime(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetValue(6), RowState.MoodifedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM dbo.dateTable WHERE payment='False'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();

        }
        /*
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseConDataSet.dateTable". При необходимости она может быть перемещена или удалена.
            this.dateTableTableAdapter.Fill(this.baseConDataSet.dateTable);

        }*/



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pay()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            bool pay = textBox_num.Text == "True" ? true : false;

            if (!pay)
            {
                textBox_num.Text = "True";
                dataGridView1.Rows[selectedRowIndex].Cells[6].Value = "True";
                dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Moodifed;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pay();
            Update();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_date.Text = row.Cells[1].Value.ToString();
                textBox_num.Text = row.Cells[2].Value.ToString();
                textBox_main.Text = row.Cells[3].Value.ToString();
                textBox_snack.Text = row.Cells[4].Value.ToString();
                textBox_total.Text = row.Cells[5].Value.ToString();
                textBox_pay.Text = row.Cells[6].Value.ToString();


                
                

                
                Refresh();
                
            }
            }
            private void deleteRow()
            {
                if (dataGridView1.CurrentCell is null) return;
                int index = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                    return;
                }

                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                Update();
            }

            private void Update()
            {
                database.openConnection();
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                    if (rowState == RowState.Existed)
                        continue;
                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        var deleteQuery = $"DELETE  FROM dbo.dateTable WHERE id ={id}";

                        var command = new SqlCommand(deleteQuery, database.getConnection());
                        command.ExecuteNonQuery();
                    }

                    if (rowState == RowState.Moodifed)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var date2 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var num = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var main = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var snack = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var total = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var pay = dataGridView1.Rows[index].Cells[6].Value.ToString();

                        var changeQuery = $"update dateTable set date='{date2}',tableNum ='{num}',mainDish ='{main}',snak ='{snack}', total = '{total}', payment='{pay}' where id = '{id}' ";

                        var command = new SqlCommand(changeQuery, database.getConnection());
                        command.ExecuteNonQuery();
                    }


                }
                database.closeConnection();
            }

            private void deletBut_Click(object sender, EventArgs e)
            {
                deleteRow();
            }

            private void Change()
            {
                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                var id = textBox_id.Text;
                var date2 = date.Value;
                var num = textBox_num.Text;
                var main = textBox_main.Text;
                var snack = textBox_snack.Text;
                var total = textBox_total.Text;
                string pay = textBox_pay.Text;
            



            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id,date2, num,main,snack,total, pay);
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Moodifed;
                }


            }

            private void saveBut_Click(object sender, EventArgs e)
            {

                Change();
                Update();
               RefreshDataGrid(dataGridView1);
        }

            private void updateBut_Click(object sender, EventArgs e)
            {
                RefreshDataGrid(dataGridView1);
            }

            private void button3_Click(object sender, EventArgs e)
            {

            }

            private void history_but_Click(object sender, EventArgs e)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

            private void numDrop_SelectedIndexChanged(object sender, EventArgs e)
            {
            numDrop.SelectedValue = textBox_id.Text;            }

        private void textBox_id_TextChanged(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } } 
