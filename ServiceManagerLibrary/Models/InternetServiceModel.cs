using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary.Models
{
    public class InternetServiceModel
    {
        /// <summary>
        /// Empty CTOR
        /// </summary>
        public InternetServiceModel()
        {

        }
        /// <summary>
        /// Constructs an internet service model.
        /// </summary>
        /// <param name="name">Name of internet service model in string format</param>
        /// <param name="speed">Speed of internet service model in string format</param>
        /// <param name="costPerMonth">Cost per month of internet service model in string format, 
        /// gets converted to decimal</param>
        public InternetServiceModel(string name, string speed, string costPerMonth)
        {
            Name = name;
            Speed = speed;
            CostPerMonth = decimal.Parse(costPerMonth);
        }
        /// <summary>
        /// The unique identifier for the internet service.
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The name of the internet service.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The speed of the internet service.
        /// </summary>
        public string Speed { get; set; }
        /// <summary>
        /// Cost per month of the internet service.
        /// </summary>
        public decimal CostPerMonth { get; set; }

    }
}
