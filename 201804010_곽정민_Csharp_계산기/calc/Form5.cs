﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calc
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // 전역변수    
        double Store_Sutja;
        string Store_Younsanja = "";
        bool Point_Flag = true; //true 면 점찍힘,아니면 안찍힘
        bool EndofCalcNum = false; // 모든 연산이 끝났는지 판별
        bool Newsutja_Flag = false;  //true : 한번 지우고 시작, false : 그냥 시작
        bool Depp = false; //연산자 중복체크
        //bool EndofPoint = false; // 계산끝나고 다시 점찍을때    <- 괜히 만들어서 계산기가 잘 안돌아가게함 12월 9일에 삭제하는 것으로 수정

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
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
            if (EndofCalcNum == true)
            {
                textBox1.Text = a.ToString();
                EndofCalcNum = false;

            }
            else if (textBox1.Text == "0" || textBox1.Text == "000" || textBox1.Text == "")
                textBox1.Text = a.ToString();
            else
                textBox1.Text = textBox1.Text + a;

            Depp = false;
            EndofCalcNum = false;

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

        private void button10_Click(object sender, EventArgs e) // 0 zero 버튼 
        {
            if (textBox1.Text == "0" || textBox1.Text == "000" || textBox1.Text == "")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e) // 소숫점 버튼 (소수점,소숫점,소수)
        {
            if (Point_Flag)
            {
                if (textBox1.Text == "" || EndofCalcNum == true)
                {
                    textBox1.Text = "0.";
                    EndofCalcNum = false;
                }
                else //if (EndofPoint == false)
                {
                    textBox1.AppendText(".");  //textBox1.Text = textBox1.Text + ".";

                }
                //EndofPoint = true;
                Point_Flag = false;
            }
        }

        private void button12_Click(object sender, EventArgs e) // 000 버튼
        {
            if (textBox1.Text == "0" || textBox1.Text == "000" || textBox1.Text == "")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "000";
        }


        private void button13_Click(object sender, EventArgs e) // C 버튼
        {
            textBox1.Text = "0";
            Store_Sutja = 0;
            Store_Younsanja = "";
            label3.Text = "";
            Point_Flag = true;
            Depp = false;
           // EndofPoint = false;
        }

        private void button14_Click(object sender, EventArgs e) // backspace 버튼
        {
            if (textBox1.Text == "0" || textBox1.TextLength == 1)
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


            if (Store_Younsanja == "" || Depp == true)          //더하기 연산자가 없다면
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "+";
                Depp = true;
            }
            else if (Depp == false)                             // 하나라도 있으면
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
            else if (Depp == false)
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
            else if (Depp == false)
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
            else if (Depp == false)
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

        private void button19_Click(object sender, EventArgs e) // 등호 버튼 =
        {

            iOperation();
            EndofCalcNum = true;
            Store_Younsanja = "";
            Point_Flag = true;
            Store_Sutja = 0;
            Newsutja_Flag = true;
            Depp = false;
            label3.Text = Store_Younsanja;

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
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
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

        private void button30_Click(object sender, EventArgs e) // log 상용 로그
        {
           double result= Math.Log10(double.Parse(textBox1.Text));
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();

        }

        public int Fto(int a)
        {
            if (a < 2)
                return a;
            else
                return a * Fto(a - 1);
        }

        private void button29_Click(object sender, EventArgs e) // factorial 팩토리얼 정수만 받아서 정수만 출력함
        {
            textBox1.Text= Fto(int.Parse(textBox1.Text)).ToString();
        }

        private void button28_Click(object sender, EventArgs e) //exp 지수
        {
            double result = Math.Exp(double.Parse(textBox1.Text));
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();

        }

        private void button27_Click(object sender, EventArgs e) //tan 탄젠트
        {
            double result = Math.Tan(double.Parse(textBox1.Text)/180*Math.PI);
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();
        }

        private void button26_Click(object sender, EventArgs e) //cos 코사인
        {
            double result = Math.Cos(double.Parse(textBox1.Text)/180*Math.PI);
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();
        }
        private void button25_Click(object sender, EventArgs e) //sin 사인 
        {
            double result = Math.Sin(double.Parse(textBox1.Text)/180*Math.PI);
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

                textBox1.Text = result.ToString();
        }


        private void 일반용계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private calc.Form5 child_form3;
        private void 공학용계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_form3 = new calc.Form5();
            child_form3.Owner = this;
            child_form3.Show();
            this.Hide();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 개발환경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("운영 체제 : Windows 7\n개발 도구: Microsoft Visual Studio 2015\n\t한컴오피스 한글 2010", "개발 환경");
        }
        private calc.Form3 child_form1; //네임스페이스 맞춤
        private void 개발자소개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_form1 = new calc.Form3();
            child_form1.Owner = this;
            child_form1.Show();
            this.Hide();
        }
        private calc.Form4 child_form2;
        private void 교수님께드리는말씀ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child_form2 = new calc.Form4();
            child_form2.Owner = this;
            child_form2.Show();
            this.Hide();
        }

        private void 사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private _2018_11_07_계산기만들기_곽정민.Form1 Parent_Form1;
        private void 일반용계산기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Parent_Form1 = new _2018_11_07_계산기만들기_곽정민.Form1();
            Parent_Form1.Owner = this;
            Parent_Form1.Show();
            this.Hide();
        }

        private void button31_Click(object sender, EventArgs e) // sinh 사인 하이퍼볼릭 버튼
        {
            double result = Math.Sinh(double.Parse(textBox1.Text));
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();
        }

        private void button32_Click(object sender, EventArgs e) // Cosh 코사인 하이퍼볼릭 버튼
        {
            double result = Math.Cosh(double.Parse(textBox1.Text));
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();
        }

        private void button33_Click(object sender, EventArgs e) // tanh 탄젠트 하이퍼볼릭 버튼
        {
            double result = Math.Tanh(double.Parse(textBox1.Text));
            if (result % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;

            textBox1.Text = result.ToString();
        }

        private void button34_Click(object sender, EventArgs e) // X^2 제곱 버튼 
        {
            textBox1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox1.Text)).ToString();
            if (double.Parse(textBox1.Text) % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;
        }

        private void button35_Click(object sender, EventArgs e) // X^3 세제곱 버튼
        {
            textBox1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox1.Text) * double.Parse(textBox1.Text)).ToString();
            if (double.Parse(textBox1.Text) % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;
        }

        private void button36_Click(object sender, EventArgs e) // 3제곱근 버튼
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text),(1.0/3.0)).ToString();
            if (double.Parse(textBox1.Text) % 1 == 0)
                Point_Flag = true;
            else
                Point_Flag = false;
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0.5 버전");
        }

        private void 사용법ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("+ : 숫자를 더합니다.\n- : 숫자를 뺍니다.\nX : 숫자를 곱합니다.\n/ : 숫자를 나눕니다\nC : 모든 계산을 초기화 합니다.\n% : 몫으로 나눈 나머지를 구합니다.\n√ : 제곱근(루트)를 구합니다.\n1/X : 역수를 취합니다.\nX^N : X의 N 제곱한 수를 구합니다.\n³√ : 세제곱근의 값을 구합니다\n± : 부호를 바꿉니다.\n Sin, SinH, Cos, Cosh, Tan, Tanh :각각 표기된 값을 구합니다.\n n! : n의 팩토리얼 값을 구합니다.\nlog : 상용로그 값을 구합니다.\nExp : e^x 를 구합니다.", "사용법");
        }
     
    }
}
