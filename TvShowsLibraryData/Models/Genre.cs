using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public bool IsActive { get; set; }
    }
}