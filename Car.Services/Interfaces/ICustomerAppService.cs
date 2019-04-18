using Car.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Services.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(int id);
        CustomerViewModel GetByGuid(Guid guid);
        void Update(CustomerViewModel customerViewModel);
        void Remove(Guid id);
        Task<IEnumerable<CustomerRecord>> GetCustomers(int page, int pageSize);
    }
}
