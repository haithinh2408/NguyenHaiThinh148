using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHaiThinh148.Models
{
    public class NHT0148
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string NHTId { get; set; }
        [Required]
        [StringLength(50)]
        public string NHTName { get; set; }
        public bool NHTGender { get; set; }
    }
}
