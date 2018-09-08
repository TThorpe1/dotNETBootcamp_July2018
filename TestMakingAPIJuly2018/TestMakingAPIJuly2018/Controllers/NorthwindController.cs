using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestMakingAPIJuly2018.Models;


namespace TestMakingAPIJuly2018.Controllers
{
    public class NorthwindController : ApiController
    {
        // action to get info about all customers
        public List<Customer> GetAllCustomers()
        {
            // create the ORM
            northwindEntities ORM = new northwindEntities();

            // get all customers from the ORM
           List<Customer> customerList = ORM.Customers.ToList();

            // return the list of customers

            return customerList;
        }

        // action to get customers from a specific city
        [HttpGet]
        public List<Customer> GetCustomersByCity(string city)
        {   // URL
            // http://localhost:port/api/Northwind/GetCustomersByCity?city=Detroit 

            // create ORM
            northwindEntities ORM = new northwindEntities();
            // Filter customers by city then return the list
            return ORM.Customers.Where(x => x.City.ToLower() == city.ToLower()).ToList();
        }

        // action to get all cities where customers come from
        public List<string> GetAllCities()
        {
            // create ORM
            northwindEntities ORM = new northwindEntities();
            // return ORM.Customers.Select(x => x.City).Distinct().ToList();
            return ORM.Customers.Where(x=>x.City!=null)
                .Select(x => x.City).Distinct().ToList();
        }

        // action to get orders for a specific customer 

        public List<Order> GetCustomerOrders(string customerID)
        {   // URL: http://localhost:port/api/Northwind/GetCustomerOrders?customerID=ALFKI
            
            // ORM
            northwindEntities ORM = new northwindEntities();
            // Find the customer, then get the orders for that customer 
            Customer c = ORM.Customers.Find(customerID);
            if (c != null)
            {  
                return c.Orders.ToList(); // will return orders made by that customer

            }

            return null; // if the customer is not found 

        }
       
    }
}