using Livros.Models;
using Microsoft.EntityFrameworkCore;

namespace Livros.Data
{
    public class ApplicationDBCntext : DbContext
    {
        public ApplicationDBCntext(DbContextOptions<ApplicationDBCntext> options) : base(options)
        {
        
        }
        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
