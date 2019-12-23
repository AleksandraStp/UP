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
    public partial class cars : Form
    {
        public cars()
        {
            InitializeComponent();

            refresh();
        }
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter  da = new MySqlDataAdapter ("select * from cars", con);
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
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO cars(Brand,Model,Client) values('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"')", con);
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
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM cars Where id=" + textBox4.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
