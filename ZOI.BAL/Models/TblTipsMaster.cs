using System;
using System.Collections.Generic;

namespace ZOI.BAL.Models
{
    public partial class TblTipsMaster
    {
        public int TipId { get; set; }
        public string TipTitle { get; set; }
        public string TipText { get; set; }
        public string TipDescription { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
