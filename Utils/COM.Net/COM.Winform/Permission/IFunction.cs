using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM.Domain;
using System.Windows.Forms;
using System.Xml.Linq;
using ERP.Domain;


namespace COM.Winform
{
    public interface IFunction
    {
    
        /// <summary>
        /// 登陆用户所具有的单个模块功能集合
        /// </summary>
       // List<ToolBarCommand> ButtonList { get; set; }

        //加载工具栏模块
        void CreateToolBar(List<tb_Sys_Button> buttonList);

        void ShowDig(Form frmMain, string txtFrmName);

    }
}
