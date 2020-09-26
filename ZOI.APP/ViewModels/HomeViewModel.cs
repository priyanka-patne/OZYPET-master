using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZOI.BAL.Models;

namespace ZOI.APP.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            BannerMaster = new List<TblBannerMasters>();
            EventMaster = new List<TblEventMaster>();
        }

        public List<TblBannerMasters> BannerMaster { get; set; }
        public List<TblEventMaster> EventMaster { get; set; }
    }
}
