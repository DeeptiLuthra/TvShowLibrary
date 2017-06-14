using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class PriceType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
    }
}