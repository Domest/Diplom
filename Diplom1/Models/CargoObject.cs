using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom1.Models
{
    public class CargoObject
    {
        public int ID { get; set; }
        [NotMapped]
        public int BackId { get; set; }
        public string Name { get; set; }
        public List<Service> PossibleServices { get; set; }
    }
}
