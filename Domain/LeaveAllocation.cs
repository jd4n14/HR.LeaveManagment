using HR.LeaveManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfdays { get; set; }
        
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
