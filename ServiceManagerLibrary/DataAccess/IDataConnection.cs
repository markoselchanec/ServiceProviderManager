using ServiceManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateCustomer(CustomerModel customer);
        void UpdateCustomer(CustomerModel customer);
        void DeleteCustomer(CustomerModel customer);
        void CreateInternetService(InternetServiceModel internetService);
        void DeleteInternetService(InternetServiceModel internetService);
        void CreateTvService(TvServiceModel tvService);
        void DeleteTvService(TvServiceModel tvService);
        void CreatePhoneService(PhoneServiceModel phoneService);
        void DeletePhoneService(PhoneServiceModel phoneService);
        void CreateServicePackage(ServicePackageModel servicePackage);
        void UpdateServicePackage(ServicePackageModel servicePackage);
        List<InternetServiceModel> GetInternetService_All();
        List<PhoneServiceModel> GetPhoneService_All();
        List<TvServiceModel> GetTvService_All();
        List<CustomerModel> GetCustomer_All();
        CustomerModel GetCustomer_ByAddressNameAndNumber(string addressName, int addressNumber);

    }
}
