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
    /// Contains a list of WorkItems for a team.
    /// </summary>
    public class Backlog
    {
        [ForeignKey("Team")]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public Team Team { get; set; }

        public virtual ICollection<WorkItem> WorkItems { get; set; }
    }
}
