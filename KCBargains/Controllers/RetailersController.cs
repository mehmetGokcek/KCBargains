using KCBargains.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCBargains.Controllers
{
    public class RetailersController : Controller
    {

        private readonly BargainsDbContext context;

        private readonly IWebHostEnvironment webHostEnvironment;


        public RetailersController(BargainsDbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            context = dbContext;
            webHostEnvironment = hostEnvironment;

        }


        [AllowAnonymous]
        public IActionResult Index()
        {
            //List<Event> Bargains = new List<Event>(EventData.GetAll());
            /*            List<Product> products = context.Products.Include(e => e.Category).Include(e => e.Address).ToList();
            */
            return View();
        }
    }
}
