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
        List<ToDoItems> allItems = ToDoItems.GetAll();
        return View("Index", allItems);
      }

      [HttpGet("/to-do-list")]
      public ActionResult ToDoList()
      {
        List<ToDoItems> allItems = ToDoItems.GetAll();
        return View("ToDoList", allItems);
      }

      [HttpGet("/create")]
      public ActionResult Create()
      {
        return View();
      }

      [HttpGet("/update")]
      public ActionResult Update()
      {
        List<ToDoItems> allItems = ToDoItems.GetAll();
        int itemId = int.Parse((Request.Query["id"]));
        return View(allItems[itemId]);
      }
      // [HttpGet("/")]
      [HttpPost("/update-submit")]
      public ActionResult UpdateSubmit()
      {
        List<ToDoItems> allItems = ToDoItems.GetAll();
        int itemId = int.Parse((Request.Form["id"]));


        allItems[itemId].SetTitle(Request.Form["title"]);
        allItems[itemId].SetDescription(Request.Form["description"]);
        allItems[itemId].SetDueDate(Request.Form["due-date"]);
        allItems[itemId].SetImportance(Request.Form["importance"]);
        // ToDoItems toDoListItem = new ToDoItems(title, description, dueDate, importance);
        // toDoListItem.Save();
        //
        // allItems.RemoveAt(itemId);


        return View("Index", allItems);
      }

      [HttpPost("/create-to-do-item")]
      public ActionResult CreateToDoItem()
      {
        var title = (Request.Form["title"]);
        var description = (Request.Form["description"]);
        var dueDate = (Request.Form["due-date"]);
        var importance = (Request.Form["importance"]);
        ToDoItems toDoListItem = new ToDoItems(title, description, dueDate, importance);
        toDoListItem.Save();

        List<ToDoItems> allItems = ToDoItems.GetAll();
        return View("Index", allItems);
      }

      [HttpGet("/delete")]
      public ActionResult Delete()
      {
        List<ToDoItems> allItems = ToDoItems.GetAll();
        int itemId = int.Parse((Request.Query["id"]));
        allItems.RemoveAt(itemId);
        return View("Index", allItems);
      }

    }

}
