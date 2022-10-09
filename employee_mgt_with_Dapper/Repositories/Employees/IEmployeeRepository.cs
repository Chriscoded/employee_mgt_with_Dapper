using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace employee_mgt_with_Dapper
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<bool> MyCustomRepositoryMethodExampleAsync();
    }
}
