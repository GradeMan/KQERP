using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Domain;
using System.Net.Sockets;
using DevExpress.XtraEditors;
using Util;

namespace ERP.Winform.ESOP
{
    public partial class ESOPPublishForm : ListForm
    {
        private IESOP_PublishService publishService = Unity.Instance.GetService<IESOP_PublishService>();
        private IESOP_DeviceService deviceService = Unity.Instance.GetService<IESOP_DeviceService>();
        private IESOP_DocIndexService docIndexServer = Unity.Instance.GetService<IESOP_DocIndexService>();
        private IESOP_DocService docServer = Unity.Instance.GetService<IESOP_DocService>();
        public TcpClient tcpClient = new TcpClient();
        public NetworkStream netStream;
        public ESOPPublishForm()
        {
            InitializeComponent();
        }

        public override void  OnAttachEvent()
        {
            var deviceData = deviceService.GetDevice().Select(a => new InputItem { DisPlayName = a.DevName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(repositoryItemDevId, deviceData, 0);
            this.repositoryItemDevId.ValueMember = "Value2";
            var docIndexData = docIndexServer.GetDocIndex().Select(a => new InputItem { DisPlayName = a.DocIndexName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(repositoryItemDocIndexId, docIndexData, 0);
            this.repositoryItemDocIndexId.ValueMember = "Value2";
            var docData = docServer.GetDoc().Select(a => new InputItem { DisPlayName = a.DocName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(repositoryItemDocId, docData, 0);
            repositoryItemDocId.ValueMember = "Value2";
        }
        public override void InitData()
        {
            this.eSOPPublishBindingSource.DataSource = publishService.GetList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eSOPPublishBindingSource.AddNew();
                ESOP_Publish temp = eSOPPublishBindingSource.Current as ESOP_Publish;
                EditForm("产品资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("产品资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ESOP_Publish temp = eSOPPublishBindingSource.Current as ESOP_Publish;
                    publishService.Delete(temp.Id);
                    eSOPPublishViewModelBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.PublishTask)
            {
                if (gridView1.SelectedRowsCount <= 0)
                    throw new ApplicationException("请先选择需要发送的文件");
                var publishTasks = this.eSOPPublishBindingSource.DataSource as List<ESOP_Publish>;
                if (!tcpClient.Connected)
                {
                    INIFile inifile = new INIFile(ERPHelper.IniFilePath);
                    string serverIP = inifile.IniReadValue("TCPSetting", "ServerIP");
                    int port = Int32.Parse(inifile.IniReadValue("TCPSetting", "Port"));
                    //string serverIP = app.AppConfigGet("ServerIP");
                    //int port = Int32.Parse(app.AppConfigGet("Port"));
                    tcpClient = new TcpClient();
                    tcpClient.Connect(serverIP, port);
                    //tcpClient = new TcpClient();

                    netStream = tcpClient.GetStream();//取得网络流                
                    //Thread thread = new Thread(new ThreadStart(receiveData));//创建接收线程
                    // thread.Start();//启动接收线程，死循环接收数据
                }
                foreach (var publishTask in publishTasks)
                {
                    byte[] msg = new byte[256];
                    string message = "send:" + publishTask.Id + "," + publishTask.DevId + "\r\n";
                    msg = System.Text.Encoding.UTF8.GetBytes(message);
                    netStream.Write(msg, 0, msg.Length);
                }
                XtraMessageBox.Show("发送成功");
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            ESOP_Publish temp = this.eSOPPublishBindingSource.Current as ESOP_Publish;
            ESOPPublishEditForm edit = new ESOPPublishEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                eSOPPublishBindingSource.CancelEdit();
            }
            else
            {
                OnAttachEvent();
            }
        }
    }
}
