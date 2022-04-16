using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text);
            listBox1.Items.Add("Tarih: " + dateTimePicker1.Text + "  " + "Saat: " + maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Bilgileri: " + textBox1.Text + "  " + "TC: " + maskedTextBox2.Text + "  " + "Telefon: " + maskedTextBox3.Text);
            listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------");

            MessageBox.Show("Yolcu Bilgileri Kaydedildi.");
        }
    }
}
