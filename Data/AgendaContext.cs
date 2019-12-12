using SacramentMeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlanner.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }

        public DbSet<Agenda> Agendas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agenda>().ToTable("Agenda");
        }
    }
}
