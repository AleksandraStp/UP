using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cars f = new cars();
            f.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            orders f = new orders();
            f.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
