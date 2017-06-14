using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class TvShowRating
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int TvShowId { get; set; }
        public int RatingId { get; set; }
        public virtual ICollection<TvShow> TvShow { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}