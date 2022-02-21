using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary.Models
{
    public class CustomerModel
    {
        /// <summary>
        /// The unique identifier for the customer.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The first name of the customer.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the customer.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The address name of the customer.
        /// </summary>
        public string AddressName { get; set; }
        /// <summary>
        /// The address number of the customer.
        /// </summary>
        public int AddressNumber { get; set; }
        /// <summary>
        /// The phone number of the customer.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The e-mail address of the customer.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The time the user was created.
        /// </summary>
        public DateTime Registered { get; set; } = DateTime.Now;
        /// <summary>
        /// The collection of services the customer.
        /// is using.
        /// </summary>
        public ServicePackageModel ServicePackage { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
                
            }
        }
    }
}
