using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class Image
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public byte[] ImageBytes { get; set; }
        public string Encoding { get; set; }
        public string ImageData => $"data:{Encoding};base64,{Convert.ToBase64String(ImageBytes)}";

    }
}