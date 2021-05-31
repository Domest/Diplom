using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Data;
using Diplom1.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Diplom1.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Omu.AwesomeMvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diplom1.Controllers
{
    public class AddReqController : Controller
    {
        private string _curUserName;
        AppDbContextData _context;
        public CreateRequestViewModel CreReq = new CreateRequestViewModel();

        public AddReqController(IHttpContextAccessor httpContextAccessor, AppDbContextData context)
        {
            var getName = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            _curUserName = getName;
            _context = context;
        }

        public IActionResult Index(string value)
        {
            List<UserM> users = new List<UserM>
            {
                new UserM {Id=1, Name="Tom", Age=35 },
                new UserM {Id=2, Name="Alice", Age=29 },
                new UserM {Id=3, Name="Sam", Age=36 },
                new UserM {Id=4, Name="Bob", Age=31 },
            };
            List<CargoObject> getcargo = _context.DBCargo.ToList();

            ViewBag.Users = new SelectList(getcargo, "ID", "Name");
            return View();
        }

        public string GetSelectedValue(string value)
        {
            CreReq.CargoName = value;
            
            return value;
        }


        [HttpPost]
        public ActionResult Index(CreateRequestViewModel MV, FormCollection form)
        {
            string strDDLValue = form["userid"].ToString();

            return View(MV);
        }

        //public IActionResult Index()
        //{
        //    List<SelectListItem> items = PopulateFruits();
        //    return View(items);
        //}

        //[HttpPost]
        //public IActionResult Index(string[] fruit)
        //{
        //    ViewBag.Message = "Selected Items:\\n";
        //    List<SelectListItem> items = new List<SelectListItem>();
        //    items = _context.DBCargo.ToList();

        //    foreach (SelectListItem item in items)
        //    {
        //        if (fruit.Contains(item.Value))
        //        {
        //            item.Selected = true;
        //            ViewBag.Message += string.Format("{0}\\n", item.Text);
        //        }
        //    }

        //    return View(items);
        //}

        //private static List<SelectListItem> PopulateFruits()
        //{
        //    //string constr = @"Data Source=.\SQL2019;Initial Catalog=AjaxSamples;Integrated Security=true";

        //    return items;
        //}
    }
}
