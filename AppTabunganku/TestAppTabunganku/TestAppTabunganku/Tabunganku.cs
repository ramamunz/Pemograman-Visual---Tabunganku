using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppTabunganku
{
    public partial class Tabunganku : Form
    {
        public Tabunganku()
        {
            InitializeComponent();
        }


        private void Tabunganku_Load(object sender, EventArgs e)
        {
            Keterangan.Items.Add("Masuk");
            Keterangan.Items.Add("Keluar");
            Keterangan.SelectedIndex = 0;
        }

        void Bersih()
        {
            Nominal.Clear();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] item = { tglBox.Value + "", Nominal.Text, Keterangan.Text };
            ListViewItem obj = new ListViewItem(item);
            listView1.Items.Add(obj);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tglBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
