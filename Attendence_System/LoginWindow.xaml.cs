using Attendance_System;
using BLL;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Attendence_System
{
    public partial class LoginWindow : Window
    {
        private EmployeeRepository employeeRepo;

        public LoginWindow()
        {
            InitializeComponent();
            employeeRepo = new EmployeeRepository();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var employee = employeeRepo.Login(UsernameTextBox.Text, PasswordBox.Password);

            if (employee != null)
            {
                var dashboard = new DashboardWindow(employee);
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login details!");
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }

        private void CaptureAndLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Perform basic login with username and password
                var employee = employeeRepo.Login(UsernameTextBox.Text, PasswordBox.Password);

                if (employee != null)
                {
                    // Login successful, now proceed with face validation
                    try
                    {
                        using (VideoCapture capture = new VideoCapture(0)) // Use default camera (index 0)
                        {
                            using (Mat currentFrame = new Mat())
                            {
                                capture.Read(currentFrame); // Capture the frame into Mat

                                if (!currentFrame.IsEmpty)
                                {
                                    // Convert Mat to Bitmap and display it in the Image control
                                    Bitmap bitmap = currentFrame.ToBitmap();
                                    CameraPreview.Source = BitmapToImageSource(bitmap); // Display on UI

                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        byte[] capturedFaceData = ms.ToArray();

                                        // Validate the face data using the updated method
                                        bool isFaceValid = employeeRepo.ValidateFaceData(UsernameTextBox.Text, PasswordBox.Password, capturedFaceData);

                                        if (isFaceValid)
                                        {
                                            MessageBox.Show("Login and face validation successful!");
                                            var dashboard = new DashboardWindow(employee);
                                            dashboard.Show();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Face validation failed!");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to capture face data from camera.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during face validation: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
        }



        // Helper function to convert Bitmap to ImageSource for WPF Image control
        private BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }

        private byte[] CaptureFace()
        {
            try
            {
                using (VideoCapture capture = new VideoCapture(0)) // Use default camera (index 0)
                {
                    using (Mat currentFrame = new Mat())
                    {
                        capture.Read(currentFrame); // Capture the frame into Mat

                        if (!currentFrame.IsEmpty)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                // Convert Mat to Bitmap
                                Bitmap bitmap = currentFrame.ToBitmap();
                                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                return ms.ToArray(); // Convert the captured image to byte[]
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturing face: {ex.Message}");
                return null;
            }
        }
    }
}