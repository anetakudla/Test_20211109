using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Banka banka;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vklad = int.Parse(textBox_akce.Text);
            banka.Vklad(vklad);
            label_stav.Text = banka.stavKonta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vyber = int.Parse(textBox_platba.Text);
            banka.Vyber(vyber);
            label_stav.Text = banka.stavKonta.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Vypnuli jste aplikaci.");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banka = new Banka(60000, "657978/3244");
           
        }
    }
}
