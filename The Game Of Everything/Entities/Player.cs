using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGOE.Items;
using TGOE.Items.Storage;

namespace TGOE.Entities
{
  /// <summary>
  /// The main playable entity.
  /// </summary>
  public class Player
  {
    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    public Player()
    {
      _inventory = new Inventory();
    }

    #endregion Construction

    #region Items

    /// <summary>
    /// The items that the player possesses.
    /// </summary>
    public IReadOnlyList<Item> Items => _inventory.Items;
    private Inventory _inventory;

    /// <summary>
    /// Combined weight of all the items of the player.
    /// </summary>
    public double ItemWeight => _inventory.ItemWeight;

    public void AddItem(Item item)
    {
      _inventory.AddItem(item);
    }

    public void RemoveItem(Item item)
    {

    }

    #endregion Items
  }
}