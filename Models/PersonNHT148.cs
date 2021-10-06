using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHaiThinh148.Models
{
    public class PersonNHT148
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string PersonID { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}
