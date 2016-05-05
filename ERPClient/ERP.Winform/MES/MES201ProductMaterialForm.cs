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

namespace ERP.Winform.MES
{
    public partial class MES201ProductMaterialForm : EditForm
    {
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private IMES_M201_Plan_MaterialService planMaterialService = Unity.Instance.GetService<IMES_M201_Plan_MaterialService>();
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private string planId;
        public MES201ProductMaterialForm(string planId)
        {
            InitializeComponent();
            this.planId = planId;
        }
        protected override void InitData()
        {
            var materialData = materialService.GetInputData();
            SetGridLookUpEdit(repositoryItemMaterial, materialData, 2);
            repositoryItemMaterial.DisplayMember = "Value";
            productMaterialViewModelBindingSource.DataSource = viewService.GetBOMMaterialView(planId);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridMaterial.CloseEditor();
                var materialViewModelList = this.productMaterialViewModelBindingSource.DataSource as List<ProductMaterialViewModel>;
                var materialList = new List<MES_M201_Plan_Material>();
                foreach (var material in materialViewModelList)
                {
                    MES_M201_Plan_Material model = new MES_M201_Plan_Material();
                    model.MatCode = material.MatCode;
                    model.PartNo = material.PartNo;
                    model.PlanDetailId = material.PlanDetailId;
                    model.PLNo = material.PLNo;
                    model.SuppCode = material.SuppCode;
                    model.Unit = material.Unit;
                    model.Qty = material.Qty??0;
                    model.UnitConsume = material.UnitConsume??0;
                    materialList.Add(model);
                }
                planMaterialService.Save(materialList);
                DialogResult = DialogResult.OK;
            }
            else if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;

        }

        private void repositoryItemMaterial_EditValueChanged(object sender, EventArgs e)
        {
            this.gridMaterial.CloseEditor();
            var model = this.productMaterialViewModelBindingSource.Current as ProductMaterialViewModel;
            if (model != null)
            {
                var material = materialService.GetMaterial().Where(a => a.MatCode == model.MatCode).FirstOrDefault() ?? new ERP_M001_Material();
                model.MatName = material.MatName;
                model.MatSpec = material.MatSpec;
                this.productMaterialViewModelBindingSource.ResetCurrentItem();
            }
        }
    }
}
