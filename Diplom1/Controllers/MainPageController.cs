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

namespace Diplom1.Controllers
{
    public class MainPageController : Controller
    {
        private readonly ILogger<MainPageController> _logger;
        AppDbContextData _context;

        public MainPageController(ILogger<MainPageController> logger, AppDbContextData context)
        {
            _logger = logger;
            _context = context;
        }

        IEnumerable<Request> GetRec
        {
            get
            {
                return new List<Request>
                {
                    new Request
                    {
                        CargoAmount = 10,
                        Status = "выполняется",
                        TotalSumRub = 43423,
                        TotalSumUsd = 3234
                    },
                    new Request
                    {
                        CargoAmount = 10,
                        Status = "выполняется",
                        TotalSumRub = 43423,
                        TotalSumUsd = 3234
                    }
                };
            }
        }
        //Request ser = new Request()
        //{
        //    CargoAmount = 10,
        //    Status = "выполняется",
        //    TotalSumRub = 43423,
        //    TotalSumUsd = 3234
        //};

        public IActionResult MainPage()
        {
            IEnumerable<Request> Requests = GetRec;
            //Requests.Append(ser);




            var TableObj = new TableViewModel()
            {
                AllServices = Requests
            };
            return View(TableObj);
        }
    }
}
