using System;
using System.Collections.Generic;

namespace ZOI.BAL.Models
{
    public partial class TblEventMaster
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventText { get; set; }
        public string EventDescription { get; set; }
        public string EventImage { get; set; }
        public string EventLocation { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public string EventTimeSlotFrom { get; set; }
        public string EventTimeSlotTo { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
