using AspNetStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetStudy.Database
{
    public class SakilaContext : DbContext
    {
        public SakilaContext(DbContextOptions<SakilaContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

//            modelBuilder.Entity<ActorDto>().HasKey(a => new { a.actor_id });
  //          modelBuilder.Entity<FilmDto>().HasKey(f => new { f.film_id });
            modelBuilder.Entity<FilmActorDto>().HasKey(fa => new { fa.film_id, fa.actor_id });
            modelBuilder.Entity<FilmActorDto>().HasOne(fa => fa.film).WithMany(f => f.filmActors).HasForeignKey(fa => fa.film_id);
            modelBuilder.Entity<FilmActorDto>().HasOne(fa => fa.actor).WithMany(f => f.filmActors).HasForeignKey(fa => fa.actor_id);
            //modelBuilder.Entity<FilmActorDto>().HasOne(fa => fa.film).WithMany(a => a.actors).HasForeignKey(u => u.companyId); ;
        }
        public DbSet<ActorDto> Actors { get; set; }
        public DbSet<FilmDto> Films { get; set; }
        public DbSet<FilmActorDto> FilmActors { get; set; }
    }
}
