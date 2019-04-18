using AutoMapper;
using AutoMapper.QueryableExtensions;
using Car.Common.Enums;
using Car.Data.EntityModels;
using Car.Data.Interfaces;
using Car.Services.Interfaces;
using Car.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerGroupRepository _customerGroupRepository;
        private readonly IProspectRepository _prospectRepository;
        private readonly ISourceRepository _sourceRepository;
        private readonly ITitleRepository _titleRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IPersonalRepository _personalRepository;

        public CustomerAppService(ICustomerRepository customerRepository,
            ICustomerGroupRepository customerGroupRepository,
            IProspectRepository prospectRepository,
            ISourceRepository sourceRepository,
            ITitleRepository titleRepository,
            IVehicleRepository vehicleRepository,
            IPersonalRepository personalRepository,
            IMapper mapper)
        {
            _customerRepository = customerRepository;
            _customerGroupRepository = customerGroupRepository;
            _prospectRepository = prospectRepository;
            _sourceRepository = sourceRepository;
            _titleRepository = titleRepository;
            _vehicleRepository = vehicleRepository;
            _personalRepository = personalRepository;
            _mapper = mapper;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            return _customerRepository.GetAll().ProjectTo<CustomerViewModel>(_mapper.ConfigurationProvider);
        }

        public CustomerViewModel GetByGuid(Guid guid)
        {
            var customer = _customerRepository.GetByCustomerGuid(guid);
            var result = CustomerToCustomerVm(customer);

            return result;
        }

        public CustomerViewModel GetById(int id)
        {
            return _mapper.Map<CustomerViewModel>(_customerRepository.GetById(id));
        }

        public void Register(CustomerViewModel customerViewModel)
        {
            var customer = _mapper.Map<Customer>(customerViewModel);
            customer = ToCustomer(customer);

            _customerRepository.Add(customer);
        }

        public void Remove(Guid id)
        {
            _customerRepository.Remove(id);
        }

        public void Update(CustomerViewModel customerViewModel)
        {
            var customer = _mapper.Map<Customer>(customerViewModel);
            _customerRepository.Update(customer);
        }

        public async Task<IEnumerable<CustomerRecord>> GetCustomers(int page, int pageSize)
        {
            var customers = await _customerRepository.GetCustomers(page, pageSize);
            var result = CustomersToCustomerRecords(customers);

            return result;
        }

        #region private method

        private Customer ToCustomer(Customer customer)
        {
            switch (customer.CustomerType)
            {
                case Common.Enums.CustomerType.None:
                    break;
                case Common.Enums.CustomerType.Personal:
                    customer.Cooperation = null;
                    customer.Government = null;

                    customer.Personal.CustomerGroup = _customerGroupRepository.GetById(customer.Personal.CustomerGroupId);
                    customer.Personal.Prospect = _prospectRepository.GetById(customer.Personal.ProspectId);
                    customer.Personal.Source = _sourceRepository.GetById(customer.Personal.SourceId);
                    customer.Personal.Title = _titleRepository.GetById(customer.Personal.TitleId);
                    customer.Personal.Vehicle = _vehicleRepository.GetById(customer.Personal.VehicleId);
                    break;
                case Common.Enums.CustomerType.Cooperation:
                    customer.Personal = null;
                    customer.Government = null;

                    customer.Cooperation.Prospect = _prospectRepository.GetById(customer.Cooperation.ProspectId);
                    customer.Cooperation.Source = _sourceRepository.GetById(customer.Cooperation.SourceId);
                    customer.Cooperation.Vehicle = _vehicleRepository.GetById(customer.Cooperation.VehicleId);
                    break;
                case Common.Enums.CustomerType.GovernmentOrStateEnterprise:
                    customer.Personal = null;
                    customer.Cooperation = null;

                    customer.Government.Prospect = _prospectRepository.GetById(customer.Government.ProspectId);
                    customer.Government.Source = _sourceRepository.GetById(customer.Government.SourceId);
                    customer.Government.Vehicle = _vehicleRepository.GetById(customer.Government.VehicleId);
                    break;
                default:
                    break;
            }

            return customer;
        }

        private CustomerViewModel CustomerToCustomerVm(Customer customer)
        {
            var result = new CustomerViewModel();

            switch (customer.CustomerType)
            {
                case CustomerType.None:
                    break;
                case CustomerType.Personal:

                    customer.Personal = _personalRepository.GetById(customer.PersonalId);

                    result = new CustomerViewModel
                    {
                        AssignDate = customer.Personal.AssignDate,
                        BaseModelCode = customer.Personal.BaseModelCode,
                        BranchAt = customer.BranchAt,
                        CustomerCode = customer.CustomerCode,
                        CustomerCodeFrom = customer.CustomerCodeFrom,
                        CustomerGroupId = customer.Personal.CustomerGroupId,
                        CustomerGroup = _customerGroupRepository.GetById(customer.Personal.CustomerGroupId),
                        CustomerGuid = customer.CustomerGuid,
                        CustomerType = CustomerType.Personal.ToString(),
                        Email = customer.Personal.Email,
                        EstablishmentType = customer.EstablishmentType.ToString(),
                        GenderType = customer.Personal.GenderType.ToString(),
                        LastName = customer.Personal.LastName,
                        MobilePhoneNo = customer.Personal.MobilePhoneNo,
                        Name = customer.Personal.Name,
                        ProspectId = customer.Personal.ProspectId,
                        Prospect = _prospectRepository.GetById(customer.Personal.ProspectId),
                        SalesPersonCode = customer.Personal.SalesPersonCode,
                        SourceId = customer.Personal.SourceId,
                        Source = _sourceRepository.GetById(customer.Personal.SourceId),
                        TaxIdNo = customer.TaxIdNo,
                        TitleId = customer.Personal.TitleId,
                        Title = _titleRepository.GetById(customer.Personal.TitleId),
                        VehicleId = customer.Personal.VehicleId,
                        Vehicle = _vehicleRepository.GetById(customer.Personal.VehicleId)
                    };
                    break;
                case CustomerType.Cooperation:
                    break;
                case CustomerType.GovernmentOrStateEnterprise:
                    break;
                default:
                    break;
            }

            return result;
        }

        private IEnumerable<CustomerRecord> CustomersToCustomerRecords(IEnumerable<Customer> customers)
        {
            var result = new List<CustomerRecord>();

            foreach(var customer in customers)
            {
                var fullName = string.Empty;
                var mobileNo = string.Empty;

                switch (customer.CustomerType)
                {
                    case CustomerType.None:
                        break;
                    case CustomerType.Personal:
                        customer.Personal = _personalRepository.GetById(customer.PersonalId);
                        customer.Personal.Title = _titleRepository.GetById(customer.Personal.TitleId);
                        fullName = $"{customer.Personal.Title.Name}{customer.Personal.Name} {customer.Personal.LastName}";
                        mobileNo = customer.Personal.MobilePhoneNo;
                        break;
                    case CustomerType.Cooperation:
                        customer.Cooperation = null;
                        mobileNo = customer.Cooperation.MobilePhoneNo;
                        break;
                    case CustomerType.GovernmentOrStateEnterprise:
                        mobileNo = customer.Government.MobilePhoneNo;
                        break;
                    default:
                        break;
                }

                var customerRecord = new CustomerRecord
                {
                    CrateDate = customer.CreatedDate,
                    CustomerCode = customer.CustomerCode,
                    FullName = fullName,
                    IDCardNumber = customer.TaxIdNo,
                    MobileNo = mobileNo
                };

                result.Add(customerRecord);
            }

            return result;
        }

        #endregion
    }
}
