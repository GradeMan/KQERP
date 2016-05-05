using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Service;
using COM.Service;

namespace ERP.Winform.ESOP
{
    public partial class ESOPProductForm : ListForm
    {
        private IESOP_ProductService productService = Unity.Instance.GetService<IESOP_ProductService>();
        public ESOPProductForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.eSOPProductBindingSource.DataSource = productService.GetList();
        }
    }
}
