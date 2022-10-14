using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VrundRug.Models;


namespace VrundRug.Data
{
    public class VrundRugContext : DbContext
    {
        public VrundRugContext(DbContextOptions<VrundRugContext> options)
            : base(options)
        {
        }
        public DbSet<VrundRug.Models.Rug> Rug { get; set; }
    }
}
