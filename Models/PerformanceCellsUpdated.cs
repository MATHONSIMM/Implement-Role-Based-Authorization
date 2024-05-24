using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Implement_Role_Based_Authorization.Models
{
    public class PerformanceCellsUpdated
    {
        [Required]
        [StringLength(80)]
        [Unicode(false)]
        public string? PerformanceCell { get; set; }


        [StringLength(80)]
        [Unicode(false)]
        public string? SubPerformanceCell { get; set; }


        [StringLength(80)]
        [Unicode(false)]
        public string? SubSubPerformanceCell { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Division { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Subdivision { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Department { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Partner { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Class { get; set; }


        [StringLength(10)]
        [Unicode(false)]
        public string? Scheme { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Company { get; set; }


        [StringLength(20)]
        [Unicode(false)]
        public string? BusinessUnit { get; set; }


        [StringLength(4)]
        [Unicode(false)]
        public string? Years { get; set; }


        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Splits { get; set; }


        [Key]
        [Column("PCKey")]
        public int Pckey { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }


        [StringLength(20)]
        [Unicode(false)]
        public string? ModifiedUser { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? SubDivisionExclude { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? DepartmentExclude { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? PartnerExclude { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? ClassExclude { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? SchemeExclude { get; set; }
    }
}
