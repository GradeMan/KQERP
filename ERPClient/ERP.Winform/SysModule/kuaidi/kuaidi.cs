using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using COM.Domain;
using DevExpress.XtraEditors;
namespace ERP.Winform
{
    public partial class kuaidi : XtraForm
    {
        public kuaidi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "Database.xml";
            DataSet xmlread = new DataSet();
            xmlread.ReadXml(fileName);
            //cbKuaidi.DataSource = xmlread.Tables[0];
            List<InputItem> dataList = new List<InputItem>();
            foreach (DataRow row in xmlread.Tables[0].Rows)
            {
                InputItem item = new InputItem() { DisPlayName = row["com"].ToString(), Value = row["key"].ToString(), InputCode1 = Util.PinYin.GetCodstring(row["com"].ToString()) };
                dataList.Add(item);
            }
            ERPHelper.Instance.SetGridLookUpEdit(txtKuaiDiList,dataList,1);
            txtKuaiDiList.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(txtKuaiDiList_EditValueChanging);
            //cbKuaidi.ValueMember = "key";
            //cbKuaidi.DisplayMember = "com";
        }

        void txtKuaiDiList_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string com = txtKuaiDiList.EditValue.ToString(); //cbKuaidi.SelectedValue.ToString();
            string sn=txtSN.Text;
            string json = HttpRequstCommand.HttpGet("http://www.kuaidi100.com/query", "type=" + com + "&postid=" + sn);
            Dictionary<string,object> ht = JsonCommon.SelectDictionary(json);
            if (ht["status"].ToString() == "200")
            {
                ArrayList aList = new ArrayList();
                aList = (ArrayList)ht["data"];
                for (int i = 0; i < aList.Count; i++)
                {
                    Dictionary<string, object> di = (Dictionary<string, object>)aList[i];
                    txtResult.Text += "处理时间:" + di["time"] + "|" + di["context"]+"\r\n";
                }
            }
            else
            {
                txtResult.Text = "快递或单号错误";
            }

        }
    }
}
 