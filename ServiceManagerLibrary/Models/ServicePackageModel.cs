using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary.Models
{
    public class ServicePackageModel
    {
        /// <summary>
        /// The unique identifier for the service package.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The type of internet service for the package.
        /// </summary>
        public InternetServiceModel? InternetService { get; set; }
        /// <summary>
        /// The Duration for the internet service.
        /// </summary>
        public int InternetServiceDurationMonths { get; set; }
        /// <summary>
        /// The starting date of the internet service.
        /// </summary>
        public DateTime InternetServiceStartingDate { get; set; }
        /// <summary>
        /// The ending date of the internet service.
        /// </summary>
        public DateTime InternetServiceEndingDate { get; set; }
        /// <summary>
        /// The type of tv service for the package.
        /// </summary>
        public TvServiceModel? TvService { get; set; }
        /// <summary>
        /// The Duration for the tv service.
        /// </summary>
        public int TvServiceDurationMonths { get; set; }
        /// <summary>
        /// The starting date of the tv service.
        /// </summary>
        public DateTime TvServiceStartingDate { get; set; }
        /// <summary>
        /// The ending date of the tv service.
        /// </summary>
        public DateTime TvServiceEndingDate { get; set; }
        /// <summary>
        /// The type of phone service for the package.
        /// </summary>
        public PhoneServiceModel? PhoneService { get; set; }
        /// <summary>
        /// The Duration for the phone service.
        /// </summary>
        public int PhoneServiceDurationMonths { get; set; }
        /// <summary>
        /// The starting date of the phone service.
        /// </summary>
        public DateTime PhoneServiceStartingDate { get; set; }
        /// <summary>
        /// The ending date of the phone service.
        /// </summary>
        public DateTime PhoneServiceEndingDate { get; set; }
    }
}
