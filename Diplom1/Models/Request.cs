using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom1.Models
{
    public class Request
    {
        public int ID { get; set; }
        public CargoObject Cargo { get; set; }
        public int CargoAmount { get; set; }
        public string Status { get; set; }
        public int TotalSumRub { get; set; }
        public int TotalSumUsd { get; set; }
    }
}
