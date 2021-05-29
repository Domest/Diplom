using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom1.Models
{
    public class CreateRequest
    {
        //public int ID { get; set; }
        public List<CargoObject> CargoObj { get; set; }
        public List<Service> Services { get; set; }
        public int CargoAmount { get; set; }
        public string Status { get; set; }
        public int TotalSumRub { get; set; }
        public int TotalSumUsd { get; set; }
        public string User { get; set; }
    }
}
