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
    /// It's a period of time were work is produced.
    /// Associated with a team.
    /// </summary>
    public class Sprint
    {
        public enum EType
        {
            Innovation,
            Development
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(4000)]
        public int Description { get; set; }

        [Required]
        public EType Type { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Goal { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public Team Team { get; set; }
    }
}
