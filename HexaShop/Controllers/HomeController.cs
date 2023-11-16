using HexaShop.Models;
using HexaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HexaShop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{

			List<Product> products = new List<Product>();

			products.Add(new Product()
			{
				Id = 1,
				Name = "Boot for men",
				Price = 94.99,
				ImageUrl = "boot.jpg"
			});
			products.Add(new Product()
			{
				Id = 2,
				Name = "Sweatshirt for men",
				Price = 89.99,
				ImageUrl = "sweatmen.jpeg"
			});
			products.Add(new Product()
			{
				Id = 3,
				Name = "T-Shirt for men",
				Price = 47.99,
				ImageUrl = "tshirtmen.jpg"
			});

            products.Add(new Product()
            {
                Id = 4,
                Name = "Trousers for men",
                Price = 67.99,
                ImageUrl = "trousersmen.jpg"
            });

			List<ProductWomen> productWomen = new List<ProductWomen>();

			productWomen.Add(new ProductWomen()
			{
				Id = 1,
				Name ="Boot for women",
				Price = 89.99,
				ImageUrl = "bootwomen.jpg"
			});

            productWomen.Add(new ProductWomen()
            {
                Id = 2,
                Name = "T-Shirt for women",
                Price = 39.99,
                ImageUrl = "tshirtwomen.jpg"
            });

            productWomen.Add(new ProductWomen()
            {
                Id = 3,
                Name = "Sweatshirt for women",
                Price = 59.99,
                ImageUrl = "sweatwomen.jpg"
            });

            productWomen.Add(new ProductWomen()
            {
                Id = 4,
                Name = "Trouseers for women",
                Price = 66.99,
                ImageUrl = "trouserswomen.jpg"
            });


			List<ProductKids> productKids = new List<ProductKids>();

			productKids.Add(new ProductKids()
			{
				Id= 1,
				Name = "Sweatshirt for kids",
				Price = 73.99,
				ImageUrl="swaetkids.jpg"
			});

            productKids.Add(new ProductKids()
            {
                Id = 2,
                Name = "T-Shirt for kids",
                Price = 44.99,
                ImageUrl = "tshirtkids.jpg"
            });

            productKids.Add(new ProductKids()
            {
                Id = 3,
                Name = "Trousers for kids",
                Price = 93.99,
                ImageUrl = "trouserskids.jpg"
            });

            productKids.Add(new ProductKids()
            {
                Id = 1,
                Name = "Hat for kids",
                Price = 25.99,
                ImageUrl = "hat.jpg"
            });


            HomeVM homeVM = new HomeVM();
			homeVM.Products = products;
			homeVM.ProductWomen = productWomen;
			homeVM.Kids = productKids;



			return View(homeVM);
		}

		

	}
}

