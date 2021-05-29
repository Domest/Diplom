using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Models;
using Microsoft.AspNetCore.Html;

namespace Diplom1.ViewModels
{
    public class TableViewModel
    {
        public IEnumerable<Request> AllRequests { get; set; }
        public string CurrUserName { get; set; }
        public List<int> CargoObjId { get; set; }
        public List<int> ServiceId { get; set; }
        public List<CargoObject> AllCargoes { get; set; }
        public List<Service> AllServices { get; set; }
    }
}
