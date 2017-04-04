using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Repo.EF.Models;
using System.Linq;

namespace Repo.EF
{
    public class GenericRepo<T> : IRepo<T> where T : class
    {
        private readonly DbContext _context;

        public GenericRepo(DbContext context)
        {
            _context = context;
        }
        public void Add(T entry)
        {
            if (entry != null)
                _context.Set<T>().Add(entry);

        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(T entry)
        {
            if(entry != null)
                _context.Set<T>().Remove(entry);
        }

        public T Get(long id)
        {
            var result = _context.Set<T>().Find(id);
            return result;
        }

        public void Update(T entry)
        {
            if (entry == null) return;
            _context.Set<T>().Attach(entry);
            _context.Entry<T>(entry).State  = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            var results = _context.Set<T>().AsEnumerable();
            return results;
        }

        public void AddRange(IEnumerable<T> employeeList)
        {
            foreach (var item in employeeList)
            {
                Add(item);
            }
        }
    }
}
