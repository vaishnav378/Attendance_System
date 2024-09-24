using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing; // For Bitmap
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Attendance_System
{
    public partial class CameraPreviewWindow : Window
    {
        private VideoCapture capture;
        private DispatcherTimer timer;

        public CameraPreviewWindow(Action<byte[]> onCapture)
        {
            InitializeComponent();
            capture = new VideoCapture(0); // Open the default camera

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(33); // ~30 FPS
            timer.Tick += (s, e) => ShowFrame();
            timer.Start();

            // Store the capture action
            CaptureAction = onCapture;
        }

        public Action<byte[]> CaptureAction { get; set; }

        private void ShowFrame()
        {
            using (var frame = new Mat())
            {
                capture.Read(frame);
                if (!frame.IsEmpty)
                {
                    cameraImage.Source = BitmapToImageSource(frame.ToBitmap()); // Use the conversion method
                }
            }
        }

        private void Capture_Click(object sender, RoutedEventArgs e)
        {
            using (var frame = new Mat())
            {
                capture.Read(frame);
                if (!frame.IsEmpty)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Convert Mat to Bitmap
                        var bitmap = frame.ToBitmap();
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        CaptureAction?.Invoke(ms.ToArray()); // Invoke the capture action with the image data
                    }
                }
            }
            Close();
        }

        private ImageSource BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                memoryStream.Position = 0;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad; // Load the bitmap into memory
                bitmapImage.EndInit();
                bitmapImage.Freeze(); // Make it cross-thread accessible
                return bitmapImage;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            timer.Stop();
            capture.Dispose();
            base.OnClosed(e);
        }
    }
}