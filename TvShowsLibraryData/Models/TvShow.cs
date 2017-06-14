using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Description { get; set; }

        public int AverageRating { get; set; }

        public bool IsActive { get; set; }

    }
}