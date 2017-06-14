using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class ProductionHouse
    {
        public int Id { get; set; }
        public string ProductionHouseName { get; set; }
        public bool IsActive { get; set; }

    }
}