using BLL.Helper;
using BLL.Stander;
using DataModel.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStanderRep stander;

        public HomeController(ILogger<HomeController> logger ,IStanderRep stander)
        {
            _logger = logger;
            this.stander = stander;
        }

        public IActionResult Index()
        {
            ViewBag.id = 1;//User id
            return View();
        }

        public IActionResult newparricipateexam( int id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public IActionResult AddRequest(UserStanderViewmodel model)
        {
            model.Fk_User = 1;//but ther user Id
            model.file = UploodFils.SaveFile(model.files, "File");
            var data=stander.AddUserStander(model);
            return Json(1);
        }
        [HttpGet]
        public IActionResult GetQuection(int id)
        {
           
            var data = stander.GetAllStanderQuection(id);
            return Json(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
