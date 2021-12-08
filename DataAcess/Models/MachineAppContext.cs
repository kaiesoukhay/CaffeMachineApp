using Microsoft.EntityFrameworkCore;


namespace DataAcess.Models
{
    public partial class MachineAppContext : DbContext
    {
        public MachineAppContext()
        {
        }
        public MachineAppContext(DbContextOptions<MachineAppContext> options)
          : base(options)
        {
        }
        public virtual DbSet<Clients> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name = ConnectionStrings:DefaultConnection");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
