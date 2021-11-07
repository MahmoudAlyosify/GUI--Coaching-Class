using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp___Coaching_Class
{
  

    public partial class Form1 : Form
    {
        static string Ty;
        static int num;
        static string tim;
        static decimal cha;
        static string font;
        public Form1()
        {
            InitializeComponent();
        }

        //##############################################

        class Coaching
        {
            string Coaching_Type;
            int N_player;
            string classTimings;
            decimal charges;
            public Coaching()
            {
                Coaching_Type = "";
                N_player = 0;
                classTimings = "";
                charges = 0;
            }

            public Coaching(string type, int num, string timing, decimal charges)
            {
                this.Coaching_Type = type;
                this.N_player = num;
                this.classTimings = timing;
                this.charges = charges;
            }
            public string CoachingType
            {
                get
                {
                    return this.CoachingType;
                }

                set
                {
                    this.CoachingType = value;
                }
            }
            public int Num_Of_Players
            {
                get
                {
                    return this.N_player;
                }

                set
                {
                    this.N_player = value;
                }
            }
            public string Class_Timing
            {
                get
                {
                    return this.classTimings;
                }

                set
                {
                    this.classTimings = value;
                }
            }
            public decimal Charges
            {
                get
                {
                    return this.charges;
                }

                set
                {
                    this.charges = value;
                }
            }
        }

        //##############################################
            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ty = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            num = int.Parse(textBox4.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tim = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cha=decimal.Parse(textBox3.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = comboBox1.Text.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(font== "Font 1")
            {
                label7.Text = "";
                label8.Text = "";
                 label6.Text = "Coaching Type: " + Ty.ToString() + "& Number Of Players: " + num.ToString();
                label9.Text="& Class Timing: " + tim + "& Charges: " + cha.ToString();

            }
            else if(font == "Font 2")
            {
                label6.Text = "";
                label9.Text = "";
             label7.Text = "Coaching Type: " + Ty.ToString() + "& Number Of Players: " + num.ToString();
                label8.Text = "& Class Timing: " + tim + "& Charges: " + cha.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
