using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary.Models
{
    public class PhoneServiceModel
    {
        /// <summary>
        /// Empty CTOR.
        /// </summary>
        public PhoneServiceModel()
        {

        }
        /// <summary>
        /// Constructs a phone service model.
        /// </summary>
        /// <param name="name">Name of phone service model in string format</param>
        /// <param name="costPerMonth">Cost per month of phone service model in string format, 
        /// gets converted to decimal</param>
        /// <param name="talkingMinutes">Talking minutes allowed in phone service in string format,
        /// gets converted to int</param>
        /// <param name="messageAmount">Message amount allowed in phone service in string format,
        /// gets converted to int</param>
        public PhoneServiceModel(string name, string costPerMonth, string talkingMinutes, string messageAmount)
        {
            Name = name;
            CostPerMonth = decimal.Parse(costPerMonth);
            TalkingMinutes = int.Parse(talkingMinutes);
            MessageAmount = int.Parse(messageAmount);
        }
        /// <summary>
        /// The unique identifier for the phone service.
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The name of the phone service.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Amount of minutes allowed per month.
        /// </summary>
        public int TalkingMinutes { get; set; }
        /// <summary>
        /// Amount of SMS messages allowed per month.
        /// </summary>
        public int MessageAmount { get; set; }
        /// <summary>
        /// Cost per month of the phone service.
        /// </summary>
        public decimal CostPerMonth { get; set; }

    }
}
