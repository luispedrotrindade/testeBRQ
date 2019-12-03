using Microsoft.EntityFrameworkCore;

namespace testeBRQ.Models
{
    public class LocalizacaoContexto : DbContext
    {
        public LocalizacaoContexto(DbContextOptions<LocalizacaoContexto> options) : base(options)
        {
        }
        public DbSet<Localizacao> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Localizacao>().HasKey(m => m.Pais);
            base.OnModelCreating(builder);
        }
    }
}