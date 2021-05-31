using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Models;
using Microsoft.AspNetCore.Identity;

namespace Diplom1.ViewModels
{
    public class ProfileViewModel
    {
        public List<Request> AllRequests { get; set; }
        public string UserPhone { get; set; }
        public string CurrUserName { get; set; }
    }
}
