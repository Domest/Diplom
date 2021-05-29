using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom1.Models
{
    public class ManyToMany
    {
        public List<int> CargoId { get; set; }
        public List<int> ServiceId { get; set; }
    }
}
