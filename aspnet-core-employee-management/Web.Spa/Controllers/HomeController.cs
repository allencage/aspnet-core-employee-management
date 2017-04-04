using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModels = Repo.EF.Models;
using Repo.EF;

namespace Web.Spa.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepo<DataModels.Employee> _repo;

        public HomeController(IRepo<DataModels.Employee> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var results = _repo.GetAll();
            return View(results);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRecord(DataModels.Employee employee)
        {
            if (employee == null) Redirect("Index");
            _repo.Add(employee);
            return Redirect("Index");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
