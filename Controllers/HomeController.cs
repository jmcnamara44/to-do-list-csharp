using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View("Index");
      }

      [Route("/to-do-list")]
      public ActionResult ToDoList()
      {
        List<ToDoItems> allItems = ToDoItems.GetAll();
        return View("ToDoList", allItems);
      }

    }

}
