using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TvShowId { get; set; }
        public int EpisodeId { get; set; }
        public int SeasonId { get; set; }
        public bool IsActive { get; set; }
        public virtual TvShow TvShow { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual Season Season { get; set; }
     }
}