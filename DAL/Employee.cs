using System;

namespace DAL
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin or Employee
        public byte[] FaceData { get; set; }
    }
}