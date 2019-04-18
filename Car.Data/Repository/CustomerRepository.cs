using Car.Data.EntityModels;
using Car.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private ApplicationDbContext _appContext => Db;

        public CustomerRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        public Customer GetByCustomerCode(string customerCode)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.CustomerCode == customerCode);
        }

        public Customer GetByCustomerGuid(Guid guid)
        {
            var result = DbSet.AsNoTracking().FirstOrDefault(c => c.CustomerGuid == guid);

            return result;
        }

        public async Task<IEnumerable<Customer>> GetCustomers(int page, int pageSize)
        {
            IQueryable<Customer> customerQuery = _appContext.Customers
                .OrderByDescending(c => c.CreatedDate);

            if (page != -1)
                customerQuery = customerQuery.Skip((page - 1) * pageSize);

            if (pageSize != -1)
                customerQuery = customerQuery.Take(pageSize);

            var customers = await customerQuery.ToListAsync();
            return customers;
        }
    }
}
