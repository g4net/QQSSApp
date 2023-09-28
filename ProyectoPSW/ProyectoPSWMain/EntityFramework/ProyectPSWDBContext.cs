
using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyectoPSWMain.EntityFramework
{
    public class ProyectPSWDBContext : DbContextPSW
    {
        public ProyectPSWDBContext() : base("Server=tcp:pswsv2023.database.windows.net,1433;Initial Catalog=PSWDB;Persist Security Info=False;User ID=id;Password=pass*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }
        static ProyectPSWDBContext() {
            Database.SetInitializer<ProyectPSWDBContext>(new DropCreateDatabaseIfModelChanges<ProyectPSWDBContext>());
        
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
        //Esto es para agragar las distintas tablas de las clases. Algunas no ahcen faltas agregarlas porque se agregan de otras
        public DbSet<User> Users { get; set; }
        public DbSet<Reto> Retos { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<Estadistica> Estadisticas { get; set; }
        public override void RemoveAllData()
        {
            //clearSomeRelationships();
            Set<User>().RemoveRange(Set<User>());
            Set<Pregunta>().RemoveRange(Set<Pregunta>());
            
            Set<Reto>().RemoveRange(Set<Reto>());
            Set<Respuesta>().RemoveRange(Set<Respuesta>());
            Set<Partida>().RemoveRange(Set<Partida>());
            Set<Estadistica>().RemoveRange(Set<Estadistica>());
            SaveChanges();
        }
        // Sometimes it is needed to clear some relationships explicitly 
        private void clearSomeRelationships()
        {

        }


    }
}
