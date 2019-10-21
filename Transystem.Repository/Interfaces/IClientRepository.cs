using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transystem.Domain.Entitys;

namespace Transystem.Repository.Interfaces
{
    public interface IClientRepository
    {
        void add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<Client[]> GetAllClientAsync();
    }
}
