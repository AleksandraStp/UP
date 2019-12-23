using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace v2._0
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();

            refresh();
        }

        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO orders(Describing, Price, Car, Begin_time, End_time) values('" + textBox1.Text + "'," + textBox2.Text + ",'" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {   MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM orders Where id=" + textBox4.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }


    }
}
