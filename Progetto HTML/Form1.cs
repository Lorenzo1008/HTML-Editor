using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Progetto_HTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Metodo()
        {
            webBrowser1.DocumentText = textBox1.Text.Replace("@Ciao", textBox2.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Metodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Metodo();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Metodo();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            Metodo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog2.FileName, textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                textBox1.Text=File.ReadAllText(textBox1.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;
                textBox2.Text = File.ReadAllText(textBox2.Text);

            }
        }


    }
}
