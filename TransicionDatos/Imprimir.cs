using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace TransicionDatos
{
    public class Imprimir
    {
        DataGridViewPrinter MyDataGridViewPrinter;
        public void Impresionlandscape(PrintDocument p, PrintPageEventArgs e, String Colegio, String Titulo)
        {
            p.DefaultPageSettings.Landscape = true;
            
            Pen myPen = new Pen(System.Drawing.Color.Black, 2);
            //Bitmap bmp = Properties.Resources.Logo01NC;
            //Image newImage = bmp;
            //e.Graphics.DrawImage(newImage, 870, 20, newImage.Width, newImage.Height);
            e.Graphics.DrawString(Colegio, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(60, 20));
            e.Graphics.DrawString(Titulo, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(60, 70));
            e.Graphics.DrawLine(myPen, 65, 97, 170, 97);
            myPen.Dispose();
            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(60, 110));


            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        public void Impresion(PrintDocument p, PrintPageEventArgs e, String Colegio, String Titulo)
        {
            if (p.DefaultPageSettings.Landscape == true)
            {
                Pen myPen = new Pen(System.Drawing.Color.Black,2);
                //Bitmap bmp = Properties.Resources.Logo01NC;
                //Image newImage = bmp;
                //e.Graphics.DrawImage(newImage, 870, 20, newImage.Width, newImage.Height);
                e.Graphics.DrawString(Colegio, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(60, 20));
                e.Graphics.DrawString(Titulo, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(60, 70));
                e.Graphics.DrawLine(myPen, 65, 97, 170, 97);
                myPen.Dispose();
                e.Graphics.DrawString(DateTime.Now.ToLongDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(60, 110));
            }
            else
            {
                Pen myPen = new Pen(System.Drawing.Color.Black,2);
                //Bitmap bmp = Properties.Resources.Logo02NC;
                //Image newImage = bmp;
                //e.Graphics.DrawImage(newImage, 525, 25, newImage.Width, newImage.Height);
                e.Graphics.DrawString(Colegio, new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(60, 25));
                e.Graphics.DrawString(Titulo, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(60, 80));
                e.Graphics.DrawLine(myPen, 65, 115, 200, 115);
                myPen.Dispose();
                e.Graphics.DrawString(DateTime.Now.ToLongDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(60, 125));
            }

            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        public bool SetupThePrinting(PrintDocument p, DataGridView dg, String Titulo, String Documento)
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            p.DocumentName = Documento;
            p.PrinterSettings = MyPrintDialog.PrinterSettings;
            p.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            if (p.DefaultPageSettings.Landscape == true)
                p.DefaultPageSettings.Margins = new Margins(40, 40, 150, 40);
            else
                p.DefaultPageSettings.Margins = new Margins(40, 40, 160, 40);

            p.PrinterSettings.CreateMeasurementGraphics();
            if (MessageBox.Show("Desea que el reporte sea centrado a la página", "Administrador de impresión - Centrado de página", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MyDataGridViewPrinter = new DataGridViewPrinter(dg, p, true, true, Titulo, new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            else
                MyDataGridViewPrinter = new DataGridViewPrinter(dg, p, false, true, Titulo, new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            return true;
        }

    }
}
