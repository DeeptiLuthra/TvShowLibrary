using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class TvShowGenre
    {
        public int Id { get; set; }
        public int TvShowId { get; set; }
        public int GenreId { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<TvShow> TvShow { get; set; }
        public virtual ICollection<Genre> Genre { get; set; }

    }
}