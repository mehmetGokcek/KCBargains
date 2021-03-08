using KCBargains.Data;
using KCBargains.Models;
using KCBargains.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KCBargains.Controllers
{
    public class ProductsController : Controller{

        private readonly BargainsDbContext context;

        private readonly IWebHostEnvironment webHostEnvironment;


        public ProductsController(BargainsDbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            context = dbContext;
            webHostEnvironment = hostEnvironment;

        }

        [AllowAnonymous]
        public IActionResult Index()
        {

            List<Product> products = context.Products.Include(e => e.Category).Include(e => e.ProductRetailer).ToList();
            return View(products);
        }

 

        [AllowAnonymous]
        public IActionResult Add()
        {
            List<ProductCategory> categories = context.ProductCategories.ToList();


            Retailer retailer = new Retailer();

            AddProductViewModel addProductViewModel = new AddProductViewModel(categories, retailer);

            return View(addProductViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddProductViewModel addProductViewModel)
        {
            Console.WriteLine("About to add an Product....");


            if (ModelState.IsValid)
            {
          
                ProductCategory category = context.ProductCategories.Find(addProductViewModel.CategoryId);

                Retailer retailer = new Retailer
                {
                    Street = addProductViewModel.Retailer.Street,
                    City = addProductViewModel.Retailer.City,
                    State = addProductViewModel.Retailer.State,
                    Zipcode = addProductViewModel.Retailer.Zipcode,
                    Latitude = addProductViewModel.Retailer.Latitude,
                    Longitude = addProductViewModel.Retailer.Longitude,
                };

                string uniqueFileName = UploadedFile(addProductViewModel);

                Product product = new Product
                {
                    Name = addProductViewModel.Name,
                    Description = addProductViewModel.Description,
                    Quantity = addProductViewModel.Quantity,
                    Cost = addProductViewModel.Cost,
                    Picture = uniqueFileName,
                    Category = category,
                    ProductRetailer = retailer,
                };


                context.Retailers.Add(retailer);
                context.Products.Add(product);
                context.SaveChanges();

                return Redirect("/Products");
            }


            List<ProductCategory> categories = context.ProductCategories.ToList(); //reload category list options to make sure they will appear after the data validation errors

            return View(new AddProductViewModel(categories, new Retailer())); //passing new Model Object with categories list options
        }

        private string UploadedFile(AddProductViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProductPicture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProductPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProductPicture.CopyTo(fileStream);
                }
            }

            else if (model.ProductPicture == null)
            {
                Console.WriteLine("model.EventImage is Null");
            }

            return uniqueFileName;
        }
    }
}
