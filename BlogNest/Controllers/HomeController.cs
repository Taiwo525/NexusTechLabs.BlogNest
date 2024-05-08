﻿using BlogNest.Core.Repositories;
using BlogNest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogNest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepo repo;

        public HomeController(ILogger<HomeController> logger, IPostRepo repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var result = await repo.GetAllPostsAsync();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}