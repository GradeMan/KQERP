using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ERP.Winform
{
    public class PrintHelper
    {
        public static void Print(PivotGridControl pivotcontrol, string header, string watermark)
        {
            PrintingSystem printingSystem1 = new PrintingSystem();
            PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
            printingSystem1.Links.Add(printableComponentLink1);
            printableComponentLink1.Component = pivotcontrol;
            printableComponentLink1.Landscape = true;
            printableComponentLink1.ClearDocument();
            //设置纸张
            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printableComponentLink1.Margins.Bottom = 40;
            printableComponentLink1.Margins.Top = 80;
            printableComponentLink1.Margins.Right = 20;
            printableComponentLink1.Margins.Left = 20;
            //水印
            Watermark textWatermark = new Watermark();
            // Set watermark options.
            textWatermark.Text = watermark;
            textWatermark.TextDirection = DirectionMode.ForwardDiagonal;
            textWatermark.Font = new Font(textWatermark.Font.FontFamily, 40);
            textWatermark.ForeColor = Color.Red;
            textWatermark.TextTransparency = 150;
            textWatermark.ShowBehind = false;
            //textWatermark.PageRange = "1,3-5";
            printingSystem1.Watermark.CopyFrom(textWatermark);
            //设置页眉
            string leftColumn = "";
            string middleColumn = header;
            string rightColumn = "";
            string bottomleft = "打印时间:[已打印数据][打印耗时]";
            string bottommiddle = "第[页#]页";
            string bottomright = "";
            // Create a PageHeaderFooter object and initializing it with
            // the link's PageHeaderFooter.
            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
            // Clear the PageHeaderFooter's contents.
            //phf.Header.Content.Clear();
            // Add custom information to the link's header.
            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Footer.Content.AddRange(new string[] { bottomleft, bottommiddle, bottomright });
            phf.Header.LineAlignment = BrickAlignment.Near;
            printableComponentLink1.ShowPreview();
        }
        public static void Print(GridControl pivotcontrol, string header, string watermark)
        {
            PrintingSystem printingSystem1 = new PrintingSystem();
            PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
            printingSystem1.Links.Add(printableComponentLink1);
            printableComponentLink1.Component = pivotcontrol;
            printableComponentLink1.Landscape = true;
            printableComponentLink1.ClearDocument();
            //设置纸张
            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printableComponentLink1.Margins.Bottom = 40;
            printableComponentLink1.Margins.Top = 80;
            printableComponentLink1.Margins.Right = 20;
            printableComponentLink1.Margins.Left = 20;
            //水印
            Watermark textWatermark = new Watermark();
            // Set watermark options.
            textWatermark.Text = watermark;
            textWatermark.TextDirection = DirectionMode.ForwardDiagonal;
            textWatermark.Font = new Font(textWatermark.Font.FontFamily, 40);
            textWatermark.ForeColor = Color.Red;
            textWatermark.TextTransparency = 150;
            textWatermark.ShowBehind = false;
            //textWatermark.PageRange = "1,3-5";
            printingSystem1.Watermark.CopyFrom(textWatermark);
            //设置页眉
            string leftColumn = "";
            string middleColumn = header;
            string rightColumn = "";
            string bottomleft = "打印时间:[已打印数据][打印耗时]";
            string bottommiddle = "第[页#]页";
            string bottomright = "";
            // Create a PageHeaderFooter object and initializing it with
            // the link's PageHeaderFooter.
            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
            // Clear the PageHeaderFooter's contents.
            //phf.Header.Content.Clear();
            // Add custom information to the link's header.
            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            phf.Footer.Content.AddRange(new string[] { bottomleft, bottommiddle, bottomright });
            phf.Header.LineAlignment = BrickAlignment.Near;
            printableComponentLink1.ShowPreview();
        }
    }
}
