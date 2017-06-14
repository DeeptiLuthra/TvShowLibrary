using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class Season
    {
        public int Id { get; set; }

        public int TvShowId { get; set; }

        public int SeasonNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual TvShow TvShow { get; set; }
    }
}