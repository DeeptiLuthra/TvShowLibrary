using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string SkillName { get; set; }
    }
}