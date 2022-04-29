using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZ9000Revision.Database.Entities
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        [ForeignKey(nameof(Module))]
        public int ModuleId { get; set; }
        public Module Module { get; set; }
        public ICollection<RevisionPoint> RevisionPoints { get; set; }
    }
}