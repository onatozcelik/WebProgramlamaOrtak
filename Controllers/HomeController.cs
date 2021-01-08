using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SakariaBookstore.Models;

namespace SakariaBookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<webuser> _userManager;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_roleManager = roleManager;
            //_userManager = userManager;
        }
        /// /Home/CreateRole?role=admin
        /// 

        
        public async Task<IActionResult> CreateRole(string role)
        {
            await _roleManager.CreateAsync(new IdentityRole(role));
            return Ok();
        }
        public async Task<IActionResult> AddRole(string username,string role)
        {
            var user = await _userManager.FindByNameAsync(username);
            await _userManager.AddToRoleAsync(user, role);
            return Ok();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(ProductRepository.Product);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product !=null)
            {
                ProductRepository.AddProduct(product);
                return View("List", ProductRepository.Product);
            }
            return View();
        }

        [Authorize(Roles ="admin")]
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
