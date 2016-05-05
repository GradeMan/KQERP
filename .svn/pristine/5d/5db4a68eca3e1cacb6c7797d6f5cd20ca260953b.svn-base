using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System.IO;
using System.Drawing;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Filtering;
using System.Reflection;
using COM.Domain;
using System.Data;
using DevExpress.XtraGrid;
using System.Drawing.Imaging;
using O2S.Components.PDFRender4NET;

namespace ERP.Winform
{
    public enum ItemBindingType
    {
        Required,
        Phone,
        Upper
    }

    public partial class ERPHelper
    {
        private static ERPHelper instance;
        public static string IniFilePath = "D:\\MIS\\Project\\ESOP\\ESOP.INI";
        public static ERPHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ERPHelper();
                }
                return instance;
            }
        }

        public  void ApplyBindingSettings(LayoutControlItem item,ItemBindingType type)
        {
            switch (type)
            {
                case ItemBindingType.Required:
                        item.AllowHtmlStringInCaption = true;
                        item.Text = item.Text + " <color=red>*</color>";
                        break;
                case ItemBindingType.Phone:
                        ((TextEdit)item.Control).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                        ((TextEdit)item.Control).Properties.Mask.EditMask = "(999)0000-0000";
                        ((TextEdit)item.Control).Properties.Mask.UseMaskAsDisplayFormat = true;
                        break;
                case ItemBindingType.Upper:
                        ((TextEdit)item.Control).Properties.CharacterCasing = CharacterCasing.Upper;
                        break;
            }
            
        }
      
      

        #region 图片二进制转换
        public  byte[] ImageToBuffer(Image Images)
        {

            if (Images == null) { return null; }

            System.IO.MemoryStream Ms = new MemoryStream();
            Images.Save(Ms, Images.RawFormat);
            byte[] img = new byte[Ms.Length];
            Ms.Position = 0;
            Ms.Read(img, 0, Convert.ToInt32(Ms.Length));
            Ms.Close();
            return img;
        }
        public  Image BufferToImage(byte[] Buffer)
        {
            if (Buffer == null) return null;
            MemoryStream ms = new MemoryStream(Buffer);
            Image img = Image.FromStream(ms);
            return img;

        } 
        #endregion

        #region XtraMessageBox
        public bool MessageDel()
        {
            if (XtraMessageBox.Show("确定要删除选择的数据吗?", "系统提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                return true;
            else
                return false;
        }
        public bool MessageIf(string Msg)
        {
            if (XtraMessageBox.Show(Msg, "系统提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                return true;
            else
                return false;
        } 
        #endregion

        #region 有关gridview的操作设定
        //新增gridView列
        public  GridColumn AddGridColumns(string caption, string fieldName, bool visible)
        {
            GridColumn column = new GridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            return column;
        }
        public  void ykgridview_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                else if (e.RowHandle < 0 && e.RowHandle > -1000)
                {
                    e.Info.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle.ToString();
                }
            }
        }

        public void SetGridView(GridControl control)
        {
            control.UseEmbeddedNavigator = true;
            control.EmbeddedNavigator.Buttons.Append.Visible = false;
            control.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            control.EmbeddedNavigator.Buttons.Edit.Visible = false;
            control.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            control.EmbeddedNavigator.Buttons.Remove.Visible = false;
            control.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            GridView ykgridview = control.DefaultView as GridView;
            ykgridview.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(ykgridview_CustomDrawRowIndicator);
            ykgridview.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            ykgridview.OptionsView.ShowGroupPanel = false;
            ykgridview.OptionsFind.AlwaysVisible = true;
            ykgridview.IndicatorWidth = 40;
            ykgridview.OptionsView.ColumnAutoWidth = true;
            ykgridview.OptionsBehavior.ReadOnly = true;
        }
        #endregion

        #region 下拉菜单设置 + SetGridLookUpEdit(GridLookUpEdit ykgridLookUp, List<InputItem> listData, int inputitemCount)
        /// <summary>
        /// 设置GridLookUpEdit下拉列表
        /// </summary>
        /// <param name="ykgridLookUp"></param>
        /// <param name="listData">查询数据源</param>
        /// <param name="inputitemCount">记住码个数</param>
        public  void SetGridLookUpEdit(GridLookUpEdit ykgridLookUp, List<InputItem> listData, int inputitemCount,bool IsNewValue = true)
        {
            ykgridLookUp.Properties.View.Columns.Clear();
            ykgridLookUp.Properties.DataSource = listData;
            //初始化一些状态
            GridColumn col1 = ykgridLookUp.Properties.View.Columns.AddField("DisPlayName");
            col1.VisibleIndex = 0;
            col1.Caption = "描述";
            for (int i = 1; i <= inputitemCount; i++)
            {
                GridColumn col = ykgridLookUp.Properties.View.Columns.AddField("InputCode" + i);
                col.VisibleIndex = i;
                col.Caption = "记住码" + i;
            }
            ykgridLookUp.Properties.NullText = "";
            ykgridLookUp.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            ykgridLookUp.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            ykgridLookUp.Properties.View.BestFitColumns();
            ykgridLookUp.Properties.ShowFooter = false;
            ykgridLookUp.Properties.View.OptionsView.ShowAutoFilterRow = false;
            ykgridLookUp.Properties.AutoComplete = false;
            ykgridLookUp.Properties.ImmediatePopup = true;
            ykgridLookUp.Properties.PopupFilterMode = PopupFilterMode.Contains;
            ykgridLookUp.Properties.TextEditStyle = TextEditStyles.Standard;
            ykgridLookUp.Properties.DisplayMember = "DisPlayName";
            ykgridLookUp.Properties.ValueMember = "Value";
            ykgridLookUp.EditValueChanging += new ChangingEventHandler(ykgridLookUp_EditValueChanging);
            if (IsNewValue)
                ykgridLookUp.ProcessNewValue += new ProcessNewValueEventHandler(ykgridLookUp_ProcessNewValue);
        }
       
        
        /// <summary>
        /// 新的下拉菜单
        /// </summary>
        /// <param name="ykgridLookUp"></param>
        /// <param name="displayName"></param>
        /// <param name="valueName"></param>
        public virtual void SetGridLookUpEdit(RepositoryItemGridLookUpEdit ykgridLookUp, List<InputItem> listData, int inputitemCount = 1)
        {
            ykgridLookUp.View.Columns.Clear();
            ykgridLookUp.DataSource = listData.OrderBy(a => a.Value).ToList();
            //初始化一些状态
            GridColumn col1 = ykgridLookUp.View.Columns.AddField("DisPlayName");
            col1.VisibleIndex = 0;
            col1.Caption = "描述";
            for (int i = 1; i <= inputitemCount; i++)
            {
                GridColumn col = ykgridLookUp.View.Columns.AddField("InputCode" + i);
                col.VisibleIndex = i;
                col.Caption = "代号" + i;
            }
            ykgridLookUp.NullText = "";
            ykgridLookUp.View.OptionsBehavior.AutoPopulateColumns = false;
            ykgridLookUp.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            ykgridLookUp.View.BestFitColumns();
            ykgridLookUp.ShowFooter = true;
            ykgridLookUp.View.OptionsView.ShowAutoFilterRow = false;
            ykgridLookUp.AutoComplete = false;
            ykgridLookUp.ImmediatePopup = true;
            ykgridLookUp.PopupFilterMode = PopupFilterMode.Contains;
            ykgridLookUp.TextEditStyle = TextEditStyles.Standard;
            ykgridLookUp.DisplayMember = "DisPlayName";
            ykgridLookUp.ValueMember = "Value";
            ykgridLookUp.View.BestFitColumns();
            ykgridLookUp.BestFitMode = BestFitMode.BestFitResizePopup;
            ykgridLookUp.EditValueChanging += ykgridLookUp_EditValueChanging;

        }
        void ykgridLookUp_EditValueChanging(object sender, ChangingEventArgs e)
        {
            GridLookUpEdit ykgridLookUp = sender as GridLookUpEdit;
            ykgridLookUp.Invoke(new EventHandler(delegate
            {
                FilterLookup(sender);
            }));
        }

         void ykgridLookUp_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            GridLookUpEdit ykgridLookUp = sender as GridLookUpEdit;
            string displayName = ykgridLookUp.Properties.DisplayMember;
            string valueName = ykgridLookUp.Properties.ValueMember;
            string display = e.DisplayValue.ToString();

            List<InputItem> listData = ykgridLookUp.Properties.DataSource as List<InputItem>;
            if (listData != null)
            {
               
                int dataCount = listData.Where(i => i.DisPlayName == display).Count();
                if (dataCount == 0)
                {
                    InputItem item = new InputItem { DisPlayName = display, Value = display };
                    listData.Add(item);
                    ykgridLookUp.EditValue = display;
                }
            }
        }

        public  void FilterLookup(object sender)
        {
            GridLookUpEdit edit = sender as GridLookUpEdit;
            GridView gridView = edit.Properties.View as GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);
            BinaryOperator op1 = new BinaryOperator("InputCode1", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            BinaryOperator op2 = new BinaryOperator("InputCode2", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            BinaryOperator op3 = new BinaryOperator("InputCode3", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            //BinaryOperator op4 = new BinaryOperator("Value", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            string filterCondition = new GroupOperator(GroupOperatorType.Or, new CriteriaOperator[] { op1, op2, op3 }).ToString();
            fi.SetValue(gridView, filterCondition);

            MethodInfo mi = gridView.GetType().GetMethod("ApplyColumnsFilterEx", BindingFlags.NonPublic | BindingFlags.Instance);
            mi.Invoke(gridView, null);
        }

        public void SetReposGridLookUpEdit(RepositoryItemGridLookUpEdit ykgridLookUp, string displayName, string valueName)
        {
            ykgridLookUp.DisplayMember = displayName;
            ykgridLookUp.ValueMember = valueName;
            ykgridLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ykgridLookUp.ImmediatePopup = true;
            ykgridLookUp.View.OptionsView.ShowColumnHeaders = false;
            ykgridLookUp.NullText = "";
        }

        #endregion

        public static void DrawCheckBox
 (DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool chk)
        {
            RepositoryItemCheckEdit repositoryCheck =
e.Column.ColumnEdit as RepositoryItemCheckEdit;
            if (repositoryCheck != null)
            {
                Graphics g = e.Graphics;
                Rectangle r = e.Bounds;

                DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
                DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
                DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
                info = repositoryCheck.CreateViewInfo() as
DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;

                painter = repositoryCheck.CreatePainter()
as DevExpress.XtraEditors.Drawing.CheckEditPainter;
                info.EditValue = chk;
                info.Bounds = r;
                info.CalcViewInfo(g);
                args = new DevExpress.XtraEditors.
Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
                painter.Draw(args);
                args.Cache.Dispose();
            }
        }

        public static bool ClickGridCheckBox(
DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName, bool currentStatus)
        {
            bool result = false;
            if (gridView != null)
            {
                gridView.ClearSorting();//禁止排序 

                gridView.PostEditor();
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info;
                Point pt = gridView.GridControl.PointToClient(Control.MousePosition);
                info = gridView.CalcHitInfo(pt);
                if (info.InColumn && info.Column !=
null && info.Column.FieldName == fieldName)
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, fieldName, !currentStatus);
                    }
                    return true;
                }
            }
            return result;
        }

        #region PDF转换成图片保存 +ConvertPDF2Image
        public int ConvertPDF2Image(string pdfInputPath, string imageOutputPath,
          string imageName, int startPageNum, int endPageNum, ImageFormat imageFormat, Definition definition)
        {
            PDFFile pdfFile = PDFFile.Open(pdfInputPath);
            int fileCount = pdfFile.PageCount;
            if (!Directory.Exists(imageOutputPath))
            {
                Directory.CreateDirectory(imageOutputPath);
            }

            // validate pageNum
            if (startPageNum <= 0)
            {
                startPageNum = 1;
            }

            if (endPageNum > pdfFile.PageCount)
            {
                endPageNum = pdfFile.PageCount;
            }

            if (startPageNum > endPageNum)
            {
                int tempPageNum = startPageNum;
                startPageNum = endPageNum;
                endPageNum = startPageNum;
            }

            // start to convert each page
            for (int i = startPageNum; i <= pdfFile.PageCount; i++)
            {
                Bitmap pageImage = pdfFile.GetPageImage(i - 1, 56 * (int)definition);
                Bitmap pageImageNew = ZoomAuto(pageImage, 1280, 1024);//KiResizeImage(pageImage, 1280, 1024);
                pageImageNew.Save(imageOutputPath + "\\" + imageName + i.ToString() + "." + imageFormat.ToString(), imageFormat);
                pageImageNew.Dispose();
            }

            pdfFile.Dispose();
            return fileCount;
        }

        public Bitmap ZoomAuto(Bitmap initImage, System.Double targetWidth, System.Double targetHeight, string watermarkText = "", string watermarkImage = "")
        {
            //原始图片（获取原始图片创建对象，并使用流中嵌入的颜色管理信息）
            //System.Drawing.Image initImage = System.Drawing.Image.FromStream(postedFile.InputStream, true);

            //原图宽高均小于模版，不作处理，直接保存
            if (initImage.Width <= targetWidth && initImage.Height <= targetHeight)
            {
                //文字水印
                if (watermarkText != "")
                {
                    using (System.Drawing.Graphics gWater = System.Drawing.Graphics.FromImage(initImage))
                    {
                        System.Drawing.Font fontWater = new Font("黑体", 10);
                        System.Drawing.Brush brushWater = new SolidBrush(Color.White);
                        gWater.DrawString(watermarkText, fontWater, brushWater, 10, 10);
                        gWater.Dispose();
                    }
                }

                //透明图片水印
                if (watermarkImage != "")
                {
                    if (File.Exists(watermarkImage))
                    {
                        //获取水印图片
                        using (System.Drawing.Image wrImage = System.Drawing.Image.FromFile(watermarkImage))
                        {
                            //水印绘制条件：原始图片宽高均大于或等于水印图片
                            if (initImage.Width >= wrImage.Width && initImage.Height >= wrImage.Height)
                            {
                                Graphics gWater = Graphics.FromImage(initImage);

                                //透明属性
                                ImageAttributes imgAttributes = new ImageAttributes();
                                ColorMap colorMap = new ColorMap();
                                colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
                                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                                ColorMap[] remapTable = { colorMap };
                                imgAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

                                float[][] colorMatrixElements = { 
                                   new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  0.0f,  0.0f,  0.5f, 0.0f},//透明度:0.5
                                   new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
                                };

                                ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);
                                imgAttributes.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                                gWater.DrawImage(wrImage, new Rectangle(initImage.Width - wrImage.Width, initImage.Height - wrImage.Height, wrImage.Width, wrImage.Height), 0, 0, wrImage.Width, wrImage.Height, GraphicsUnit.Pixel, imgAttributes);

                                gWater.Dispose();
                            }
                            wrImage.Dispose();
                        }
                    }
                }

                //保存
                //initImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return initImage;
            }
            else
            {
                //缩略图宽、高计算
                double newWidth = initImage.Width;
                double newHeight = initImage.Height;

                //宽大于高或宽等于高（横图或正方）
                if (initImage.Width > initImage.Height || initImage.Width == initImage.Height)
                {
                    //如果宽大于模版
                    if (initImage.Width > targetWidth)
                    {
                        //宽按模版，高按比例缩放
                        newWidth = targetWidth;
                        newHeight = initImage.Height * (targetWidth / initImage.Width);
                    }
                }
                //高大于宽（竖图）
                else
                {
                    //如果高大于模版
                    if (initImage.Height > targetHeight)
                    {
                        //高按模版，宽按比例缩放
                        newHeight = targetHeight;
                        newWidth = initImage.Width * (targetHeight / initImage.Height);
                    }
                }

                //生成新图
                //新建一个bmp图片
                System.Drawing.Bitmap newImage = new System.Drawing.Bitmap((int)newWidth, (int)newHeight);
                //新建一个画板
                System.Drawing.Graphics newG = System.Drawing.Graphics.FromImage(newImage);

                //设置质量
                newG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                newG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                //置背景色
                newG.Clear(Color.White);
                //画图
                newG.DrawImage(initImage, new System.Drawing.Rectangle(0, 0, newImage.Width, newImage.Height), new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), System.Drawing.GraphicsUnit.Pixel);

                //文字水印
                if (watermarkText != "")
                {
                    using (System.Drawing.Graphics gWater = System.Drawing.Graphics.FromImage(newImage))
                    {
                        System.Drawing.Font fontWater = new Font("宋体", 10);
                        System.Drawing.Brush brushWater = new SolidBrush(Color.White);
                        gWater.DrawString(watermarkText, fontWater, brushWater, 10, 10);
                        gWater.Dispose();
                    }
                }

                //透明图片水印
                if (watermarkImage != "")
                {
                    if (File.Exists(watermarkImage))
                    {
                        //获取水印图片
                        using (System.Drawing.Image wrImage = System.Drawing.Image.FromFile(watermarkImage))
                        {
                            //水印绘制条件：原始图片宽高均大于或等于水印图片
                            if (newImage.Width >= wrImage.Width && newImage.Height >= wrImage.Height)
                            {
                                Graphics gWater = Graphics.FromImage(newImage);

                                //透明属性
                                ImageAttributes imgAttributes = new ImageAttributes();
                                ColorMap colorMap = new ColorMap();
                                colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
                                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                                ColorMap[] remapTable = { colorMap };
                                imgAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

                                float[][] colorMatrixElements = { 
                                   new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  0.0f,  0.0f,  0.5f, 0.0f},//透明度:0.5
                                   new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
                                };

                                ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);
                                imgAttributes.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                                gWater.DrawImage(wrImage, new Rectangle(newImage.Width - wrImage.Width, newImage.Height - wrImage.Height, wrImage.Width, wrImage.Height), 0, 0, wrImage.Width, wrImage.Height, GraphicsUnit.Pixel, imgAttributes);
                                gWater.Dispose();
                            }
                            wrImage.Dispose();
                        }
                    }
                }

                //保存缩略图
                //newImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                //释放资源
                newG.Dispose();
                //newImage.Dispose();
                initImage.Dispose();
                return newImage;
            }
        }

        #endregion

        
    }
    public enum Definition
    {
        One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10
    }
    

     
}
