using BLL;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing; // For Bitmap
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Attendance_System
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private EmployeeRepository employeeRepo;
        private VideoCapture capture;
        private Mat currentFrame;
        public RegisterWindow()
        {
            InitializeComponent();
            employeeRepo = new EmployeeRepository();
        }
        private byte[] faceData;
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            string email = txtEmail.Text;
            string role = ((ComboBoxItem)cbRole.SelectedItem)?.Content.ToString();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || faceData == null)
            {
                MessageBox.Show("Please fill out all required fields and capture your face.");
                return;
            }

            try
            {
                string base64FaceData = Convert.ToBase64String(faceData); // Convert byte array to Base64 string

                employeeRepo.RegisterEmployee(fullName, username, password, role, base64FaceData);
                MessageBox.Show("Employee registered successfully! You can now log in.");
                this.Close(); // Close registration window
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private byte[] CaptureFace()
        {
            try
            {
                capture = new VideoCapture(0); // Use default camera (index 0)
                currentFrame = new Mat();
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
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturing face: {ex.Message}");
                return null;
            }
        }

        private void CaptureFace_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var cameraWindow = new CameraPreviewWindow(faceData =>
                {
                    if (faceData != null)
                    {
                        MessageBox.Show("Face captured successfully!");
                        // You can store faceData here for later use in the registration
                        this.faceData = faceData; // Assuming you have a field to store face data
                    }
                    else
                    {
                        MessageBox.Show("Failed to capture face.");
                    }
                });
                cameraWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}