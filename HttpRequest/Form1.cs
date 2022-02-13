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
        private List<List<Button>> arrBtn;
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
            String url = "http://112.137.129.202/tournament/";
            String token = txtToken.Text;
            String para = "";
            String kq = methodGET(url, para, token);
            JArray jarr = JArray.Parse(kq);
            MessageBox.Show(jarr.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            String url = "http://112.137.129.202/challenge/raw/";
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
            solanluachontoida = int.Parse(list[3]);
            chiphiluachon = int.Parse(list[4]);
            chiphihoandoi = int.Parse(list[5]);
            kichcoanh = int.Parse(list[6]);
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
        
        private void button3_Click(object sender, EventArgs e)
        {
            String url = "http://112.137.129.202/challenge/image/";
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
            this.arrBtn = new List<List<Button>>();
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
                    btn.Location = new Point(horizontal, vertical);
                    this.panel1.Controls.Add(btn);
                    horizontal += w;
                }
                vertical += h;

            }
            
            
            //MessageBox.Show(kq);
        }
        private void btn_click_agent(object sender, EventArgs e)
        {
            Button btn = sender as Button;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idChallenge = txtIdchallenge.Text;
            var url = "http://112.137.129.202/solution/submit/"+idChallenge;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            string token = txtToken.Text;
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer "+token;
            httpRequest.ContentType = "text/plain";

            var data = @"0000000100000000
0";
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

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String url = "http://112.137.129.202/round/";
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
            String url = "http://112.137.129.202/tournament/";
            String token = txtToken.Text;
            String para = txtIdtour.Text;
            String kq = methodGET(url, para, token);
            JObject jarr = JObject.Parse(kq);
            MessageBox.Show(jarr.ToString());

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String url = "http://112.137.129.202/match/";
            String token = txtToken.Text;
            String para = txtIdmatch.Text;
            String kq = methodGET(url, para, token);
            JObject jarr = JObject.Parse(kq);
            MessageBox.Show(jarr.ToString());

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
