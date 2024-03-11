using Medium.Domen.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.Abstraction
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        Task SaveChangesAsync(CancellationToken cancellation);
    }
}
