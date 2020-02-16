using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FarmerSupport2.Models
{
    public class FarmerSupport2Context : DbContext
    {
        public FarmerSupport2Context (DbContextOptions<FarmerSupport2Context> options)
            : base(options)
        {
        }

        public DbSet<FarmerSupport2.Models.FarmerModel> FarmerModel { get; set; }
    }
}
