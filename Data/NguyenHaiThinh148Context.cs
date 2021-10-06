using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenHaiThinh148.Models;

namespace NguyenHaiThinh148.Data
{
    public class NguyenHaiThinh148Context : DbContext
    {
        public NguyenHaiThinh148Context (DbContextOptions<NguyenHaiThinh148Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenHaiThinh148.Models.PersonNHT148> PersonNHT148 { get; set; }

        public DbSet<NguyenHaiThinh148.Models.NHT0148> NHT0148 { get; set; }
    }
}
