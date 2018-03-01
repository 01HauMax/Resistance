using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace r
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c=0, d=0, x;
            string r="";
            switch (comboBox1.Text)
            {
                case "Schwarz":
                    a = 0;
                    break;
                case "Braun":
                    a = 1;
                    break;
                case "Rot":
                    a = 2;
                    break;
                case "Orange":
                    a = 3;
                    break;
                case "Gelb":
                    a = 4;
                    break;
                case "Grün":
                    a = 5;
                    break;
                case "Blau":
                    a = 6;
                    break;
                case "Violett":
                    a = 7;
                    break;
                case "Grau":
                    a = 8;
                    break;
                case "Weiss":
                    a = 9;
                    break;
            }

            switch (comboBox2.Text)
            {
                case "Schwarz":
                    b = 0;
                    break;
                case "Braun":
                    b = 1;
                    break;
                case "Rot":
                    b = 2;
                    break;
                case "Orange":
                    b = 3;
                    break;
                case "Gelb":
                    b = 4;
                    break;
                case "Grün":
                    b = 5;
                    break;
                case "Blau":
                    b = 6;
                    break;
                case "Violett":
                    b = 7;
                    break;
                case "Grau":
                    b = 8;
                    break;
                case "Weiss":
                    b = 9;
                    break;
            }

            switch (comboBox3.Text)
            {
                case "Schwarz":
                    c = 0;
                    break;
                case "Braun":
                    c = 1;
                    break;
                case "Rot":
                    c = 2;
                    break;
                case "Orange":
                    c = 3;
                    break;
                case "Gelb":
                    c = 4;
                    break;
                case "Grün":
                    c = 5;
                    break;
                case "Blau":
                    c = 6;
                    break;
                case "Violett":
                    c = 7;
                    break;
            }

            switch (comboBox4.Text)
            {
                case "Braun":
                    d = 1;
                    break;
                case "Rot":
                    d = 2;
                    break;
                case "Silber":
                    d = 10;
                    break;
                case "Gold":
                    d = 5;
                    break;
                case "Grün":
                    d = 0.5;
                    break;
                case "Blau":
                    d = 0.25;
                    break;
                case "Violett":
                    d = 0.1;
                    break;
                case "Grau":
                    d = 0.05;
                    break;
            }
            x = (a * 10 + b) * Math.Pow(10, c);
            if(x%1000!=0)
            {
                r = Convert.ToString(x);
            }
            int c4 = 0;
            while (x % 1000 == 0)
            {
                x = x / 1000;
                if(c4==0)
                r = x + "k";
                if(c4==1)
                    r = x + "M";
                c4 = c4 + 1;
            }
            label1.Text = Convert.ToString("R: "+r+" + " + d + "%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b;
            double c=7;
            double p = Convert.ToDouble(textBox2.Text);
            string d;
            for (double i = 10000000; a % i != 0; i =i/10)
            {
                c = c - 1;
            }
            b = a / Math.Pow(10,c);
            d = Convert.ToString(b);
            a = d[0] - '0';
            b = d[1] - '0';

            switch (Convert.ToInt32(a))
            {
                case 0:
                    label3.ForeColor = Color.Black;
                    break;
                case 1:
                    label3.ForeColor = Color.Brown;
                    break;
                case 2:
                    label3.ForeColor = Color.Red;
                    break;
                case 3:
                    label3.ForeColor = Color.Orange;
                    break;
                case 4:
                    label3.ForeColor = Color.Yellow;
                    break;
                case 5:
                    label3.ForeColor = Color.Green;
                    break;
                case 6:
                    label3.ForeColor = Color.Blue;
                    break;
                case 7:
                    label3.ForeColor = Color.Violet;
                    break;
                case 8:
                    label3.ForeColor = Color.Gray;
                    break;
                case 9:
                    label3.ForeColor = Color.White;
                    break;
            }

            switch (Convert.ToInt32(b))
            {
                case 0:
                    label4.ForeColor = Color.Black;
                    break;
                case 1:
                    label4.ForeColor = Color.Brown;
                    break;
                case 2:
                    label4.ForeColor = Color.Red;
                    break;
                case 3:
                    label4.ForeColor = Color.Orange;
                    break;
                case 4:
                    label4.ForeColor = Color.Yellow;
                    break;
                case 5:
                    label4.ForeColor = Color.Green;
                    break;
                case 6:
                    label4.ForeColor = Color.Blue;
                    break;
                case 7:
                    label4.ForeColor = Color.Violet;
                    break;
                case 8:
                    label4.ForeColor = Color.Gray;
                    break;
                case 9:
                    label4.ForeColor = Color.White;
                    break;
            }

            switch (Convert.ToInt32(c))
            {
                case 0:
                    label6.ForeColor = Color.Black;
                    break;
                case 1:
                    label6.ForeColor = Color.Brown;
                    break;
                case 2:
                    label6.ForeColor = Color.Red;
                    break;
                case 3:
                    label6.ForeColor = Color.Orange;
                    break;
                case 4:
                    label6.ForeColor = Color.Yellow;
                    break;
                case 5:
                    label6.ForeColor = Color.Green;
                    break;
                case 6:
                    label6.ForeColor = Color.Blue;
                    break;
                case 7:
                    label6.ForeColor = Color.Violet;
                    break;
                case 8:
                    label6.ForeColor = Color.Gray;
                    break;
                case 9:
                    label6.ForeColor = Color.White;
                    break;
            }

            if(p==1)
            {
                    label5.ForeColor = Color.Brown;
            }
            else if(p==2)
            {
                    label5.ForeColor = Color.Red;
            }
                else if(p==0.5)
            {
                    label5.ForeColor = Color.Green;
                    }
                else if(p==0.25)
            {
                    label5.ForeColor = Color.Blue;
                    }
               else if(p==0.1)
            {
                    label5.ForeColor = Color.Violet;
                    }
                else if(p==0.05)
            {
                    label5.ForeColor = Color.Gray;
                    }
                else if(p==5)
            {
                    label5.ForeColor = Color.Gold;
                    }
                else if(p==10)
            {
                    label5.ForeColor = Color.Silver;
                    }
            }
        }
    }

