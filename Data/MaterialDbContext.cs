using LearnWeb_task_blazor.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb_task_blazor.Data
{
    public class MaterialDbContext: DbContext
    {
        public MaterialDbContext(DbContextOptions<MaterialDbContext> options) : base(options)
        {
                
        }

        public DbSet<Material> Material { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
