using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AZ9000Revision.Database.Entities
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
