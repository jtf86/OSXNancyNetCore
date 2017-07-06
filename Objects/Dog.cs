using System.Collections.Generic;

namespace coreNancy.Objects
{
  public class Dog
  {
    public string _name;
    public static List<Dog> instances = new List<Dog> {};

    public Dog(string newName)
    {
        this._name = newName;
        instances.Add(this);
    }

    public string GetName()
    {
      return _name;
    }

    public static List<Dog> GetAll()
    {
      return instances;
    }

    public void Save()
    {
      
    }
  }
}
