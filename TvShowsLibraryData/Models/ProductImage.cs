using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}