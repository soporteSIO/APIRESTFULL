using APIRESTFULL_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
//using System.Data.Entity;

namespace APIRESTFULL_EF.Context
{
    public class DefMtyContext : DbContext
    {

      

        public DefMtyContext(DbContextOptions<DefMtyContext>  options) :base(options) { }

        
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Operador> Trabajadores { get; set; }
        public DbSet<RecepcionUnidad> RecepcionUnidades { get; set; }   
        public DbSet<EstatusUnidad> EstatusUnidad { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

        }



    }
    
}
