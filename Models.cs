using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Start.Models
{
  public class Stores
  {
    [Key]
    public string StoreID { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
  }

  public class Products
  {
    [Key]
    public string ProductID { get; set; }
    public string ProductName { get; set; }
    public string ProductPrice { get; set; }
    public string ProductDescription { get; set; }
    public string StoreID { get; set; }
  }
  
  public class Orders
  {
    [Key]
    public string OrderID { get; set; }
    public string OrderDate { get; set; }
    public string OrderShipDate { get; set; }
    public string ProductID { get; set; }
  }

  
}
