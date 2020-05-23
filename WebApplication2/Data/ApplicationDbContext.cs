using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        //public DbSet<WebApplication2.Models.LeaveRequestVM> LeaveRequestVM { get; set; }
        //public DbSet<WebApplication2.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
        //public DbSet<WebApplication2.Models.EmployeeVM> EmployeeVM { get; set; }
        //public DbSet<WebApplication2.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        //public DbSet<WebApplication2.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }
    }
}
