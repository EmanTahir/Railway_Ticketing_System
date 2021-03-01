using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTS_Term_Project.Models
{
    public class StationContext:DbContext
    {
        public StationContext(DbContextOptions<StationContext>options):base(options)
        {

        }
        public DbSet<Station> Station { set; get; }
    }
    

}
