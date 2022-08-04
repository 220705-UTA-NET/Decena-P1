using MedicationsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicationsAPI.Data
{
    public class MedicinesDbContext : DbContext
    {
        public MedicinesDbContext(DbContextOptions<MedicinesDbContext> options)
            : base(options)
        {

        }

        public DbSet<Medicines> Medicines { get; set; }
    }
}
