﻿using Ecommerce_mvc_app.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_mvc_app.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }


        public  async Task<IActionResult> Index()
        {
            var Allproducers = await  _context.Producers.ToListAsync();
            return View( Allproducers);
        }
    }
}
