using System;
using System.Collections.Generic;

namespace ZOI.BAL.Models
{
    public partial class TblOzyPetServices
    {
        public int PetServiceId { get; set; }
        public string PetServiceName { get; set; }
        public string PetServiceText { get; set; }
        public string PetServiceDescription { get; set; }
        public string PetServiceImage { get; set; }
        public string PetServiceImageUrl { get; set; }
        public int? Sequence { get; set; }
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
