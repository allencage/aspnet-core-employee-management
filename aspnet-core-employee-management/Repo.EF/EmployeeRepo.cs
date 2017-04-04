using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.EF
{
    public class EmployeeRepo
    {
        private readonly IRepo<Models.Employee> _repo;
        public EmployeeRepo(IRepo<Models.Employee> repo)
        {
            _repo = repo;
        }
    }
}
