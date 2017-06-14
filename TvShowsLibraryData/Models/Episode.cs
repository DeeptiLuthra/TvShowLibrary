using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvShowsLibraryData.Models;

namespace TvShowsLibraryData.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsActive { get; set; }

        public virtual Season Season { get; set; }
    }
}