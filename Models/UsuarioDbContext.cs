using Microsoft.EntityFrameworkCore; 

namespace API_Usuario.Models {

    public class UsuarioDbContext : dbContext {
        public UsuarioDbContext(dbContextOptions<UsuarioDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}