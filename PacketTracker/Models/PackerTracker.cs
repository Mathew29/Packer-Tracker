using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    private string _description;
    private int _id;
    private static List<Item> _instances = new List<Item> {};
    private bool _packed;

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
      _packed = false;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public bool GetPacked()
    {
      return _packed;
    }

    public void SetPacked()
    {
      if(_packed == true)
      {
        _packed = false;
      }
      else
      {
        _packed = true;
      }
    }
  }
}
