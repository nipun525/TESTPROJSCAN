﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TESTPROJSCAN.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HR_SYSEntities : DbContext
    {
        public HR_SYSEntities()
            : base("name=HR_SYSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeeDesignation> EmployeeDesignations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<PayrollHeader> PayrollHeaders { get; set; }
        public virtual DbSet<SysDepartment> SysDepartments { get; set; }
        public virtual DbSet<SysGender> SysGenders { get; set; }
        public virtual DbSet<SysHoliday> SysHolidays { get; set; }
        public virtual DbSet<UserAccessGranted> UserAccessGranteds { get; set; }
        public virtual DbSet<UserPasswordHistory> UserPasswordHistories { get; set; }
        public virtual DbSet<UserPermissionHistory> UserPermissionHistories { get; set; }
        public virtual DbSet<UserPermissionType> UserPermissionTypes { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserStatus> UserStatuses { get; set; }
    }
}
