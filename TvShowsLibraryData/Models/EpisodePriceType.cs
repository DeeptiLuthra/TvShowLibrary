using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class EpisodePriceType
    {
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public int PriceTypeId { get; set; }
        public bool IsActive { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual PriceType PriceType { get; set; }

    }
}