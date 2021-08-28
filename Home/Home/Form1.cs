using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(textBox2.Text + "\r\n");
            richTextBox2.AppendText(textBox3.Text + "\r\n");
            richTextBox2.AppendText(comboBox1.Text + "\r\n");
            richTextBox2.AppendText(comboBox2.Text + "\r\n");
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            report filereport = new report(richTextBox2.Text);
            filereport.Show();
        }
    }
}
