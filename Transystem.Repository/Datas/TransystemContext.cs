using Microsoft.EntityFrameworkCore;
using Transystem.Domain.Entitys;

namespace Transystem.Repository.Datas
{
    public class TransystemContext : DbContext
    {
          public TransystemContext(DbContextOptions<TransystemContext> options): base (options) {}

        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Truck> Truck { get; set; }
        public DbSet<TypeOrder> TypeOrder { get; set; }

    }
}