
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnline = new System.Windows.Forms.Button();
            this.btnrotate = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lấy thông tin Tournament của đội chơi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(71, 34);
            this.txtToken.Name = "txtToken";
            this.txtToken.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToken.Size = new System.Drawing.Size(1272, 20);
            this.txtToken.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Token";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lấy thông tin đề bài bằng Id challenge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lấy hình ảnh đề bài bằng Id challenge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(611, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 608);
            this.panel1.TabIndex = 7;
            // 
            // btnline
            // 
            this.btnline.Enabled = false;
            this.btnline.Location = new System.Drawing.Point(13, 476);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(75, 53);
            this.btnline.TabIndex = 8;
            this.btnline.Text = "Line";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnrotate
            // 
            this.btnrotate.Enabled = false;
            this.btnrotate.Location = new System.Drawing.Point(94, 476);
            this.btnrotate.Name = "btnrotate";
            this.btnrotate.Size = new System.Drawing.Size(75, 53);
            this.btnrotate.TabIndex = 9;
            this.btnrotate.Text = "Rotate";
            this.btnrotate.UseVisualStyleBackColor = true;
            this.btnrotate.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(175, 476);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "Submit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(256, 476);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 53);
            this.button8.TabIndex = 11;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnleft
            // 
            this.btnleft.Enabled = false;
            this.btnleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleft.Location = new System.Drawing.Point(12, 535);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(75, 53);
            this.btnleft.TabIndex = 12;
            this.btnleft.Text = "Left";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnup
            // 
            this.btnup.Enabled = false;
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(94, 535);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 53);
            this.btnup.TabIndex = 13;
            this.btnup.Text = "Up";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndown
            // 
            this.btndown.Enabled = false;
            this.btndown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndown.Location = new System.Drawing.Point(175, 535);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 53);
            this.btndown.TabIndex = 14;
            this.btndown.Text = "Down";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnright
            // 
            this.btnright.Enabled = false;
            this.btnright.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnright.Location = new System.Drawing.Point(256, 535);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(75, 53);
            this.btnright.TabIndex = 15;
            this.btnright.Text = "Right";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rotations";
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(384, 132);
            this.lbresult.Name = "lbresult";
            this.lbresult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbresult.Size = new System.Drawing.Size(40, 13);
            this.lbresult.TabIndex = 18;
            this.lbresult.Text = "0 0 0 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id đội chơi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(8, 240);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(261, 23);
            this.button13.TabIndex = 20;
            this.button13.Text = "Lấy thông tin Tournament bằng Id tour";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(8, 269);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(261, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "Lấy thông tin cụ thể của round bằng id round";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Id tour";
            // 
            // txtIdtour
            // 
            this.txtIdtour.Location = new System.Drawing.Point(71, 92);
            this.txtIdtour.Name = "txtIdtour";
            this.txtIdtour.Size = new System.Drawing.Size(198, 20);
            this.txtIdtour.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Id round";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIdround
            // 
            this.txtIdround.Location = new System.Drawing.Point(71, 121);
            this.txtIdround.Name = "txtIdround";
            this.txtIdround.Size = new System.Drawing.Size(198, 20);
            this.txtIdround.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Id match";
            // 
            // txtIdmatch
            // 
            this.txtIdmatch.Location = new System.Drawing.Point(71, 150);
            this.txtIdmatch.Name = "txtIdmatch";
            this.txtIdmatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdmatch.Size = new System.Drawing.Size(198, 20);
            this.txtIdmatch.TabIndex = 28;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(9, 298);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(259, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "Lấy thông tin cụ thể của Match bằng Id match";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Id challenge";
            // 
            // txtIdchallenge
            // 
            this.txtIdchallenge.Location = new System.Drawing.Point(71, 175);
            this.txtIdchallenge.Name = "txtIdchallenge";
            this.txtIdchallenge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdchallenge.Size = new System.Drawing.Size(198, 20);
            this.txtIdchallenge.TabIndex = 31;
            // 
            // lbSolanluachon
            // 
            this.lbSolanluachon.AutoSize = true;
            this.lbSolanluachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolanluachon.Location = new System.Drawing.Point(13, 384);
            this.lbSolanluachon.Name = "lbSolanluachon";
            this.lbSolanluachon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSolanluachon.Size = new System.Drawing.Size(232, 25);
            this.lbSolanluachon.TabIndex = 32;
            this.lbSolanluachon.Text = "Số lần lựa chọn tối đa: ";
            this.lbSolanluachon.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbChiphiluachon
            // 
            this.lbChiphiluachon.AutoSize = true;
            this.lbChiphiluachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiphiluachon.Location = new System.Drawing.Point(13, 418);
            this.lbChiphiluachon.Name = "lbChiphiluachon";
            this.lbChiphiluachon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbChiphiluachon.Size = new System.Drawing.Size(179, 25);
            this.lbChiphiluachon.TabIndex = 33;
            this.lbChiphiluachon.Text = "Chi phí lựa chọn: ";
            // 
            // lbChiphihoandoi
            // 
            this.lbChiphihoandoi.AutoSize = true;
            this.lbChiphihoandoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiphihoandoi.Location = new System.Drawing.Point(13, 449);
            this.lbChiphihoandoi.Name = "lbChiphihoandoi";
            this.lbChiphihoandoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbChiphihoandoi.Size = new System.Drawing.Size(180, 25);
            this.lbChiphihoandoi.TabIndex = 34;
            this.lbChiphihoandoi.Text = "Chi phí hoán đổi: ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(49, 633);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(271, 42);
            this.button5.TabIndex = 35;
            this.button5.Text = "Lấy danh sách câu trả lời cho của một Challenge";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(94, 681);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "DELETE sollution của challenge";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Endpoint";
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Location = new System.Drawing.Point(71, 6);
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.Size = new System.Drawing.Size(198, 20);
            this.txtEndpoint.TabIndex = 38;
            this.txtEndpoint.Text = "http://112.137.129.202:8001";
            this.txtEndpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEndpoint.TextChanged += new System.EventHandler(this.txtEndpoint_TextChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 604);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "RawChallenge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 704);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtEndpoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnrotate);
            this.Controls.Add(this.btnline);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PROCON 2021";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnrotate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbresult;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Button button4;
    }
}

