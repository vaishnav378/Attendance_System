using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AttendanceContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4TNUEJA;Initial Catalog=AttendanceDB;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasKey(a => a.Id); // Ensures that 'Id' is the primary key

            // Optional: You can specify column names if they differ from property names
            modelBuilder.Entity<Attendance>()
                .Property(a => a.Id)
                .HasColumnName("Id");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.EmployeeID)
                .HasColumnName("EmployeeID");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.ClockInTime)
                .HasColumnName("ClockInTime");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.ClockOutTime)
                .HasColumnName("ClockOutTime");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.Date)
                .HasColumnName("Date");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.Status)
                .HasColumnName("Status");
        }
    }
}