using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciurea_Cosmin_Lab11.Models;

namespace Ciurea_Cosmin_Lab11.Data
{
    public class Ciurea_Cosmin_Lab11Context : DbContext
    {
        public Ciurea_Cosmin_Lab11Context (DbContextOptions<Ciurea_Cosmin_Lab11Context> options)
            : base(options)
        {
        }

        public DbSet<Ciurea_Cosmin_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
