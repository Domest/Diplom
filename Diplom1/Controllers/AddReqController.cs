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

        //public IActionResult Index(string value)
        //{
        //    List<CargoObject> getcargo = _context.DBCargo.ToList();

        //    ViewBag.Users = new SelectList(getcargo, "ID", "Name");
        //    return View();
        //}

        //public string GetSelectedValue(string value)
        //{
        //    CreReq.CargoName = value;

        //    return value;
        //}


        //[HttpPost]
        //public ActionResult Index(CreateRequestViewModel MV, IFormCollection form)
        //{
        //    string strDDLValue = form["userid"].ToString();

        //    return View(MV);
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            List<CargoObject> getcargo = _context.DBCargo.ToList();
            CreReq.AllCargoes1 = getcargo;
            CreReq.AllCargoes = BindList();
            CreReq.AllServices = new List<SelectListItem>();
            CreReq.AllServices.Add(new SelectListItem() { Text= "Дополнительные работы при выгрузке, с нарушением укладки груза в вагоне", Value="0"});
            CreReq.AllServices.Add(new SelectListItem() { Text = "Приведение бухт катанки в транспортабельное состояние, без стоимости материалов", Value = "1" });

            return View(CreReq);
        }
        [HttpPost]
        public IActionResult Index(CreateRequestViewModel crv)
        {
            crv.AllCargoes = BindList();
            if (crv.CargoIDs != null)
            {
                List<SelectListItem> selectedItems = crv.AllCargoes.Where(p => crv.CargoIDs.Contains(int.Parse(p.Value))).ToList();
            }
            return View(crv);
        }

        public List<SelectListItem> BindList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<CargoObject> crg = new List<CargoObject>();
            crg = _context.DBCargo.ToList();
            foreach (CargoObject co in crg)
            {
                list.Add(new SelectListItem() {Text = co.Name, Value = co.ID.ToString() });
            }
            return list;
        }
        public List<SelectListItem> BindServ()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<Service> srv = new List<Service>();
            srv = _context.DBServices.ToList();
            List<CargoObject> GetCargo = _context.DBCargo.Include(m => m.PossibleServices).ToList();

            foreach (CargoObject co in GetCargo)
            {
                for (int i = 0; i < CreReq.CargoIDs.Count(); i++)
                {
                    if (CreReq.CargoIDs[i] == co.ID)
                    {
                        foreach (Service gsrv in co.PossibleServices)
                        {
                            bool IsExist = list.Any(item => item.Text == gsrv.Name);
                            if(IsExist != true)
                                list.Add(new SelectListItem() { Value = gsrv.ID.ToString(), Text = gsrv.Name});
                        }
                    }
                }
            }
            //var bruh = _context.DBServices;
            //foreach (var sr in srv)
            //{
            //    sr.CargoObjects?.Name
            //}

            return list;
        }
        public string LoadServices(string value)
        {
            CreReq.AllServices = new List<SelectListItem>();
            CreReq.ServiceIDs = null;
            //CreReq.AllServices = BindServ();
            CreReq.CargoIDs = null;
            return value;
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
