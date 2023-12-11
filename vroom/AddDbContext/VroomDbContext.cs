using Microsoft.EntityFrameworkCore;
using vroom.Models;

namespace vroom.AddDbContext
{
    public class VroomDbContext : DbContext
    {
        public VroomDbContext(DbContextOptions<VroomDbContext> options) : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
