using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diplom1.ViewModels
{
    public class CreateRequestViewModel
    {
        public IEnumerable<Request> AllRequests { get; set; }
        public string CurrUserName { get; set; }
        public List<SelectListItem> AllCargoes { get; set; }
        public List<CargoObject> AllCargoes1 { get; set; }
        public List<Service> AllServices { get; set; }
        public List<CheckCargoSer> CheckList { get; set; }
        public int CargoAmount { get; set; }
    }
}
