﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementLeaveAppCoreMVC6.Data
{
    public class LeaveAllocation: BaseEntity
    {
        public int NumberOfDays { get; set; } // It has Number of Days
        [ForeignKey("LeaveTypeId")] 
        //FKey pointing to the LeaveType for which, this allocation is being made
        public LeaveType LeaveType { get; set; } 
        public int LeaveTypeId { get; set; } 
        // We have the employee to whom the allocation is being made
        public string EmployeeId { get; set; }
    }
}
