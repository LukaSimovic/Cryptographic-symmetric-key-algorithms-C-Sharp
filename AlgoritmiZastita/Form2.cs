using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmiZastita
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int ch = 0;
        public int put = 0;

        public Form2(string message, string buttonText1, string buttonText2)
        {
            InitializeComponent();
            label1.Text = message;
            button1.Text = buttonText1;
            button3.Text = buttonText2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            put = 1;
            if (checkBox1.Checked == true)
            {
                ch = 1;
            }
            ((Form1)Owner).ubaciTekst(put,ch);
            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            put = 0;
            if (checkBox1.Checked == true)
            {
                ch = 1;
            }
            ((Form1)Owner).ubaciTekst(put, ch);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 200);

        }
    }
}
