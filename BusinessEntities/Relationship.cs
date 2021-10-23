using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
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

        [Required]
        public WorkItem MainItem { get; set; }

        [Required]
        public WorkItem RelatedItem { get; set; }

        [Required]
        public EType Type { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
