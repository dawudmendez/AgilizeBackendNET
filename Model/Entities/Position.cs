using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Position
    {
        /// <summary>
        /// It represents a specific position that can be only inside a team.
        /// It is the matching between a person and a role for a specific team.
        /// </summary>
        public enum ERole
        {
            SM,
            PO,
            DEV,
            QA,
            DBA
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public ERole Role { get; set; }

        [Required]
        public Person Person { get; set; }

        public virtual ICollection<WorkItem> WorkItems { get; set; }

        public virtual Team Team { get; set; }
    }
}
