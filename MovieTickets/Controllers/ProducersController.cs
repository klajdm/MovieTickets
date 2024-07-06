﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Data;
using MovieTickets.Data.Services;
using MovieTickets.Models;

namespace MovieTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Producers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);

            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }

        //Get: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
           

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
    }
}
