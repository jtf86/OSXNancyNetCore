using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.SqlServer;

namespace coreNancy.Objects
{
  public class Dog
  {
    public string _name;
    public int _id;
    // public static List<Dog> instances = new List<Dog> {};

    public Dog(string newName, int id=0)
    {
        this._name = newName;
        this._id = id;
        // instances.Add(this);
    }

    public string GetName()
    {
      return _name;
    }

    // public static List<Dog> GetAllOLD()
    // {
    //   return instances;
    // }

    public static List<Dog> GetAll()
    {
      List<Dog> allDogs = new List<Dog>{};

      SqlConnection conn = DB.Connection();
      conn.Open();

      SqlCommand cmd = new SqlCommand("SELECT * FROM dogs;", conn);
      SqlDataReader rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        int dogId = rdr.GetInt32(0);
        string dogName = rdr.GetString(1);
        Dog newDog = new Dog(dogName, dogId);
        allDogs.Add(newDog);
      }

      if (rdr != null)
      {
        // rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }

      return allDogs;
    }

    public void Save()
    {
      SqlConnection conn = DB.Connection();
      conn.Open();

      SqlCommand cmd = new SqlCommand("INSERT INTO dogs (name) OUTPUT INSERTED.id VALUES (@DogName);", conn);
      SqlParameter name = new SqlParameter();
      name.ParameterName = "@DogName";
      name.Value = this._name;

      cmd.Parameters.Add(name);
      SqlDataReader rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        this._id = rdr.GetInt32(0);
      }
      if (rdr != null)
      {
        // rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
    }

  }
}
