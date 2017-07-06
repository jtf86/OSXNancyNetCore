using System.Collections.Generic;

namespace coreNancy.Objects
{
  public class Task
  {
    private string _description;
    public static List<Task> instances = new List<Task> {};

    public Task(string newDescription)
    {
        this._description = newDescription;
        instances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }
  }
}
