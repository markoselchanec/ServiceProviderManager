using Dapper;
using ServiceManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "ServiceManager";
        /// <summary>
        /// Saves a new customer in the database.
        /// </summary>
        /// <param name="customer">The customer information, including the unique identifier.</param>
        public void CreateCustomer(CustomerModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {

                //@FirstName nvarchar(100),
                //@LastName nvarchar(100),
                //@AddressName nvarchar(200),
                //@AddressNumber int,
                //@PhoneNumber varchar(20),
                //@EmailAddress nvarchar(100),
                //@ServicePackageId int,
                //@Registered datetime,
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@AddressName", model.AddressName);
                p.Add("@AddressNumber", model.AddressNumber);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@ServicePackageId", model.ServicePackage.Id);
                p.Add("@Registered", model.Registered);
                //Extracts id from DB.
                p.Add(
                    "@id",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                //Executes the stored procedure.
                connection.Execute("dbo.spCustomer_Insert", p, commandType: CommandType.StoredProcedure);
                //executes get generic method and finds id that we get back through the stored procedure.
                model.Id = p.Get<int>("@id");

                
            }
        }
        public void UpdateCustomer(CustomerModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@CustomerId int,
                //@FirstName nvarchar(100),
                //@LastName nvarchar(100),
                //@AddressName nvarchar(200),
                //@AddressNumber int,
                //@PhoneNumber varchar(20),
                //@EmailAddress nvarchar(100),
                //@ServicePackageId int,
                //@Registered datetime,
                DynamicParameters p = new DynamicParameters();
                p.Add("@CustomerId", model.Id);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@AddressName", model.AddressName);
                p.Add("@AddressNumber", model.AddressNumber);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@ServicePackageId", model.ServicePackage.Id);
                //Extracts id from DB.
                //p.Add(
                //    "@id",
                //    0,
                //    dbType: DbType.Int32,
                //    direction: ParameterDirection.Output);
                //Executes the stored procedure.
                connection.Execute("spCustomer_Update", p, commandType: CommandType.StoredProcedure);
                //executes get generic method and finds id that we get back through the stored procedure.
                //model.Id = p.Get<int>("@id");
            }
        }
        /// <summary>
        /// Saves a new internet service in the database.
        /// </summary>
        /// <param name="internetService">The internet service information, including the unique identifier.</param>
        public void CreateInternetService(InternetServiceModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@Name nvarchar(100),
                //@Speed nvarchar(100),
                //@CostPerMonth money,
                //@id int = 0 output
                DynamicParameters p = new DynamicParameters();
                //Inserts Name from argument.
                p.Add("@Name", model.Name);
                //Inserts Speed from argument.
                p.Add("@Speed", model.Speed);
                //Inserts CostPerMonth from argument.
                p.Add("@CostPerMonth", model.CostPerMonth);
                //Extracts id from DB.
                p.Add(
                    "@id",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                //Executes the stored procedure.
                connection.Execute("dbo.spInternetService_Insert",p,commandType: CommandType.StoredProcedure);
                //executes get generic method and finds id that we get back through the stored procedure.
                model.Id = p.Get<int>("@id");
            }
        }
        /// <summary>
        /// Saves a new phone service in the database.
        /// </summary>
        /// <param name="phoneService">The phone service information, including the unique identifier.</param>
        public void CreatePhoneService(PhoneServiceModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@Name nvarchar(100),
                //@TalkingMinutes int,
                //@MessageAmount int,
                //@CostPerMonth money,
                //@id int = 0 output
                 DynamicParameters p = new DynamicParameters();
                //Inserts Name from argument.
                p.Add("@Name", model.Name);
                //Inserts TalkingMinutes from argument.
                p.Add("@TalkingMinutes", model.TalkingMinutes);               
                //Inserts MessageAmount from argument.
                p.Add("@MessageAmount", model.MessageAmount);
                //Inserts CostPerMonth from argument.
                p.Add("@CostPerMonth", model.CostPerMonth);
                //Extracts id from DB.
                p.Add(
                    "@id",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                //Executes the stored procedure.
                connection.Execute("spPhoneService_Insert", p, commandType: CommandType.StoredProcedure);
                //executes get generic method and finds id that we get back through the stored procedure.
                model.Id = p.Get<int>("@id");
            }
        }
        /// <summary>
        /// Saves the service package for the customer. Consists of all services and their starting and ending dates.
        /// </summary>
        /// <param name="servicePackage">The service package information, including the unique identifier.</param>
        public void CreateServicePackage(ServicePackageModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@InternetServiceId int,
                //@InternetServiceDurationMonths int, 
                //@InternetServiceStartingDate datetime,
                //@InternetServiceEndingDate datetime,
                //@TvServiceId int,
                //@TvServiceDurationMonths int,
                //@TvServiceStartingDate datetime,
                //@TvServiceEndingDate datetime,
                //@PhoneServiceId int,
                //@PhoneServiceDurationMonths int,
                //@PhoneServiceStartingDate datetime,
                //@PhoneServiceEndingDate datetime,
                //@id int = 0 output
                DynamicParameters p = new DynamicParameters();

                if (model.InternetService != null)
                {
                    p.Add("@InternetServiceId", model.InternetService.Id);
                    p.Add("@InternetServiceDurationMonths", model.InternetServiceDurationMonths);
                    p.Add("@InternetServiceStartingDate", model.InternetServiceStartingDate);
                    p.Add("@InternetServiceEndingDate", model.InternetServiceEndingDate);

                }
                if (model.InternetService == null)
                {
                    p.Add("@InternetServiceId", null);
                    p.Add("@InternetServiceDurationMonths", null);
                    p.Add("@InternetServiceStartingDate", null);
                    p.Add("@InternetServiceEndingDate", null);
                }

                if (model.TvService != null)
                {
                    p.Add("@TvServiceId", model.TvService.Id);
                    p.Add("@TvServiceDurationMonths", model.TvServiceDurationMonths);
                    p.Add("@TvServiceStartingDate", model.TvServiceStartingDate);
                    p.Add("@TvServiceEndingDate", model.TvServiceEndingDate);

                }
                if (model.TvService == null)
                {
                    p.Add("@TvServiceId", null);
                    p.Add("@TvServiceDurationMonths", null);
                    p.Add("@TvServiceStartingDate", null);
                    p.Add("@TvServiceEndingDate", null);
                }

                if (model.PhoneService != null)
                {
                    p.Add("@PhoneServiceId", model.PhoneService.Id);
                    p.Add("@PhoneServiceDurationMonths", model.PhoneServiceDurationMonths);
                    p.Add("@PhoneServiceStartingDate", model.PhoneServiceStartingDate);
                    p.Add("@PhoneServiceEndingDate", model.PhoneServiceEndingDate);

                }
                if (model.PhoneService == null)
                {
                    p.Add("@PhoneServiceId", null);
                    p.Add("@PhoneServiceDurationMonths", null);
                    p.Add("@PhoneServiceStartingDate", null);
                    p.Add("@PhoneServiceEndingDate", null);
                }

                //Extracts id from DB.
                p.Add(
                    "@id",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                //Executes the stored procedure.
                connection.Execute("dbo.spServicePackage_Insert", p, commandType: CommandType.StoredProcedure);
                //executes get generic method and finds id that we get back through the stored procedure.
                model.Id = p.Get<int>("@id");
            }
        }

        public void UpdateServicePackage(ServicePackageModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@InternetServiceId int,
                //@InternetServiceDurationMonths int,
                //@InternetServiceStartingDate datetime,
                //@InternetServiceEndingDate datetime,
                //@TvServiceId int,
                //@TvServiceDurationMonths int,
                //@TvServiceStartingDate datetime,
                //@TvServiceEndingDate datetime,
                //@PhoneServiceId int,
                //@PhoneServiceDurationMonths int,
                //@PhoneServiceStartingDate datetime,
                //@PhoneServiceEndingDate datetime,
                //@id int = 0 output
                 DynamicParameters p = new DynamicParameters();

                if (model.InternetService != null)
                {
                    if(model.InternetService.Id == 0)
                    {
                        model.InternetService.Id = null;
                    }
                    p.Add("@InternetServiceId", model.InternetService.Id);
                    p.Add("@InternetServiceStartingDate", model.InternetServiceStartingDate);
                    p.Add("@InternetServiceEndingDate", model.InternetServiceEndingDate);
                    p.Add("@InternetServiceDurationMonths", model.InternetServiceDurationMonths);
                }

                if (model.InternetService == null)
                {
                    p.Add("@InternetServiceId", null);
                    p.Add("@InternetServiceStartingDate", null);
                    p.Add("@InternetServiceEndingDate", null);
                    p.Add("@InternetServiceDurationMonths", null);
                }

                if (model.TvService != null)
                {
                    if(model.TvService.Id == 0)
                    {
                        model.TvService.Id = null;
                    }
                    p.Add("@TvServiceId", model.TvService.Id);
                    p.Add("@TvServiceStartingDate", model.TvServiceStartingDate);
                    p.Add("@TvServiceEndingDate", model.TvServiceEndingDate);
                    p.Add("@TvServiceDurationMonths", model.TvServiceDurationMonths);
                }
                if (model.TvService == null)
                {
                    p.Add("@TvServiceId", null);
                    p.Add("@TvServiceStartingDate", null);
                    p.Add("@TvServiceEndingDate", null);
                    p.Add("@TvServiceDurationMonths", null);
                }

                if (model.PhoneService != null) {
                    if(model.PhoneService.Id == 0)
                    {
                        model.PhoneService.Id = null;
                    }
                    p.Add("@PhoneServiceId", model.PhoneService.Id);
                    p.Add("@PhoneServiceStartingDate", model.PhoneServiceStartingDate);
                    p.Add("@PhoneServiceEndingDate", model.PhoneServiceEndingDate);
                    p.Add("@PhoneServiceDurationMonths", model.PhoneServiceDurationMonths);
                }
                if (model.PhoneService == null)
                {
                    p.Add("@PhoneServiceId", null);
                    p.Add("@PhoneServiceStartingDate", null);
                    p.Add("@PhoneServiceEndingDate", null);
                    p.Add("@PhoneServiceDurationMonths", null);
                }

                connection.Execute("dbo.spServicePackage_Update", p, commandType: CommandType.StoredProcedure);

            }
        }

        /// <summary>
        /// Saves a new tv service in the database.
        /// </summary>
        /// <param name="model">The tv service information, including the unique identifier.</param>
        public void CreateTvService(TvServiceModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@Name nvarchar(100),
                //@ChannelCount int,
                //@CostPerMonth money,
                //@id int = 0 output
                 DynamicParameters p = new DynamicParameters();
                //Inserts Name from argument.
                p.Add("@Name", model.Name);
                //Inserts Speed from argument.
                p.Add("@ChannelCount", model.ChannelCount);
                //Inserts CostPerMonth from argument.
                p.Add("@CostPerMonth", model.CostPerMonth);
                //Extracts id from DB.
                p.Add(
                    "@id",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                //Executes the stored procedure.
                connection.Execute("dbo.spTvService_Insert", p, commandType: CommandType.StoredProcedure);
                //executes get generic method and finds id that we get back through the stored procedure.
                model.Id = p.Get<int>("@id");
            }
        }
        /// <summary>
        /// Deletes a customer from the database.
        /// </summary>
        /// <param name="customer">The customer to be deleted.</param>
        public void DeleteCustomer(CustomerModel customer)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@id int
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", customer.Id);
                //Executes the stored procedure.
                connection.Execute("dbo.spCustomer_DeleteById", p, commandType: CommandType.StoredProcedure);

            }
        }

        /// <summary>
        /// Deletes an internet service from the db.
        /// </summary>
        /// <param name="internetService">The internet service to be deleted.</param>
        public void DeleteInternetService(InternetServiceModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@InternetServiceId int
                DynamicParameters p = new DynamicParameters();
                p.Add("@InternetServiceId", model.Id);
                //Executes the stored procedure.
                connection.Execute("dbo.spInternetService_DeleteById", p, commandType: CommandType.StoredProcedure);

            }
        }
        /// <summary>
        /// Deletes a phone service from the db.
        /// </summary>
        /// <param name="phoneService"></param>
        public void DeletePhoneService(PhoneServiceModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@PhoneServiceId int
                DynamicParameters p = new DynamicParameters();
                p.Add("@PhoneServiceId", model.Id);
                //Executes the stored procedure.
                connection.Execute("dbo.spPhoneService_DeleteById", p, commandType: CommandType.StoredProcedure);

            }
        }
        /// <summary>
        /// Deletes a tv service from the db.
        /// </summary>
        /// <param name="tvService"></param>
        public void DeleteTvService(TvServiceModel model)
        {
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@TvServiceId int
                DynamicParameters p = new DynamicParameters();
                p.Add("@TvServiceId", model.Id);
                //Executes the stored procedure.
                connection.Execute("dbo.spTvService_DeleteById", p, commandType: CommandType.StoredProcedure);

            }
        }
        /// <summary>
        /// Get all customers from the db.
        /// </summary>
        /// <returns>List of all customers.</returns>
        public List<CustomerModel> GetCustomer_All()
        {
            List<CustomerModel> output;
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //simple execution of stored procedure to return all internet services
                output = connection.Query<CustomerModel>("spCustomer_GetAll").ToList();
            }
            return output;
        }
        /// <summary>
        /// Get customers by address name and number from the db.
        /// </summary>
        /// <param name="addressName">Name of address in string format.</param>
        /// <param name="addressNumber">Number of address in int format.</param>
        /// <returns>List of customers with a specific address name and number.</returns>
        public CustomerModel GetCustomer_ByAddressNameAndNumber(string addressName, int addressNumber)
        {
            CustomerModel output;

            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //@AddressName nvarchar(200),
                //@AddressNumber int
                DynamicParameters p = new();
                p.Add("@AddressName", addressName);
                p.Add("@AddressNumber", addressNumber);
                p.Add(
                    "@ServicePackageId",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                //simple execution of stored procedure to return all customers
                output = connection.Query<CustomerModel>("spCustomer_GetByAddressNameAndNumber", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                if (output == null) return output;
                output.ServicePackage = new();

                DynamicParameters sp = new();
                sp.Add("@ServicePackageId", p.Get<int>("@ServicePackageId"));
                sp.Add(
                    "@InternetServiceId",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                sp.Add(
                    "@TvServiceId",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                sp.Add(
                    "@PhoneServiceId",
                    0,
                    dbType: DbType.Int32,
                    direction: ParameterDirection.Output);

                output.ServicePackage = connection.Query<ServicePackageModel>("spServicePackage_GetById", sp, commandType: CommandType.StoredProcedure).First();

                output.ServicePackage.InternetService = new();
                output.ServicePackage.TvService = new();
                output.ServicePackage.PhoneService = new();

                try
                {
                    DynamicParameters iS = new();
                    iS.Add("@InternetServiceId", sp.Get<int>("@InternetServiceId"));
                    output.ServicePackage.InternetService = connection.Query<InternetServiceModel>("spInternetService_GetById", iS, commandType: CommandType.StoredProcedure).First();
                }
                catch (Exception)
                {


                }
                try
                {
                    DynamicParameters tS = new();
                    tS.Add("@TvServiceId", sp.Get<int>("@TvServiceId"));
                    output.ServicePackage.TvService = connection.Query<TvServiceModel>("spTvService_GetById", tS, commandType: CommandType.StoredProcedure).First();
                }
                catch (Exception)
                {

                }
                try
                {
                    DynamicParameters pS = new();
                    pS.Add("@PhoneServiceId", sp.Get<int>("@PhoneServiceId"));
                    output.ServicePackage.PhoneService = connection.Query<PhoneServiceModel>("spPhoneService_GetById", pS, commandType: CommandType.StoredProcedure).First();
                }
                catch (Exception)
                {
                   
                }

            }
            return output;
        }
        /// <summary>
        /// Gets all internet service models from the database.
        /// </summary>
        /// <returns>List of internet service models.</returns>
        public List<InternetServiceModel> GetInternetService_All()
        {
            List<InternetServiceModel> output;
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //simple execution of stored procedure to return all internet services
                output = connection.Query<InternetServiceModel>("spInternetService_GetAll").ToList();
            }
            return output;
        }
        /// <summary>
        /// Gets all phone service models from the database.
        /// </summary>
        /// <returns>List of phone service models.</returns>
        public List<PhoneServiceModel> GetPhoneService_All()
        {
            List<PhoneServiceModel> output;
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //simple execution of stored procedure to return all internet services
                output = connection.Query<PhoneServiceModel>("spPhoneService_GetAll").ToList();
            }
            return output;
        }
        /// <summary>
        /// Gets all tv service models from the database.
        /// </summary>
        /// <returns>List of tv service models.</returns>
        public List<TvServiceModel> GetTvService_All()
        {
            List<TvServiceModel> output;
            /// System.Data.SqlClient NUGET package.
            using (SqlConnection connection = new(GlobalConfig.CnnString(db)))
            {
                //simple execution of stored procedure to return all internet services
                output = connection.Query<TvServiceModel>("spTvService_GetAll").ToList();
            }
            return output;
        }


    }
}
