﻿namespace EFCoreWithAsp.netCore.Models
{
    public class Department
    {
        public int DepartmentId { get; set; } //Primary Key
        public required string Name { get; set; }
    }
}