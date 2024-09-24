using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Attendence_System
{
    public partial class DashboardWindow : Window
    {
        private Employee currentEmployee;
        private AttendanceRepository attendanceRepo = new AttendanceRepository();

        public DashboardWindow(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;
            SetWelcomeMessage();
        }

        private void SetWelcomeMessage()
        {
            WelcomeLabel.Content = $"Welcome, {currentEmployee.FullName}";
        }
        private void LoadAttendanceHistory()
        {
            try
            {
                var attendanceData = attendanceRepo.GetAttendanceByEmployee(currentEmployee.EmployeeID, currentEmployee.Role);
                AttendanceGrid.ItemsSource = attendanceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading attendance history: {ex.Message}");
            }
        }

        private void ClockIn_Click(object sender, RoutedEventArgs e)
        {
            attendanceRepo.ClockIn(currentEmployee.EmployeeID);
            MessageBox.Show("Clocked in successfully!");
            LoadAttendanceHistory();
        }

        private void ClockOut_Click(object sender, RoutedEventArgs e)
        {
            attendanceRepo.ClockOut(currentEmployee.EmployeeID);
            MessageBox.Show("Clocked out successfully!");
            LoadAttendanceHistory();
        }

        private void ViewAttendance_Click(object sender, RoutedEventArgs e)
        {
            if (AttendanceGrid.Visibility == Visibility.Collapsed)
            {
                // Load attendance data and show the grid
                LoadAttendanceHistory();
                AttendanceGrid.Visibility = Visibility.Visible;
            }
            else
            {
                // Hide the grid if it is already visible
                AttendanceGrid.Visibility = Visibility.Collapsed;
            }
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Show the Login window
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();

            // Close the Dashboard window
            this.Close();
        }


    }
}
