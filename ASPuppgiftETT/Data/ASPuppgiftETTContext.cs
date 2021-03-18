using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPuppgiftETT.Models;

namespace ASPuppgiftETT.Data
{
    public class ASPuppgiftETTContext : DbContext
    {
        public ASPuppgiftETTContext (DbContextOptions<ASPuppgiftETTContext> options)
            : base(options)
        {
        }

        public DbSet<ASPuppgiftETT.Models.Event> Event { get; set; }
    }
}
