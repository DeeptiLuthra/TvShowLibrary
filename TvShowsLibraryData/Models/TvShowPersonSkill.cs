using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class TvShowPersonSkill
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int PersonId { get; set; }
        public int SkillId { get; set; }
        public int TvShowId { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<TvShow> TvShow { get; set; }
    }
}