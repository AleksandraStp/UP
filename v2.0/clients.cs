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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            refresh();
        }
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from clients", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO clients(Surname, Name, Phone, Address, Account_number) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server = localhost; Database = carservice;uid=root;pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM clients Where id=" + textBox6.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            refresh();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
