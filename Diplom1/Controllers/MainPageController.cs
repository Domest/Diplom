using Diplom1.Data;
using Diplom1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Omu.AwesomeMvc;

namespace Diplom1.Controllers
{
    [Authorize(Roles = "user")]
    public class MainPageController : Controller
    {
        private readonly ILogger<MainPageController> _logger;
        AppDbContextData _context;
        ApplicationDbContext _contIdentity;
        public TableViewModel TableObj1 = new TableViewModel();
        private string _curUserName;
        List<CargoObject> _crg = new List<CargoObject>();

        public MainPageController(ILogger<MainPageController> logger, AppDbContextData context, IHttpContextAccessor httpContextAccessor, ApplicationDbContext contIdentity)
        {
            _logger = logger;
            _context = context;
            _contIdentity = contIdentity;
            var getName = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            _curUserName = getName;
        }

        public IActionResult MainPage(TableViewModel TbModel, string save, string cancel, string openmodal)
        {
            _crg = _context.DBCargo.Include(sa => sa.PossibleServices).ToList();
            
            List<Request> GetRequests = _context.DBRequests.Include(rq => rq.CargoObj).Include(rq => rq.Services).ToList();
            TbModel.AllRequests = GetRequests;
            TbModel.CurrUserName = _curUserName;
            TbModel.AllCargoes = _crg;

            return View("MainPage", TbModel);
        }

        public IActionResult Popup1()
        {
            return PartialView();
        }

        public IActionResult Index()
        {
            var GetCargoes = _context.DBCargo.Include(sa => sa.PossibleServices).ToList();
            return View(GetCargoes);
        }
    }
}


//if (!string.IsNullOrEmpty(openmodal))
//{

//}

//if (!string.IsNullOrEmpty(save))
//{
//    //List<Request> GetRequests = _context.DBRequests.ToList();

//    //foreach (Request rq in _context.DBRequests.Include(rq=>rq.CargoObj).Include(rq=>rq.Services))
//    //{
//    //}

//}
//if (!string.IsNullOrEmpty(cancel))
//{

//}
