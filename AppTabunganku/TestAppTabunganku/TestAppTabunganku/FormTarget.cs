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
    public partial class FormTarget : Form
    {
        public FormTarget()
        {
            InitializeComponent();
        }

        private void button500_Click(object sender, EventArgs e)
        {
            Tabunganku tabungan = new Tabunganku();
            tabungan.Show();
            this.Hide();
        }

        private void labelTabungan_Click(object sender, EventArgs e)
        {

        }
    }
}
