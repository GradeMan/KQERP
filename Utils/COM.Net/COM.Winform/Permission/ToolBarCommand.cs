using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace COM.Winform
{
    public partial class ToolBarCommand : Component
    {
        //组件名字
        public string CommandId { get; set; }
        //组件中文名称
        public string CommandName { get; set; }
        //图片地址
        public string imagePath { get; set; }
        //是否可用
        public bool IsEnable { get; set; }
        //是否显示
        public bool IsVisible { get; set; }
        //组件定义
        public string M_Type { get; set; }
        //该组件的事件
        public event EventHandler OnCommandedEvent;

        public void OnCommand()
        {
            if (this.OnCommandedEvent != null)
                this.OnCommandedEvent(this, EventArgs.Empty);
        }
        public ToolBarCommand()
        {
            InitializeComponent();
        }

        public ToolBarCommand(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
