using System;
using System.Collections.Generic;

namespace ZOI.BAL.Models
{
    public partial class TblBannerMasters
    {
        public int BannerId { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string BannerImage { get; set; }
        public string BannerImageUrl { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? Slots { get; set; }
        public string Category { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
