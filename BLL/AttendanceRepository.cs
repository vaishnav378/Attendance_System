using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AttendanceRepository
    {
        private AttendanceContext context;

        public AttendanceRepository()
        {
            context = new AttendanceContext();
        }

        public void ClockIn(int employeeId)
        {
            var attendance = new Attendance
            {
                EmployeeID = employeeId,
                ClockInTime = DateTime.Now,
                Date = DateTime.Now.Date,
                Status = "Present"
            };
            context.Attendances.Add(attendance);
            context.SaveChanges();
        }

        public void ClockOut(int employeeId)
        {
            var attendance = context.Attendances
                .Where(a => a.EmployeeID == employeeId && a.Date == DateTime.Now.Date && a.ClockOutTime == null)
                .FirstOrDefault();
            if (attendance != null)
            {
                attendance.ClockOutTime = DateTime.Now;
                context.SaveChanges();
            }
        }

        public List<Attendance> GetAttendanceByEmployee(int employeeId, string role)
        {
            if (role == "Admin")
            {
                // Admin can see all employee attendance records
                return context.Attendances.ToList();
            }
            else
            {
                // Non-admin (employee) can see only their own attendance records
                return context.Attendances.Where(a => a.EmployeeID == employeeId).ToList();
            }
        }
    }
}