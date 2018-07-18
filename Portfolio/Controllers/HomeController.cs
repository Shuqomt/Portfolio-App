using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;
using Portfolio.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private IPhotoshopRepository _photoshopRepository;
        public HomeController(IPhotoshopRepository Portfolio)
        {
            //_Portfolio = new Portfolio
            //above line was not used because in the startup class we used addtransient and each time irepository was used a new instance of mockrepository was created.
            _photoshopRepository = Portfolio;
        }

        public IActionResult Index()
        {
            //ViewBag.Title = "Photoshop Portfolio";
            var psd = _photoshopRepository.GetAllPhotoshop().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Tityana's Photoshop Portfolio",
                Photoshops = psd.ToList()
            };

            return View(homeViewModel);
        }
    }
}