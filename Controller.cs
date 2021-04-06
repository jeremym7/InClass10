using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index(int id)
    {
      return View();
    }

    public IActionResult Stores()
    {
      GuestStore Stores = new GuestStore();

      Stores.StoreID = "01";
      Stores.City = "Tampa";
      Stores.Phone = "123-456-9012";
      Stores.State = "FL";
      Stores.Zipcode = "33613";

      return View(Stores);
    }
    
    public IActionResult Products()
    {
      GuestProduct Products = new GuestProduct();

      Products.ProductID = "003";
      Products.ProductName = "DawnSoap";
      Products.ProductPrice = "2.99";
      Products.ProductDescription = "Dish Soap";
      Products.StoreID = "01";

      return View(Products);
    }
    
    public IActionResult Orders()
    {
      GuestOrder Orders = new GuestOrder();
      Orders.OrderID = "0032";
      Orders.OrderDate = "01/12/21";
      Orders.OrderShipDate = "01/13/21";
      Orders.ProductID = "003";
  
      return View(Orders);
    }

    [HttpPost]
    public IActionResult Contact(GuestStore Stores)
    {
      return View(Stores);
    }
    
    [HttpPost]
    public IActionResult Contact(GuestProduct Products)
    {
      return View(Products);
    }
    
    [HttpPost]
    public IActionResult Contact(GuestOrder Orders)
    {
      return View(Orders);
    }

    }
  }
}
