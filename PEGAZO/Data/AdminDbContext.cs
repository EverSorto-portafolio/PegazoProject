using Microsoft.EntityFrameworkCore;
using PEGAZO.Model;

namespace PEGAZO.Data
{
    public class AdminDbContext:DbContext
    {
        public AdminDbContext
            (DbContextOptions<AdminDbContext> options):
            base(options){        
        }
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<DatosAcademicosEstudainte> DatosAcademicosEstudaintes { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
