using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom1.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Posibility { get; set; }
        public string MeasureType { get; set; }
        public float RubPrice { get; set; }
        public float UsdPrice { get; set; }

        public ICollection<CargoObject> CargoObjects { get; set; }
        public ICollection<Request> Reqs { get; set; }
        public Service()
        {
            CargoObjects = new List<CargoObject>();
            Reqs = new List<Request>();
        }
    }
}
