using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary.Models
{
    public class TvServiceModel
    {
        /// <summary>
        /// Empty CTOR.
        /// </summary>
        public TvServiceModel()
        {

        }
        /// <summary>
        /// Constructs a tv service model.
        /// </summary>
        /// <param name="name">Name of tv service model in string format.</param>
        /// <param name="channelCount">Channel count of tv service model in string format,
        /// gets parsed into an int.</param>
        /// <param name="costPerMonth">Cost per month of tv service model in string format,
        /// gets parsed into a decimal.</param>
        public TvServiceModel(string name, string channelCount, string costPerMonth)
        {
            Name = name;
            ChannelCount = int.Parse(channelCount);
            CostPerMonth = decimal.Parse(costPerMonth);
        }
        /// <summary>
        /// The unique identifier for the tv service.
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The name of the tv service.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The channel amount of the tv service.
        /// </summary>
        public int ChannelCount { get; set; }
        /// <summary>
        /// Cost per month of the tv service.
        /// </summary>
        public decimal CostPerMonth { get; set; }

    }
}
