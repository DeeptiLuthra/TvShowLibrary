using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvShowsLibraryData.Models
{
    public class PersonSkill
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int PersonId { get; set; }
        public int SkillId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Skill Skill { get; set; }
    }
}