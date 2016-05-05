using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Runtime.InteropServices;
using ERP.Winform.Properties;

namespace ERP.Winform
{
    
      

    public partial class TianQiForm : Form
    {
        
        string myip,mycity;
        private double opacity = 0;//��¼��ǰ�����͸����   
        //ʵ���ޱ߿��ƶ�
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        //ʵ���ޱ߿��ƶ�

//ʵ��win7 aeroĥɰЧ��-------------------------------------------------------
        //[StructLayout(LayoutKind.Sequential)]
        //public struct MARGINS
        //{
        //    public int Left;
        //    public int Right;
        //    public int Top;
        //    public int Bottom;
        //}

        //[DllImport("dwmapi.dll", PreserveSig = false)]
        //static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        //[DllImport("dwmapi.dll", PreserveSig = false)]
        //static extern bool DwmIsCompositionEnabled();

        //protected override void OnLoad(EventArgs e)
        //{


        //    if (DwmIsCompositionEnabled())
        //    {
        //        MARGINS margins = new MARGINS();
        //        margins.Right = margins.Left = margins.Top = margins.Bottom = this.Width + this.Height;
        //        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        //    }
        //    base.OnLoad(e);
        //    GetIP();
        //    GetCityByIP(myip);
        //    DisplayWeather();


        //}

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //    if (DwmIsCompositionEnabled())
        //    {
        //        e.Graphics.Clear(Color.Black);
        //    }
        //}
//ʵ��win7 aeroĥɰЧ��-------------------------------------------------------
        public TianQiForm()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
               Opacity = 0;//ָ��������ȫ͸��   
               GetIP();
               GetCityByIP(myip);
               DisplayWeather();
        }

        protected void GetIP()
        {
            try
            {
                string strUrl = "http://www.ip138.com/ip2city.asp"; //���IP����ַ�� 
                Uri uri = new Uri(strUrl);
                System.Net.WebRequest wr = System.Net.WebRequest.Create(uri);
                System.IO.Stream s = wr.GetResponse().GetResponseStream();
                System.IO.StreamReader sr = new System.IO.StreamReader(s, Encoding.Default);
                string all = sr.ReadToEnd(); //��ȡ��վ������ 
                int i = all.IndexOf("[") + 1;
                int end = all.IndexOf("]");
                string tempip = all.Substring(i, end-i);
                string ip = tempip.Replace("]", "").Replace(" ", "");//�ҳ�i
                myip = ip;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        protected void GetCityByIP(string myip)
        {
            IPCity.IpAddressSearchWebServiceSoapClient city = new IPCity.IpAddressSearchWebServiceSoapClient("IpAddressSearchWebServiceSoap12");
            string[] ss = city.getCountryCityByIp(myip);
            int n = ss[1].IndexOf(' ');//�ո�����λ��
            int m = ss[1].IndexOf('ʡ');
            int x = n - m;
            mycity = ss[1].Substring(m+1,x-2);
           
        

        }
        protected void DisplayWeather()
        {


          //  webxml.WeatherWebServiceSoapClient w = new webxml.WeatherWebServiceSoapClient("WeatherWebServiceSoap1");
            //��webservice����һ����������  
            webxml.WeatherWebServiceSoapClient w = new webxml.WeatherWebServiceSoapClient("WeatherWebServiceSoap12");
            //string[] s = new string[23];//����string�����ŷ��ؽ��  
          
            var s = w.getWeatherbyCityName(mycity);
         
         
            if (s[8] == "")
            {
                MessageBox.Show("��ʱ��֧������ѯ�ĳ���");
            }
            else
            {

                string png = s[8].Substring(0, s[8].Length - 4);
                string png2 = s[15].Substring(0, s[15].Length - 4);
                string png3 = s[20].Substring(0, s[20].Length - 4);
                string path = Application.StartupPath;
                pictoday.Image = Image.FromFile(path+"\\images\\"+png+".png");
                pic1.Image = Image.FromFile(path + "\\images\\" + png + ".png");
                pic2.Image = Image.FromFile(path + "\\images\\" + png2 + ".png");
                pic3.Image = Image.FromFile(path + "\\images\\" + png3 + ".png");
                this.lbl1.Text = s[5].ToString();
                this.lbl2.Text = s[12].ToString();
                this.lbl3.Text = s[17].ToString();
                this.time.Text = s[4].ToString();
                this.address.Text = s[1].ToString();
                this.temperature.Text = s[5].ToString();
                this.label4.Text = s[6].Substring(s[6].IndexOf('��')+1).ToString();
                this.label5.Text = s[7].ToString();
                this.tempo1.Text = s[6].Substring(s[6].IndexOf('��')+1);
                this.tempo2.Text = s[13].Substring(s[13].IndexOf('��')+1);
                this.tempo3.Text = s[18].Substring(s[18].IndexOf('��')+1);
               

            }
        }
        //ʵ���ޱ߿��ƶ�
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             if (opacity <= 1)  
 
            {  
 
                opacity = opacity + 0.05;  
 
                Opacity = opacity;  
            }   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

    
    }
}