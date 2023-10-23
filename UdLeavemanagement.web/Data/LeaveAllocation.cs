using System.ComponentModel.DataAnnotations.Schema;

namespace UdLeavemanagement.web.Data
{
    public class LeaveAllocation:BaseEntity
    {
        public int Id { get; set; }
        public int NumberofDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public string EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public int LeaveTypeId {  get; set; }

    }
}
