
namespace HttpRequest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdtour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdround = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdmatch = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdchallenge = new System.Windows.Forms.TextBox();
            this.lbSolanluachon = new System.Windows.Forms.Label();
            this.lbChiphiluachon = new System.Windows.Forms.Label();
            this.lbChiphihoandoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lấy thông tin Tournament của đội chơi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(75, 17);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(437, 20);
            this.txtToken.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Token";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lấy thông tin đề bài bằng Id challenge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lấy hình ảnh đề bài bằng Id challenge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(697, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "POST";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 512);
            this.panel1.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(546, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Line";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(627, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Rotate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(708, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Submit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(789, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(546, 244);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Left";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(627, 244);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Up";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(708, 244);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Down";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(789, 244);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "Right";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rotations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "0 0 0 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id đội chơi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(581, 39);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(231, 23);
            this.button13.TabIndex = 20;
            this.button13.Text = "Lấy thông tin Tournament bằng Id tour";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(581, 68);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(231, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "Lấy thông tin cụ thể của round bằng id round";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(437, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Id tour";
            // 
            // txtIdtour
            // 
            this.txtIdtour.Location = new System.Drawing.Point(75, 75);
            this.txtIdtour.Name = "txtIdtour";
            this.txtIdtour.Size = new System.Drawing.Size(437, 20);
            this.txtIdtour.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Id round";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIdround
            // 
            this.txtIdround.Location = new System.Drawing.Point(75, 104);
            this.txtIdround.Name = "txtIdround";
            this.txtIdround.Size = new System.Drawing.Size(437, 20);
            this.txtIdround.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Id match";
            // 
            // txtIdmatch
            // 
            this.txtIdmatch.Location = new System.Drawing.Point(75, 133);
            this.txtIdmatch.Name = "txtIdmatch";
            this.txtIdmatch.Size = new System.Drawing.Size(437, 20);
            this.txtIdmatch.TabIndex = 28;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(581, 97);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(240, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "Lấy thông tin cụ thể của Match bằng Id match";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Id challenge";
            // 
            // txtIdchallenge
            // 
            this.txtIdchallenge.Location = new System.Drawing.Point(75, 158);
            this.txtIdchallenge.Name = "txtIdchallenge";
            this.txtIdchallenge.Size = new System.Drawing.Size(437, 20);
            this.txtIdchallenge.TabIndex = 31;
            // 
            // lbSolanluachon
            // 
            this.lbSolanluachon.AutoSize = true;
            this.lbSolanluachon.Location = new System.Drawing.Point(557, 386);
            this.lbSolanluachon.Name = "lbSolanluachon";
            this.lbSolanluachon.Size = new System.Drawing.Size(117, 13);
            this.lbSolanluachon.TabIndex = 32;
            this.lbSolanluachon.Text = "Số lần lựa chọn tối đa: ";
            this.lbSolanluachon.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbChiphiluachon
            // 
            this.lbChiphiluachon.AutoSize = true;
            this.lbChiphiluachon.Location = new System.Drawing.Point(557, 415);
            this.lbChiphiluachon.Name = "lbChiphiluachon";
            this.lbChiphiluachon.Size = new System.Drawing.Size(91, 13);
            this.lbChiphiluachon.TabIndex = 33;
            this.lbChiphiluachon.Text = "Chi phí lựa chọn: ";
            // 
            // lbChiphihoandoi
            // 
            this.lbChiphihoandoi.AutoSize = true;
            this.lbChiphihoandoi.Location = new System.Drawing.Point(558, 448);
            this.lbChiphihoandoi.Name = "lbChiphihoandoi";
            this.lbChiphihoandoi.Size = new System.Drawing.Size(92, 13);
            this.lbChiphihoandoi.TabIndex = 34;
            this.lbChiphihoandoi.Text = "Chi phí hoán đổi: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 704);
            this.Controls.Add(this.lbChiphihoandoi);
            this.Controls.Add(this.lbChiphiluachon);
            this.Controls.Add(this.lbSolanluachon);
            this.Controls.Add(this.txtIdchallenge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.txtIdmatch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdround);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdtour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdtour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdround;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdmatch;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdchallenge;
        private System.Windows.Forms.Label lbSolanluachon;
        private System.Windows.Forms.Label lbChiphiluachon;
        private System.Windows.Forms.Label lbChiphihoandoi;
    }
}

