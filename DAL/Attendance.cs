using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Attendance
    {
        public int Id { get; set; } // Ensure this matches your database column name
        public int EmployeeID { get; set; }
        public DateTime ClockInTime { get; set; }
        public DateTime? ClockOutTime { get; set; } // Nullable for cases where clock-out has not occurred
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
