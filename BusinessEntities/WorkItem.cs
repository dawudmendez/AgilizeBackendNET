using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class WorkItem
    {
        public enum EType
        {
            Epic,
            Feature,
            Story,
            Bug,
            Spike,
            Task
        }

        public enum EStatus
        {
            Open,
            OnHold,
            Closed,
            Abandoned
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Description { get; set; }

        [Required]
        public EType ItemType { get; set; }

        public Position Assignment { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public EStatus Status { get; set; }

        [Required]
        public DateTime StatusDate { get; set; }

        public DateTime SprintStart { get; set; }

        public DateTime SprintEnd { get; set; }

        public Backlog Backlog { get; set; }

        public virtual ICollection<Relationship> RelationshipsSource { get; set; }

        public virtual ICollection<Relationship> RelationshipsDestination { get; set; }
    }
}
