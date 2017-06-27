using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PrintRecipt
{
    public partial class print : Form
    {
        public Bitmap memoryImage;
        public print()
        {
            InitializeComponent();
        }

        private void print_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.name1;
            label5.Text = Form1.name2;


            captureScreen();

            PdfDocument doc = new PdfDocument();

            PdfPage oPage = new PdfPage();

            doc.Pages.Add(oPage);
            oPage.Rotate = 90;
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"G://app//Rectangle.png");

            xgr.DrawImage(img, 0, 0);

            doc.Save("G://app//"+Form1.name1+".pdf");
            doc.Close();
            MessageBox.Show("Pdf Generated !");
            this.Close();

        }
        private void captureScreen()
        {
            try
            {
                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                    bmp.Save(@"G://app/" + Form1.name1 + ".png", ImageFormat.Png); // make sure path exists!
                }
                //Rectangle bounds = this.Bounds;
                //using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                //{
                //    using (Graphics g = Graphics.FromImage(bitmap))
                //    {
                //        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size, CopyPixelOperation.SourceCopy);
                //    }
                //    bitmap.Save("G://app/Rectangle.png", ImageFormat.Png);
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
