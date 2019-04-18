using Car.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Data.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByCustomerGuid(Guid guid);
        Customer GetByCustomerCode(string email);
        Task<IEnumerable<Customer>> GetCustomers(int page, int pageSize);
    }
}
