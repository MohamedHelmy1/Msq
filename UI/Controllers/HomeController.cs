using BLL.Helper;
using BLL.Stander;
using BLL.Usres;
using DataModel.ViewModel;
using Microsoft.AspNetCore.Http;
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
        private readonly IUser user;

        public HomeController(ILogger<HomeController> logger ,IStanderRep stander,IUser _user)
        {
            _logger = logger;
            this.stander = stander;
            user = _user;
        }

        public IActionResult createAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addAdmin(UserVM emp)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    user.add(emp);
                    return RedirectToAction("Admin", "Home");
                }

                return RedirectToAction("Admin", "Home");
            }
            catch
            {


                return RedirectToAction("Admin", "Home");
            }


        }
        public IActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(UserVM ad)
        {
            string x = user.login(ad);
            if (x != null)
            {
                int a = int.Parse(x);

                //HttpContext.Session.SetString("key1", x);
                HttpContext.Session.SetInt32("key1", a);


                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Admin", "Home");

            }
        }
        public IActionResult updataadmin(UserVM dat)
        {
            user.Edit(dat);
            return RedirectToAction("EditeAdmin", "Home");

        }
        public IActionResult EditeAdmin()
        {
            var idd = HttpContext.Session.GetInt32("key1");
            if (idd == 0)
            {
                return RedirectToAction("Admin", "Home");

            }
            else
            {


                var data = user.GetById((int)idd);
                return View(data);
            }
            
          
        }
        public IActionResult layout()
        {

            HttpContext.Session.SetInt32("key1", 0);

            return RedirectToAction("Admin", "Home");
        }
        public IActionResult Index()
        {
            var idd = HttpContext.Session.GetInt32("key1");
            if (idd == 0)
            {
                return RedirectToAction("Admin", "Home");

            }
            else
            {


                var data = user.GetById((int)idd);
                ViewBag.id = idd;//User id
                                 return View(data);

            }

          
        }

        public IActionResult newparricipateexam( int id)
        {
           
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public IActionResult AddRequest(UserStanderViewmodel model)
        {
            var idd = HttpContext.Session.GetInt32("key1");
            model.Fk_User = idd;//but ther user Id
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
