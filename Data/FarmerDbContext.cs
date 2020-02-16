using FarmerSupport2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerSupport2.Data
{
    public class FarmerDbContext : DbContext
    {
        public FarmerDbContext(DbContextOptions<FarmerDbContext> options)
            : base(options)
        {

        }

        public DbSet<FarmerModel> FarmerModel { get; set; }

    }
}
