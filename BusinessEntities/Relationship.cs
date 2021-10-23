using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    /// <summary>
    /// Represents a relationship between two Work Items.
    /// </summary>
    public class Relationship
    {
        public enum EType
        {
            RelatesTo,
            IsChildOf,
            DependsOn,
            IsBlockedBy
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int MainItemId { get; set; }
        public WorkItem MainItem { get; set; }

        public int RelatedItemId { get; set; }
        public WorkItem RelatedItem { get; set; }


        [Required]
        public EType Type { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
