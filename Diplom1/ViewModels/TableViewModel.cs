using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Models;

namespace Diplom1.ViewModels
{
    public class TableViewModel
    {
        public IEnumerable<Request> AllServices { get; set; }
    }
}
