using System;
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
        bool Point_Flag = true; //true 면 점찍힘,아니면 안찍힘
        bool EndofCalcNum = false; // 모든 연산이 끝났는지 판별
        double Store_Sutja;
        string Store_Younsanja = "";
        bool Newsutja_Flag = false;  //true : 한번 지우고 시작, false : 그냥 시작
        bool Depp = false; //연산자 중복체크
        bool EndofPoint = false; // 계산끝나고 다시 점찍을때

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

        private void button10_Click(object sender, EventArgs e)
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


            if (Store_Younsanja == "" || Depp == true)                          //더하기 연산자가 없다면
            {
                Store_Sutja = double.Parse(textBox1.Text);
                Store_Younsanja = "+";
                Depp = true;
            }
            else if (Depp == false)                              // 하나라도 있으면
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
            textBox1.Text = Math.Log10(double.Parse(textBox1.Text)).ToString();

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
            textBox1.Text = Math.Exp(double.Parse(textBox1.Text)).ToString();
            
        }

        private void button27_Click(object sender, EventArgs e) //tan 탄젠트
        {
            textBox1.Text=Math.Tan(double.Parse(textBox1.Text)).ToString();
        }

        private void button26_Click(object sender, EventArgs e) //cos 코사인
        {
            textBox1.Text = Math.Cos(double.Parse(textBox1.Text)).ToString();
        }
        private void button25_Click(object sender, EventArgs e) //sin 사인 
        {
            textBox1.Text = Math.Sin(double.Parse(textBox1.Text)).ToString();
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
       
        private void 일반용계산기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
