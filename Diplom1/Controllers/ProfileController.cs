using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Models;
using Diplom1.ViewModels;
using Diplom1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace Diplom1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        public ProfileViewModel pvm = new ProfileViewModel();
        private string _curUserName;
        private AppDbContextData _context;
        public ProfileController(ILogger<ProfileController> logger, AppDbContextData context, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _context = context;
            var getName = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            //var getPhone = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.HomePhone).Value;
            _curUserName = getName;
        }

        public IActionResult Index(ProfileViewModel getpvm)
        {
            //Request user = _context.DBRequests.ToList().Find(br => br.User == _curUserName);
            //pvm.AllRequests = user;
            return View("Index", getpvm);
        }
    }
}
