using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.EF
{
    public interface IRepo<T> where T : class
    {
        void Add(T entry);
        void AddRange(IEnumerable<T> entriesList);
        T Get(long id);
        IEnumerable<T> GetAll();
        void Update(T entry);
        void Delete(T entry);
        void Commit();
    }
}
