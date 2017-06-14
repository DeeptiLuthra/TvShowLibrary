using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class TvShowProductionHouse
    {
        public int Id { get; set; }
        public int TvShowId { get; set; }
        public int ProductionHouseId { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TvShow> TvShow { get; set; }
        public virtual ICollection<ProductionHouse> ProductionHouse { get; set; }

    }
}