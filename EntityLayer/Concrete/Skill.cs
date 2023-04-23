using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }    
        public string Description { get; set; }
        [StringLength(50)]

        public string ImageUrl { get; set; }
        [StringLength(50)]

        public string Skill1 { get; set; }
        [StringLength(50)]
        public string Skill2 { get; set; }
        [StringLength(50)]
        public string Skill3 { get; set; }
        [StringLength(50)]
        public string Skill4 { get; set; }

    }
}
