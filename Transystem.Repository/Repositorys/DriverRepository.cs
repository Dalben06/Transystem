using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transystem.Domain.Entitys;
using Transystem.Repository.Datas;
using Transystem.Repository.Interfaces;

namespace Transystem.Repository.Repositorys
{
    public class DriverRepository : IDriverRepository
    {

        public TransystemContext _context { get; }

        public DriverRepository(TransystemContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        public void add(Driver entity)
        {
            entity.CreateDate = entity.UpdateDate = DateTime.Now;
            _context.Add(entity);
        }
        public void Update(Driver entity)
        {
            entity.UpdateDate = DateTime.Now;
            _context.Update(entity);
        }
        public void Delete(Driver entity)
        {
            _context.Update(entity)
                .Entity.IsDeleted = 1;
            _context.Update(entity)
                .Entity.DeleteDate = DateTime.Now;

        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Driver[]> GetAllDriverAsync()
        {
            IQueryable<Driver> query = _context.Driver
                .Include(c => c.trucks);


            query = query.OrderBy(x => x.Id).Where(x => x.IsDeleted == 0);

            return await query.ToArrayAsync();
        }

        public async Task<Driver> GetDriverByIdAsync(int Id)
        {
            IQueryable<Driver> query = _context.Driver
                .Include(c => c.trucks);
            query = query.Where(x => x.Id == Id);
            query = query.Where(x => x.IsDeleted == 0);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Driver[]> GetDriverAsyncByName(string Name)
        {
            IQueryable<Driver> query = _context.Driver
                .Include(c => c.trucks);

            query = query.Where(x => x.Name.ToLower().Contains(Name.ToLower()));
            query = query.Where(x => x.IsDeleted == 0);

            return await query.ToArrayAsync();
        }
    }
}
