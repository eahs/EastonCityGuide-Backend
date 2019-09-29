﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADSBackend.Data;
using ADSBackend.Models.AdminViewModels;
using ADSBackend.Models.Identity;
using ADSBackend.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ADSBackend.Controllers
{
    public class LocationController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IEmailSender _emailSender;

        public LocationController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IEmailSender emailSender)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var locations = await _context.Users.OrderBy(x => x.LastName).ToListAsync();
            

            //Console.WriteLine(users);

            var locationModel = locations.Select(x => new LocationsViewModel
            {
                Id = 29391203,
                Email = "example@gmail.com",
                Title = "boi",
                Latitude = 5.0f,
                Longitude = 7.0f,
            }).ToList();


            return View(locationModel);
        }
    }
}