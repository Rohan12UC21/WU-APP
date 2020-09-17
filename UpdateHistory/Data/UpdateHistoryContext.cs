using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;

namespace UpdateHistory.Models
{
    public class UpdateHistoryContext : DbContext
    {
        public UpdateHistoryContext (DbContextOptions<UpdateHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<UpdateHistory.Models.Info> Info { get; set; }

        public DbSet<UpdateHistory.Models.Server> Server { get; set; }
    }
}
