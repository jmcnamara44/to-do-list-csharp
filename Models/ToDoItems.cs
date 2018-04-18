using System.Collections.Generic;

namespace ToDoList.Models
{
  public class ToDoItems
  {
    private string _title;
    private string _description;
    private string _dueDate;
    private string _importance;
    private int _id;
    private static List<ToDoItems> _instances = new List<ToDoItems> {};

    public ToDoItems(string title, string description, string dueDate, string importance)
      {
        _title = title;
        _description = description;
        _dueDate = dueDate;
        _importance = importance;
        _id = _instances.Count;
      }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetDueDate()
    {
      return _dueDate;
    }

    public void SetDueDate(string newDueDate)
    {
      _dueDate = newDueDate;
    }

    public string GetImportance()
    {
      return _importance;
    }

    public void SetImportance(string newImportance)
    {
      _importance = newImportance;
    }

    public int GetId()
    {
      return _id;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static List<ToDoItems> GetAll()
    {
      return _instances;
    }
  }
}
