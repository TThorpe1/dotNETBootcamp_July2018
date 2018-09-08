using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab24.Models;
namespace lab24.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();
            ViewBag.Items = ORM.items.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewItem()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SaveNewItem(item newItem)
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();

            // ToDo : validation!!!!! 

            ORM.items.Add(newItem);

            ORM.SaveChanges(); // sync with the database

            return RedirectToAction("Index");
        }

        public ActionResult DeleteItem(int itemid)
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();

            // for loop to find the id
// Find is a method that is used to find objects by using the primary key 
item ItemToDelete = ORM.items.Find(itemid);

            // remove 
            ORM.items.Remove(ItemToDelete);

            ORM.SaveChanges(); // toDo: use try and catch 

            return RedirectToAction("Index");

        }

        public ActionResult ItemDetails(int itemid)
        {   // This action will show the old data 
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();

            // find the item 
            item ItemToEdit = ORM.items.Find(itemid);

            if (ItemToEdit == null)
            {
                return RedirectToAction("Index");
            }
            // send it back to the view 

            ViewBag.ItemToEdit = ItemToEdit;

            return View();
        }

        public ActionResult SaveChanges(item UpdatedItem)
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();

            // find the old record 

            item OldRecord = ORM.items.Find(UpdatedItem.itemid);
            // ToDo: check for null

            OldRecord.name = UpdatedItem.name;
            OldRecord.description = UpdatedItem.description;
            OldRecord.quantity = UpdatedItem.quantity;
            OldRecord.price = UpdatedItem.price;

            ORM.Entry(OldRecord).State = System.Data.Entity.EntityState.Modified;

            ORM.SaveChanges();

            return RedirectToAction("Index");


        }

        public ActionResult SearchItemByName(string name)
        {
            gccoffeeshopEntities ORM = new gccoffeeshopEntities();

            ViewBag.Items = ORM.items.Where(x => x.name.ToLower().Contains
            (name.ToLower())).ToList();

            return View("Index");
        }
    }
}