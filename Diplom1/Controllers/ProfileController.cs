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
using Microsoft.AspNetCore.Identity;

namespace Diplom1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        public ProfileViewModel pvm = new ProfileViewModel();
        private string _curUserName;
        private string _getPhone;
        private AppDbContextData _context;
        private ApplicationDbContext _appcontext;
        private SignInManager<IdentityUser> _usman;
        public ProfileController(ILogger<ProfileController> logger, AppDbContextData context,  ApplicationDbContext appcontext,IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _context = context;
            _appcontext = appcontext;
            var getName = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            //_getPhone = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.MobilePhone).Value;
            //var getPhone = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.HomePhone).Value;
            _curUserName = getName;
        }

        public IActionResult Index()
        {
            List<Request> getreqs = new List<Request>();
            //getreqs = _context.DBRequests.ToList().Find(br => br.User == _curUserName);
            List<Request> gotreqs = _context.DBRequests.ToList();
            foreach (Request rq in gotreqs)
            {
                if (rq.User == _curUserName)
                {
                    getreqs.Add(rq);
                }
            }
            //getreqs = _context.DBRequests.ToList();
            var bruh = _appcontext.Users.ToList().Find(br => br.Email == _curUserName);
            pvm.CurrUserName = _curUserName;
            pvm.UserPhone = bruh.PhoneNumber;
            pvm.AllRequests = getreqs;
            return View("Index", pvm);
        }
    }
}
