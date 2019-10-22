using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transystem.Domain.Entitys;

namespace Transystem.Repository.Interfaces
{
    public interface IDriverRepository
    {
        void add(Driver entity);
        void Update(Driver entity);
        void Delete(Driver entity);

        Task<bool> SaveChangesAsync();

        Task<Driver[]> GetAllDriverAsync();

        Task<Driver> GetDriverByIdAsync(int Id);

        Task<Driver[]> GetDriverAsyncByName(string Name);
    }
}
