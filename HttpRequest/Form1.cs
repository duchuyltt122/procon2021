using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using System.Web;
using Newtonsoft.Json.Linq;

namespace HttpRequest
{
    public partial class Form1 : Form
    {
        int sohang;
        int socot;
        int solanluachontoida;
        int chiphiluachon;
        int chiphihoandoi;
        int kichcoanh;
        int kichcotoidacua1diemanh;
        int vitri = 0;
        int solanluachon = 0;
        int i_curr, j_curr;
        int[] check_move;
        int[,] check_click;
        int[] rotate;
        string result_submit = "";
        string result_move = "";
        string move = "";
        int rotated = 0;
        private List<List<Button>> arrBtn= new List<List<Button>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String methodGET(String url, String para, String token)
        {

            var httpRequest = (HttpWebRequest)WebRequest.Create(url+para);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer "+token;

            String kq = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                kq = result;
            }
            return kq;
        }
        private String methodDELETE(String url, String para, String token)
        {

            var httpRequest = (HttpWebRequest)WebRequest.Create(url + para);
            httpRequest.Method = "DELETE";
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer " + token;

            String kq = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                kq = result;
            }
            return kq;
        }
        private void methodPOST(String url, String para, String content, String token)
        {

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer "+token;
            httpRequest.ContentType = "text/plain";

            var data = content;

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
        }
        void print_result()
        {
            string result = "";
            
            for(int i = 0; i < rotate.Length; i++)
            {
                result += rotate[i];
            }
            if (solanluachon > 0)
            {
                //lbresult.Text = result + "\n" + solanluachon + result_move;
                result += "\n" + solanluachon + result_submit + "\n" + move.Length + "\n" + move;
                /*if (move.Length > 0)
                {
                    result_move= result_submit+ "\n" + move.Length + "\n" + move; 
                }*/
            }
            else
            {
               //lbresult.Text =result+ "\n" + solanluachon;
                result += "\n" + solanluachon;
            }
            lbresult.Text = result;

        }
        void swapButton(int i1, int j1, int i2, int j2)
        {
            Button tmp;
            tmp = arrBtn[i1][j1];
            arrBtn[i1][j1]=arrBtn[i2][j2];
            arrBtn[i2][j2] = tmp;
           /* arrBtn[i1][j1].FlatStyle = FlatStyle.Standard;
            arrBtn[i2][j2].FlatStyle = FlatStyle.Flat;*/
            drawMap(i2,j2);
        }
        private String laydebai(String url, String para, String token)
        {

            String kq = "";
            kq = methodGET(url, para, token);
            return kq;
        }
        private String layhinhdebai(String url, String para, String token)
        {

            String kq = "";
            kq = methodGET(url, para, token);
            return kq;
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text+"/tournament/";
            String token = txtToken.Text;
            String para = "";
            String kq = methodGET(url, para, token);
            JArray jarr = JArray.Parse(kq);
            MessageBox.Show(jarr.ToString());
            Console.WriteLine(url);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/challenge/raw/";
            String token = txtToken.Text;
            String para = txtIdchallenge.Text;
            String kq = "";
            String tmp = "";
            kq= laydebai(url, para, token);
            
            kq = kq.Substring(kq.IndexOf("#")); //cat head
            kq = kq.Replace("#", "");   //xoa #
            kq = kq.Replace("\n", " ");
            kq = kq.Replace("  ", " ");
            tmp = kq;
            String[] list = kq.Split(' ');
            sohang = int.Parse(list[1]);
            socot = int.Parse(list[2]);
            rotate = new int[socot * sohang];
            check_move= new int[socot * sohang];
            solanluachontoida = int.Parse(list[3]);
            chiphiluachon = int.Parse(list[4]);
            chiphihoandoi = int.Parse(list[5]);
            kichcoanh = int.Parse(list[6]);
            check_click = new int[sohang,socot];
            lbSolanluachon.Text = "Số lần lựa chọn tối đa: " + solanluachontoida;
            lbChiphiluachon.Text = "Chi phí lựa chọn: " + chiphiluachon;
            lbChiphihoandoi.Text = "Chi phí hoán đổi: " + chiphihoandoi;
            kichcotoidacua1diemanh = int.Parse(list[8]);
            String rs = "So hang:"+sohang+"\nSo cot:"+socot+"\nSo lan lua chon toi da:"+solanluachontoida+"\nChi phi lua chon:"+chiphiluachon+"\nChi phi hoan doi:"+chiphihoandoi+"\nKich co anh:"+kichcoanh+"\nKich co toi da cua 1 diem anh:"+kichcotoidacua1diemanh;
            MessageBox.Show(tmp+"\n"+rs);
        }
        class image
        {
            public List<string> base64 { get; set; }
        }
        void drawMap(int i1,int j1)
        {
            panel1.AutoSize = true;
            panel1.Controls.Clear();
            int m = sohang, n = socot;
            int h = kichcoanh / m;
            int w = kichcoanh / n;
            int vertical = 0, horizontal = 0;
            int i = 0, j = 0;
            for (i = 0; i < sohang; i++)
            {
                horizontal = 0;
                for (j = 0; j < socot; j++)
                {
                    
                    Button btn = new Button();
                    btn.Image = arrBtn[i][j].Image;
                    btn.Size = new Size(h, w);
                    btn.Click += new EventHandler(btn_click_agent);
                    btn.Location = new Point(horizontal, vertical);
                    if (i == i1 && j == j1)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                    }
                    this.panel1.Controls.Add(btn);
                    horizontal += w;
                }
                vertical += h;
            }
            Console.WriteLine("draw");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            rotated = 0;
            btnline.Enabled = false;
            btnrotate.Enabled = false;
            btndown.Enabled = false;
            btnleft.Enabled = false;
            btnup.Enabled = false;
            btnright.Enabled = false;
            String url = txtEndpoint.Text + "/challenge/image/";
            String token = txtToken.Text;
            String para = txtIdchallenge.Text;
            String kq = layhinhdebai(url, para, token);
            //kq = JsonConvert.SerializeObject(kq, Formatting.Indented);
            JArray jarr = JArray.Parse(kq);
            
            int m = sohang, n = socot;
            int h = kichcoanh / m;
            int w = kichcoanh / n;
            panel1.AutoSize = true;
            panel1.Controls.Clear();
            int vertical = 0, horizontal = 0;
            int dem = 0;
            int i = 0, j = 0;
            for (i = 0; i < sohang; i++)
            {
                List<Button> horizontalBtn = new List<Button>();
                horizontal = 0;
                for (j = 1; j <= socot; j++)
                {
                    Button btn = new Button();
                    dem = 0;
                    foreach (var b64 in jarr)
                    {
                        dem++;
                        if (dem == (i * socot + j))
                        {
                            string b644 = b64.ToString();
                            btn.Image = Base64ToImage(b644);
                        }
                        

                    }
                    btn.Size = new Size(h, w);
                    btn.Click += new EventHandler(btn_click_agent);
                    horizontalBtn.Add(btn);
                    btn.Location = new Point(horizontal, vertical);
                    Console.Write("{0},{1}  ", horizontal, vertical);
                    this.panel1.Controls.Add(btn);
                    horizontal += w;
                    
                }
                vertical += h;
                this.arrBtn.Add(horizontalBtn);
                Console.WriteLine();
            }
            
            
            //MessageBox.Show(kq);
        }
        string toHex(int r)
        {
            string s = "0123456789ABCDEF";
            char[] c = s.ToCharArray();
            return c[r].ToString();
        }
        private void btn_click_agent(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            
            btnrotate.Enabled = true;
            btndown.Enabled = false;
            btnleft.Enabled = false;
            btnup.Enabled = false;
            btnright.Enabled = false;
            int x = btn.Location.X;
            int y = btn.Location.Y;
            int i = x / (kichcoanh / sohang);
            int j = y / (kichcoanh / sohang);
            int a = i_curr;
            int b = j_curr;
            i_curr = j;
            j_curr = i;
            if (rotated == 0&&check_click[i_curr,j_curr]!=1)
            {
                btnline.Enabled = true;
            }
            else
            {
                btnline.Enabled = false;
            }

            arrBtn[i_curr][j_curr].FlatStyle=FlatStyle.Flat;
            Console.WriteLine("\n Vi tri: {0}{1}",toHex(i),toHex(j));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idChallenge = txtIdchallenge.Text;
            var url = txtEndpoint.Text + "/solution/submit/" + idChallenge;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            string token = txtToken.Text;
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer "+token;
            httpRequest.ContentType = "text/plain";

            var data = lbresult.Text;
            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }
            string kq = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                kq = result;
            }
            MessageBox.Show(kq);
            Console.WriteLine(httpResponse.StatusCode);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            arrBtn[i_curr][j_curr].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            rotated = 1;
            rotate[i_curr * sohang + j_curr]++;
            btnline.Enabled = false;
            print_result();
            drawMap(i_curr,j_curr);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/round/";
            String token = txtToken.Text;
            String para = txtIdround.Text;
            String kq = methodGET(url, para, token);
            JObject jarr = JObject.Parse(kq);
            MessageBox.Show(jarr.ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/tournament/";
            String token = txtToken.Text;
            String para = txtIdtour.Text;
            String kq = methodGET(url, para, token);
            JObject jarr = JObject.Parse(kq);
            MessageBox.Show(jarr.ToString());

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/match/";
            String token = txtToken.Text;
            String para = txtIdmatch.Text;
            String kq = methodGET(url, para, token);
            JObject jarr = JObject.Parse(kq);
            MessageBox.Show(jarr.ToString());

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnline_Click(object sender, EventArgs e)
        {
            check_click[i_curr, j_curr] = 1;
            btndown.Enabled = true;
            btnleft.Enabled = true;
            btnup.Enabled = true;
            btnright.Enabled = true;
            if (move.Length > 0)
            {
                result_submit += "\n" + move.Length + "\n" + move;
            }
            result_submit += "\n" + toHex(j_curr) + toHex(i_curr) ;
            
            move = "";
            solanluachon++;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/solution/delete/";
            String token = txtToken.Text;
            String para = txtIdchallenge.Text;
            String kq = methodDELETE(url, para, token);
            MessageBox.Show(kq);
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (i_curr > 0)
            {
                swapButton(i_curr, j_curr, i_curr - 1, j_curr);
                i_curr = i_curr - 1;
            }
            else
            {
                swapButton(i_curr, j_curr, sohang-1, j_curr);
                i_curr = sohang-1;
            }
            move += "U";
            print_result();
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            if (j_curr > 0)
            {
                swapButton(i_curr, j_curr, i_curr, j_curr-1);
                j_curr = j_curr - 1;
            }
            else
            {
                swapButton(i_curr, j_curr, i_curr, socot-1);
                j_curr = socot-1;
            }

            move += "L";

            print_result();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (i_curr < sohang-1)
            {
                swapButton(i_curr, j_curr, i_curr + 1, j_curr);
                i_curr = i_curr + 1;
            }
            else
            {
                swapButton(i_curr, j_curr, 0, j_curr);
                i_curr = 0;
            }
            move += "D";
            print_result();
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            if (j_curr < socot-1)
            {
                swapButton(i_curr, j_curr, i_curr, j_curr + 1);
                j_curr = j_curr + 1;
            }
            else
            {
                swapButton(i_curr, j_curr, i_curr, 0);
                j_curr = 0;
            }
            move += "R";
            print_result();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            string idChallenge = txtIdchallenge.Text;
            var url = txtEndpoint.Text + "/solution/submit/" + idChallenge;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            string token = txtToken.Text;
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer " + token;
            httpRequest.ContentType = "text/plain";

            var data = lbresult.Text;
            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }
            string kq = "";
            
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                kq = result;
            }
            MessageBox.Show(kq);
            Console.WriteLine(httpResponse.StatusCode);
            //result_submit = "";
            //move = "";
            //lbresult.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result_submit = "";
            solanluachon = 0;
            move = "";
            lbresult.Text = "";
            rotated = 0;
            btnline.Enabled = false;
            btnrotate.Enabled = false;
            btndown.Enabled = false;
            btnleft.Enabled = false;
            btnup.Enabled = false;
            btnright.Enabled = false;
            String url = txtEndpoint.Text + "/challenge/image/";
            String token = txtToken.Text;
            String para = txtIdchallenge.Text;
            String kq = layhinhdebai(url, para, token);
            //kq = JsonConvert.SerializeObject(kq, Formatting.Indented);
            JArray jarr = JArray.Parse(kq);

            int m = sohang, n = socot;
            int h = kichcoanh / m;
            int w = kichcoanh / n;
            panel1.AutoSize = true;
            panel1.Controls.Clear();
            int vertical = 0, horizontal = 0;
            int dem = 0;
            int i = 0, j = 0;
            for (i = 0; i < sohang; i++)
            {
                List<Button> horizontalBtn = new List<Button>();
                horizontal = 0;
                for (j = 1; j <= socot; j++)
                {
                    check_click[i,j-1]= 0;
                    Button btn = new Button();
                    dem = 0;
                    foreach (var b64 in jarr)
                    {
                        dem++;
                        if (dem == (i * socot + j))
                        {
                            string b644 = b64.ToString();
                            btn.Image = Base64ToImage(b644);
                        }


                    }
                    btn.Size = new Size(h, w);
                    btn.Click += new EventHandler(btn_click_agent);
                    horizontalBtn.Add(btn);
                    btn.Location = new Point(horizontal, vertical);
                    Console.Write("{0},{1}  ", horizontal, vertical);
                    this.panel1.Controls.Add(btn);
                    horizontal += w;

                }
                vertical += h;
                this.arrBtn.Add(horizontalBtn);
                Console.WriteLine();
            }
        }

        private void txtEndpoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(txtEndpoint.Text);
        }

        private void txtEndpoint_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/challenge/raw-challenge/";
            String token = txtToken.Text;
            String para = txtIdchallenge.Text;
            String kq = "";
            String tmp = "";
            kq = laydebai(url, para, token);
            Console.WriteLine(kq);
            StreamWriter sw = new StreamWriter("PPMimg.ppm");
            sw.Write(kq);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String url = txtEndpoint.Text + "/solution/team/";
            String token = txtToken.Text;
            String para = txtIdchallenge.Text;
            String kq = methodGET(url, para, token);
            JArray jarr = JArray.Parse(kq);
            MessageBox.Show(jarr.ToString());
        }
    }
}
