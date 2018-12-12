using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_11_07_계산기만들기_곽정민
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // 전역변수
        bool Point_Flag = true; //true 면 점찍힘,아니면 안찍힘
        double Store_Sutja;
        string Store_Younsanja = "";
        bool Newsutja_Flag = false;  //true : 한번 지우고 시작, false : 그냥 시작
        bool Depp = false; //연산자 중복체크
        bool EndofPoint = false; // 계산끝나고 다시 점찍을때

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        public void zero_sub(int a) 
        {
            if (Newsutja_Flag == false)
            {
                textBox1.Text = "";
                Newsutja_Flag = true;
            }

            if (textBox1.Text == "0" || textBox1.Text == "000" || textBox1.Text == "")
                    textBox1.Text = a.ToString();
                else
                    textBox1.Text = textBox1.Text + a;
            Depp = false;
            
        }
        public void iOperation()
        {
            if (Store_Younsanja == "+")
                textBox1.Text = (Store_Sutja + double.Parse(textBox1.Text)).ToString();
            else if (Store_Younsanja == "-")
                textBox1.Text = (Store_Sutja - double.Parse(textBox1.Text)).ToString();
            else if (Store_Younsanja == "*")
                textBox1.Text = (Store_Sutja * double.Parse(textBox1.Text)).ToString();
            else if (Store_Younsanja == "/")
                textBox1.Text = (Store_Sutja / double.Parse(textBox1.Text)).ToString();
            else if (Store_Younsanja == "%")
                textBox1.Text = (Store_Sutja % double.Parse(textBox1.Text)).ToString();
            else if (Store_Younsanja == "^")
                textBox1.Text = Math.Pow(Store_Sutja, double.Parse(textBox1.Text)).ToString();
            else
            textBox1.Text = (double.Parse(textBox1.Text)).ToString();
            
            /*if(double.Parse(textBox1.Text) <0)
                textBox1.TextAlign = 
                */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            zero_sub(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            zero_sub(8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            zero_sub(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            zero_sub(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            zero_sub(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            zero_sub(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            zero_sub(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            zero_sub(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            zero_sub(3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="0" || textBox1.Text =="000" || textBox1.Text == "")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e) // 소숫점 버튼 (소수점,소숫점,소수)
        {
            if (Point_Flag)
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0.";
                else if (EndofPoint == false)
                {
                    textBox1.AppendText(".");  //textBox1.Text = textBox1.Text + ".";
                    
                }
                EndofPoint = true;
                Point_Flag = false;
            }
            }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "000" || textBox1.Text == "")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "000";
        }


        private void button13_Click(object sender, EventArgs e) // C 버튼
        {
            textBox1.Text = "0";
            Point_Flag = true;
            Store_Sutja = 0;
            Store_Younsanja = "";
            Depp = false;
            label3.Text = "";
            EndofPoint = false;
        }

        private void button14_Click(object sender, EventArgs e) // backspace 버튼
        {
            if (textBox1.Text == "0"|| textBox1.TextLength==1)
                textBox1.Text = "0";
            else
            {
                if (textBox1.Text != "" || textBox1.Text == "0")
                {
                    if (textBox1.Text.Substring(textBox1.Text.Length - 1) == ".")
                    {
                        Point_Flag = true;
                    }
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

                }
            }
        }
        private void button15_Click(object sender, EventArgs e) // 더하기 버튼 +
        {
            

            if (Store_Younsanja == "" || Depp == true)                          //더하기 연산자가 없다면
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "+";
                Depp = true;
            }
            else if(Depp == false)                              // 하나라도 있으면
            {               
                iOperation();
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "+";
                Depp = true;
             
            }
            Newsutja_Flag = false;
            Point_Flag = true;

            label3.Text = Store_Younsanja;

        }

        private void button16_Click(object sender, EventArgs e) // 빼기 버튼 -
        {
            if (Store_Younsanja == "" || Depp == true)                          
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "-";
              

            }
            else if(Depp == false)                                        
            {
                iOperation();
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "-";
                Depp = true;
             

            }
            Newsutja_Flag = false;
            Point_Flag = true;

            label3.Text = Store_Younsanja;

        }

        private void button17_Click(object sender, EventArgs e) // 곱하기 버튼 X *
        {
           
            if (Store_Younsanja == "" || Depp == true)                          
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "*";
               
            }
            else if(Depp == false)                                             
            {
                iOperation();
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "*";
                Depp = true;
                

            }
            Newsutja_Flag = false;
            Point_Flag = true;

            label3.Text = Store_Younsanja;

        }

        private void button18_Click(object sender, EventArgs e) // 나누기 버튼 /
        {
            
            if (Store_Younsanja == "" || Depp == true)                          
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "/";
              

            }
            else if(Depp==false)                                                 
            {
                iOperation();
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "/";
                Depp = true;
            }
            Newsutja_Flag = false;
            Point_Flag = true;
            label3.Text = Store_Younsanja;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            iOperation();
            Store_Younsanja = ""; 
            Point_Flag = true;
            Store_Sutja = 0;
            Newsutja_Flag = true;  
            Depp = false;
            
        }
        private void button20_Click(object sender, EventArgs e) // 나머지 버튼 %
        {
            if (Store_Younsanja == "" || Depp == true)
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "%";

            }
            else if (Depp == false)
            {
                iOperation();
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "%";
                Depp = true;


            }
            Newsutja_Flag = false;
            Point_Flag = true;

            label3.Text = Store_Younsanja;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e) // 역수 버튼
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = (1/double.Parse(textBox1.Text)).ToString();
        }

       private void button22_Click(object sender, EventArgs e) // 거듭제곱 버튼 
        {
            iOperation();
            if (Store_Younsanja == "" || Depp == true)
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "^";


            }
            else if (Depp == false)
            {
                iOperation();
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "^";
                Depp = true;
            }
            Newsutja_Flag = false;
            Point_Flag = true;
            label3.Text = Store_Younsanja;
        }
        
        private void button23_Click(object sender, EventArgs e) // 제곱근 버튼
        {
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
            Store_Younsanja = "";
            Point_Flag = true;
            Store_Sutja = 0;
            Newsutja_Flag = true;
            Depp = false;

        }

        private void button24_Click(object sender, EventArgs e) // 부호 버튼
        {
                textBox1.Text = (double.Parse(textBox1.Text) * -1).ToString();
        }

        private Form2 child_form2;
       

        private void 일반용계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void 공학용계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_form2 = new Form2();
            child_form2.Owner = this;
            child_form2.Show();
            this.Hide();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

