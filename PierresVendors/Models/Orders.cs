using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string OrderTitle {get; set;}
    public string OrderPrice {get; set;}
    public string OrderDescription{get; set;}
    public string OrderDate {get; set;}
    public int Id {get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderPrice, string orderDescription, string orderDate) //need name??
    {
      OrderPrice = orderPrice;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

        public static void ClearAll()
    {
      _instances.Clear();
    }


    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}