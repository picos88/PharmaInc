using Microsoft.EntityFrameworkCore;

namespace PharmaInc.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=PharmaInc;Integrated Security=True");
        }
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}