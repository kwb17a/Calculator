/* Calculator that takes in a long input string and works in a (*,/,%,+,-) order of operations */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty, result = string.Empty;     //Input and Results for the display
        string[] slot = new string[100];                        //Array to store numbers in even terms and operators in odd terms
        int i = 0;                                              //Counter for terms
        bool errorBit = false;                                  //Error term
        
        public Form1()                      //Constructor with a loop to initiate slot[]
        {
            InitializeComponent();
            textBox1.Text = ""+ Environment.NewLine + "--------------" + Environment.NewLine + "";
            textBox1.TextAlign = HorizontalAlignment.Right;
            for (int j = 0; j < 100; j++)
                slot[j] = "";
        }
        private void update()               //Updates whenever terms change
        {
            if (errorBit == true)
                result = "ERROR";
            textBox1.Text = input + Environment.NewLine +"--------------"+Environment.NewLine + result;
        }

                                            /* BUTTONS: */
        private void button1_Click_1(object sender, EventArgs e)    // AC Button (clears all fields)
        {
            for (int j = 0; j < 100; j++)
                slot[j] = "";
            i = 0;
            input = "";
            result = "";
            errorBit = false;
            update();
        }

        private void button1_Click(object sender, EventArgs e)      // x Button
        {
            if (i == 0 && slot[i] == "")
            {
                errorBit = true;
                update();
            }
            else
            {
                i++;
                if (i % 2 == 1)
                    slot[i] = "*";
                else
                    errorBit = true;
                input += "*";
                update();
            }
        }

        private void button10_Click(object sender, EventArgs e)     // % Button
        {
            if (i == 0 && slot[i] == "")
            {
                errorBit = true;
                update();
            }
            else
            {
                i++;
                if (i % 2 == 1)
                    slot[i] = "%";
                else
                    errorBit = true;
                input += "%";
                update();
            }
        }
        private void button14_Click(object sender, EventArgs e)     // / Button
        {
            if (i == 0 && slot[i] == "")
            {
                errorBit = true;
                update();
            }
            else
            {
                i++;
                if (i % 2 == 1)
                    slot[i] = "/";
                else
                    errorBit = true;
                input += "/";
                update();
            }
        }

        private void button15_Click(object sender, EventArgs e)     // + Button
        {
            if (i == 0 && slot[i] == "")
            {
                errorBit = true;
                update();
            }
            else
            {
                i++;
                if (i % 2 == 1)
                    slot[i] = "+";
                else
                    errorBit = true;
                input += "+";
                update();
            }
        }

        private void button16_Click(object sender, EventArgs e)     // - Button
        {
            if (i % 2 == 1 && slot[i] == "")
                slot[i] = "-";
            else if (i % 2 == 1 && slot[i] != "" && slot[i] != "-")
            {
                i++;
                slot[i] += "-";
            }
            else if (i % 2 == 0 && slot[i] == "" && i > 0 && slot[i - 1] != "-")
                slot[i] += "-";
            else if (i % 2 == 0 && slot[i] == "")
                slot[i] += "-";
            else if (i % 2 == 0 && slot[i] != "")
            {
                i++;
                slot[i] = "-";
            }
            else
                errorBit = true;

            input += "-";
            update();
        }
        private void button5_Click(object sender, EventArgs e)      // +/- Button
        {
            if (i % 2 == 1 && slot[i] == "")
                slot[i] = "-";
            else if (i % 2 == 1 && slot[i] != "" && slot[i] != "-")
            {
                i++;
                slot[i] += "-";
            }
            else if (i % 2 == 0 && slot[i] == "" && i > 0 && slot[i - 1] != "-")
                slot[i] += "-";
            else if (i % 2 == 0 && slot[i] == "")
                slot[i] += "-";
            else if (i % 2 == 0 && slot[i] != "")
            {
                i++;
                slot[i] = "-";
            }
            else
                errorBit = true;

            input += "-";
            update();
        }

        private void button18_Click(object sender, EventArgs e)     // . Button
        {
            if(i % 2 == 1)
                i++;
            if (slot[i] == "")
            {
                slot[i] += "0.";
                input += "0.";
            }
            else
            {
                slot[i] += ".";
                input += ".";
            }
            update();
        }

        private void button2_Click(object sender, EventArgs e)      // 1
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "1";
            input += "1";
            update();
        }

        private void button6_Click(object sender, EventArgs e)      // 2
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "2";
            input += "2";
            update();
        }

        private void button11_Click(object sender, EventArgs e)     // 3
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "3";
            input += "3";
            update();
        }

        private void button3_Click(object sender, EventArgs e)      // 4
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "4";
            input += "4";
            update();
        }

        private void button7_Click(object sender, EventArgs e)      // 5
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "5";
            input += "5";
            update();
        }

        private void button12_Click(object sender, EventArgs e)     // 6
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "6";
            input += "6";
            update();
        }

        private void button4_Click(object sender, EventArgs e)      // 7
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "7";
            input += "7";
            update();
        }

        private void button9_Click(object sender, EventArgs e)      // 8
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "8";
            input += "8";
            update();
        }

        private void button13_Click(object sender, EventArgs e)     // 9
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "9";
            input += "9";
            update();
        }

        private void button8_Click(object sender, EventArgs e)      // 0
        {
            if (i % 2 == 1)
                i++;
            slot[i] += "0";
            input += "0";
            update();
        }
        private void button19_Click(object sender, EventArgs e)     // = Button
        {
            void oppSweep(string s)         //Sweeps for operator and loops till there are no more matches
            {
                for(int j = 0; j < i; j++)
                {
                    if (slot[j] == s)
                    {
                        string temp = calc(j, s);
                        slot[j - 1] = temp;
                        for (int k = j; k < 98; k++)
                            slot[k] = slot[k + 2];
                        oppSweep(s);
                        break;
                    }
                }
            }
            oppSweep("*");          //Calls for every operator in the sweep
            oppSweep("/");
            oppSweep("%");
            oppSweep("+");
            oppSweep("-");

            result = slot[0];       //Final number is the result
            update();               //Final update.
        }
        private string calc(int x, string s)            //Returns calculation depending on operator
        {
            if (s == "*")
                return Convert.ToString(Convert.ToDouble(slot[x - 1]) * Convert.ToDouble(slot[x + 1]));
            else if (s == "/")
                return Convert.ToString(Convert.ToDouble(slot[x - 1]) / Convert.ToDouble(slot[x + 1]));
            else if (s == "%")
                return Convert.ToString(Convert.ToDouble(slot[x - 1]) % Convert.ToDouble(slot[x + 1]));
            else if (s == "+")
                return Convert.ToString(Convert.ToDouble(slot[x - 1]) + Convert.ToDouble(slot[x + 1]));
            else if (s == "-")
                return Convert.ToString(Convert.ToDouble(slot[x - 1]) - Convert.ToDouble(slot[x + 1]));

            errorBit = true;
            return "";
                
        }
        private void clean (int x)                      //Moves terms down the array after a calculation to simply
        {
            for(int j = x; j <= i; i++)
            {
                slot[j] = slot[j + 2];
            }
            i -= 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}