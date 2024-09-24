using DAL;
using System.Linq;

namespace BLL
{
    public class EmployeeRepository
    {
        private AttendanceContext context;

        public EmployeeRepository()
        {
            context = new AttendanceContext();
        }

        // Login method using hashed password
        public Employee? Login(string username, string password)
        {
            // Find employee by username and password
            var employee = context.Employees.FirstOrDefault(e => e.Username == username && e.Password == password);

            return employee; // Will return employee object which contains role
        }

        // Add Employee using Entity Framework (EF) for Registration
        // Add Employee using Entity Framework (EF) for Registration
        public void RegisterEmployee(string fullName, string username, string password, string role, string faceData)
        {
            byte[] faceDataBytes = Convert.FromBase64String(faceData);
            // Create a new employee entity
            var employee = new Employee
            {
                FullName = fullName,
                Username = username,
                Password = password,  // Store hashed password
                Role = role,
                FaceData = faceDataBytes // Assuming you have a FaceData field in your Employee class
            };

            // Add the new employee to the database
            context.Employees.Add(employee);
            context.SaveChanges(); // Save changes to persist the data
        }

        public bool ValidateFaceData(string username, string password, byte[] capturedFaceData)
        {
            // Ensure the employee is retrieved correctly
            var employee = context.Employees.FirstOrDefault(e => e.Username == username && e.Password == password);

            // Ensure the employee and FaceData are not null
            if (employee != null && employee.FaceData != null)
            {
                // Log the lengths for debugging
                Console.WriteLine($"Captured Face Data Length: {capturedFaceData.Length}");
                Console.WriteLine($"Stored Face Data Length: {employee.FaceData.Length}");

                // Perform a basic face data comparison (exact match)
                return capturedFaceData.SequenceEqual(employee.FaceData);
            }

            // Return false if either the employee or the FaceData is null
            return false;
        }
    }
}