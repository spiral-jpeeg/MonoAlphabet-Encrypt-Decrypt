using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Veloso_Monoalphabetic_encrypt_decrypt.ClsmonoCipher;

namespace Veloso_Monoalphabetic_encrypt_decrypt
{
    public partial class Form1 : Form
    {
        //given substitution alphabet
        public string key = "ybionjmqegvdwhkcapfxsluztr";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            richTextBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = richTextBox1.Text;
            richTextBox2.Text = monoalph.Encrypt(message, key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = richTextBox3.Text;
            richTextBox4.Text = monoalph.Decrypt(message, key);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
