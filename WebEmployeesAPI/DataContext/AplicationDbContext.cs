using Microsoft.EntityFrameworkCore;
using WebEmployeesAPI.Models;

namespace WebEmployeesAPI.DataContext
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionario { get; set;}

    }
}
