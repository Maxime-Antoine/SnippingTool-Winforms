using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SnippingTool_Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnAreaSelected(object sender, EventArgs e)
        {
            var image = SnippingForm.Image;

            var maxImgHeight = 500;
            var maxImgWidth = 800;

            if (image.Width > maxImgWidth || image.Height > maxImgHeight)
            {
                pictureBox1.Image = ResizeImage(image, maxImgWidth, maxImgHeight);
            }
            else
            {
                pictureBox1.Image = image;
            }
        }

        private void SnaphotButton_Click(object sender, EventArgs e)
        {
            SnippingForm.AreaSelected += OnAreaSelected;
            SnippingForm.Snip();
        }

        private Image ResizeImage(Image image, int targetWidth, int targetHeight)
        {
            var scale = Math.Min((float)targetWidth / image.Width, (float)targetHeight / image.Height);

            var resizedImage = new Bitmap(targetWidth, targetHeight);
            var graph = Graphics.FromImage(resizedImage);

            graph.InterpolationMode = InterpolationMode.High;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var scaledWidth = image.Width * scale;
            var scaledHeight = image.Height * scale;

            var brush = new SolidBrush(Color.Black);
            graph.FillRectangle(brush, new RectangleF(0, 0, targetWidth, targetHeight));
            graph.DrawImage(image, (targetWidth - scaledWidth) / 2, (targetHeight - scaledHeight) / 2, scaledWidth, scaledHeight);

            return resizedImage;
        }
    }
}
