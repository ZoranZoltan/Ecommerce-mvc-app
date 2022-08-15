using Ecommerce_mvc_app.Data;
using Ecommerce_mvc_app.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_mvc_app.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService  _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()

        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
