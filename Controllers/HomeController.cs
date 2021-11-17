using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProgOdev.Data;
using WebProgOdev.Models;

namespace WebProgOdev.Controllers
{ 
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Member> _userManager;
        
        
        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, UserManager<Member> userManager, ApplicationDbContext context, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
            _localizer = localizer;
           
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateRole(string role)
        {
            await _roleManager.CreateAsync(new IdentityRole(role));
            return Ok();
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> AddRole(string username, string role)
        {
            var user=await _userManager.FindByNameAsync(username);
            await _userManager.AddToRoleAsync(user,role);
            return Ok();
        }

        
        public IActionResult Index()
        {
            var message = _localizer["Message"];
            ViewData["Message"] = message;
            HomePageViewModels vm = new HomePageViewModels();
            vm.Kategori = _context.Categories.ToList();
            vm.Yazi = _context.Texts.ToList();
            return View(vm);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
        public async Task<IActionResult> YaziDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var text = await _context.Texts
                .FirstOrDefaultAsync(m => m.yaziID == id);
            if (text == null)
            {
                return NotFound();
            }

            return View(text);

        }
        
        public IActionResult YaziEkle()
        {
            ViewData["FKkategoriID"] = new SelectList(_context.Categories, "kategoriID", "kategoriID");
            ViewData["FKuyeID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YaziEkle([Bind("yaziID,yaziBaslik,yaziTarih,yaziIcerik,FKkategoriID,FKuyeID")] Text text)
        {
            if (ModelState.IsValid)
            {
                _context.Add(text);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FKkategoriID"] = new SelectList(_context.Categories, "kategoriID", "kategoriID", text.FKkategoriID);
            ViewData["FKuyeID"] = new SelectList(_context.Users, "Id", "Id", text.FKuyeID);
            return View(text);
        }
    }
}
