using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom1.Models
{
    public class Request
    {
        public int ID { get; set; }
        public ICollection<CargoObject> CargoObj { get; set; }
        public ICollection<Service> Services { get; set; }
        public int CargoAmount { get; set; }
        public string Status { get; set; }
        public int TotalSumRub { get; set; }
        public int TotalSumUsd { get; set; }
        public string User { get; set; }
        public Request()
        {
            CargoObj = new List<CargoObject>();
            Services = new List<Service>();
        }
    }
}
