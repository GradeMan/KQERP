using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ERP.Winform.Hepler
{
    public class SerialPortHelper
    {
        public delegate void Display(string strRecieve);
        public event Display OnRecieveSerialMsg;
        SerialPort mycom;
        public void OpenSerialPort(string portName, int baudRate)
        {
            try
            {

                mycom = new SerialPort();
                mycom.PortName = portName;
                mycom.BaudRate = baudRate;
                mycom.Parity = Parity.None;//无奇偶校验位
                mycom.StopBits = StopBits.Two;//两个停止位
                mycom.Handshake = Handshake.RequestToSend;//控制协议
                mycom.ReceivedBytesThreshold = 4;//设置 DataReceived 事件发生前内部输入缓冲区中的字节数
                mycom.DataReceived += new SerialDataReceivedEventHandler(comport_DataReceived);//DataReceived事件委托
                mycom.Open();
                //mycom.WriteLine("发送了一条数据");
            }
            catch (Exception ef)
            {
                if (!mycom.IsOpen)
                {
                    XtraMessageBox.Show(ef.Message);
                }
            }
            ////获取INI文件里的COM设置
            //string path = "D:\\MIS\\Project\\KQMIS\\KQMISUser.INI";
            //if (File.Exists(path))
            //{
            //    string[] setarray;
            //    INIFile inifile = new INIFile(path);
            //    string comsetting = inifile.IniReadValue("ComSetting", "setting");
            //    setarray = comsetting.Split(',');
            //}
            //else
            //    throw new ApplicationException("COM口配置文件不存在，请检查");
        }
        public void CloseSerialPort()
        {
            mycom.Close();
        }
        private void comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Byte[] buffer = new Byte[1024];

            Int32 length = (sender as SerialPort).Read(buffer, 0, buffer.Length);

            Array.Resize(ref buffer, length);

            string strRecieve = System.Text.Encoding.UTF8.GetString(buffer);
            if (OnRecieveSerialMsg != null)
                OnRecieveSerialMsg(strRecieve);

            //this.Invoke(d, new Object[] { buffer });
        }
    }
}
