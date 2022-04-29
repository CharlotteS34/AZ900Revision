using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZ9000Revision.Database.Entities
{
    public class RevisionPoint
    {
        [Key]
        public int RevisionPointId { get; set; }
        public string RevisionPointDescription { get; set; }
        [ForeignKey(nameof(Topic))]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}