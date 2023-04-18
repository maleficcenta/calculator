using System;
using System.Text;
namespace dza

{
    public partial class Form1 : Form
    {
        public int[,] mas = new int[3, 3];
        public int g = 0;
      
        public Form1()
        {

            InitializeComponent();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    g++;
                    mas[i,j] = g;
                }
            }
 
        }
        public int f = 1;
        public int f1 = 1;
        public int sw = 1;
        public string int1 = "0";
        public string int2 = "0";

        public static string NumberToRoman(int number)
        {
            if (number < 0 || number > 3999)
                throw new ArgumentException("Value must be in the range 0 - 3,999.");

            if (number == 0) return "N";

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[]
               { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 13; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }


            return result.ToString();
        }
        public void Count(string g)
        {
           
          

            if (f % 2 == 0)
            {
                if (int2 == "0")
                    int2 = g;
                
                else
                    int2 += g;
            }
            else
            {
                if (int1 == "0")
                    int1 = g;

                else
                    int1 += g;
            }
            if (sw % 2 == 0)
            {

                label1.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int1)));
                label2.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int2)));
            }
            else
            {
                label1.Text = int1;
                label2.Text = int2;
            }

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Count("1");
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Count("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Count("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Count("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Count("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Count("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Count("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Count("9");
        }


        private void button10_Click(object sender, EventArgs e)
        {
            f++;
            label3.Text = "+";
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            f++;
            label3.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            f++;
            label3.Text = "õ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            f++;
            label3.Text = ":";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            f++;
            label3.Text = "%";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label3.Text == "+")           
            {
                if(sw % 2 == 0)
                {
                    label4.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int1) + Convert.ToInt32(int2)));
                }

                else
                label4.Text = Convert.ToString(Convert.ToInt32(int1) + Convert.ToInt32(int2));
            }

            if (label3.Text == "-")
            {
                if (sw % 2 == 0)
                {
                    label4.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int1) - Convert.ToInt32(int2)));
                }

                else
                    label4.Text = Convert.ToString(Convert.ToInt32(int1) - Convert.ToInt32(int2));
            }
            if (label3.Text == "õ")
            {
                if (sw % 2 == 0)
                {
                    label4.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int1) * Convert.ToInt32(int2)));
                }

                else
                    label4.Text = Convert.ToString(Convert.ToInt32(int1) * Convert.ToInt32(int2));
            }
            if (label3.Text == ":")
            {
                if (sw % 2 == 0)
                {
                    label4.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int1) / Convert.ToInt32(int2)));
                }

                else
                    label4.Text = Convert.ToString(Convert.ToInt32(int1) / Convert.ToInt32(int2));
            }
            if (label3.Text == "%")
                if (sw % 2 == 0)
                {
                    label4.Text = Convert.ToString(NumberToRoman(Convert.ToInt32(int1) % Convert.ToInt32(int2)));
                }

                else
                    label4.Text = Convert.ToString(Convert.ToInt32(int1) % Convert.ToInt32(int2));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            sw = 1;
            f1 = 1;
            f = 1;
            int1 = "0";
            int2 = "0";
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "";
            label4.Text = "-";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            sw++;
            f1++;
            if (f1 % 2 == 0)
            {
                button1.Text = "I";
                button2.Text = "II";
                button3.Text = "III";
                button4.Text = "IV";
                button5.Text = "V";
                button6.Text = "VI";
                button7.Text = "VII";
                button8.Text = "VIII";
                button9.Text = "IX";
            }
            else
            {
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                button5.Text = "5";
                button6.Text = "6";
                button7.Text = "7";
                button8.Text = "8";
                button9.Text = "9";
            }
        }
    }
}