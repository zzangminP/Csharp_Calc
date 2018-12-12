namespace calc
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox1.Location = new System.Drawing.Point(224, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 418);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1학기때 교수님께 컴퓨터 구조, 2학기때 C# 을 배운 곽정민입니다.\r\n\r\n평소에 코딩에 관심은 많았지만 배우기는 질렸는데 교수님이 C# 강의를 " +
    "재밌게 알려주셔서 덕분에 다시 흥미를 느꼈습니다.\r\n\r\n다른 교수님들과 달리 훨씬 친절하고 편하게 대해주셔서 C# 강의가 좋았습니다.\r\n\r\n시험" +
    "이 손코딩인것빼고는 난이도도 적당하고 좋았습니다.\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "강해져서 돌아와라";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "교수님에게 하고 싶은 말";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}