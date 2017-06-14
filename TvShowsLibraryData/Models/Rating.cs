using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int RatingNum { get; set; }
        public string RatingDescription { get; set; }
    }
}