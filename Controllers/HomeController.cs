using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DogDirectory.Models;
using DogDirectory.Services;

namespace DogDirectory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDogBreedService _dogBreedSvc;

        public HomeController(IDogBreedService dogBreedSvc)
        {
            this._dogBreedSvc = dogBreedSvc;
        }


        public async Task<IActionResult> Index()
        {
            var model = await _dogBreedSvc.GetBreedsAsync();
            return View(model);
        }

        public async Task<IActionResult> Details(string id)
        {
            var url = await _dogBreedSvc.GetRandomImage(id);
            return View(new DogBreedImage { Breed = id, ImageUrl = url } );
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
