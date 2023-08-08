﻿using HR.LeaveManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Domain
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Aproveed { get; set; }
        public bool Cancelled { get; set; }

    }
}
