using Microsoft.VisualBasic;
using System.Drawing.Imaging;

namespace RAWFileReader
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private static byte[] Convert16BitGrayScaleToRgb48(byte[] inBuffer, int width, int height)
        {
            int inBytesPerPixel = 2;
            int outBytesPerPixel = 6;

            byte[] outBuffer = new byte[width * height * outBytesPerPixel];
            int inStride = width * inBytesPerPixel;
            int outStride = width * outBytesPerPixel;

            // Step through the image by row
            for (int y = 0; y < height; y++)
            {
                // Step through the image by column
                for (int x = 0; x < width; x++)
                {
                    // Get inbuffer index and outbuffer index
                    int inIndex = (y * inStride) + (x * inBytesPerPixel);
                    int outIndex = (y * outStride) + (x * outBytesPerPixel);

                    byte hibyte = inBuffer[inIndex + 1];
                    byte lobyte = inBuffer[inIndex];

                    //R
                    outBuffer[outIndex] = lobyte;
                    outBuffer[outIndex + 1] = hibyte;

                    //G
                    outBuffer[outIndex + 2] = lobyte;
                    outBuffer[outIndex + 3] = hibyte;

                    //B
                    outBuffer[outIndex + 4] = lobyte;
                    outBuffer[outIndex + 5] = hibyte;
                }
            }
            return outBuffer;
        }

        private static Bitmap CreateBitmapFromBytes(byte[] pixelValues, int width, int height)
        {
            //Create an image that will hold the image data
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format48bppRgb);

            //Get a reference to the images pixel data
            Rectangle dimension = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData picData = bmp.LockBits(dimension, ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr pixelStartAddress = picData.Scan0;

            //Copy the pixel data into the bitmap structure
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, pixelStartAddress, pixelValues.Length);

            bmp.UnlockBits(picData);
            return bmp;
        }

        private void openRAWButton_Click(object sender, EventArgs e)
        {
            if(RAWopenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = RAWopenFileDialog.FileName;
                int width, height;
                Int32.TryParse(Interaction.InputBox("¬ведите ширину изображени€: "), out width);
                Int32.TryParse(Interaction.InputBox("¬ведите высоту изображени€: "), out height);
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    byte[] pixelValues = new byte[width * height * 2];
                    stream.Read(pixelValues, 0, width * height * 2);
                    var rgbData = Convert16BitGrayScaleToRgb48(pixelValues, width, height);
                    var bmp = CreateBitmapFromBytes(rgbData, width, height);

                    // display bitmap
                    RAWpictureBox.Image = bmp;
                }
            }
        }
    }
}