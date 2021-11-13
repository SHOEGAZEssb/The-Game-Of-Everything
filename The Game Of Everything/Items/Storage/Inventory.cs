using System;
using System.Collections.Generic;
using System.Linq;

namespace TGOE.Items.Storage
{
  /// <summary>
  /// Basic item storage.
  /// </summary>
  class Inventory : IStorage
  {
    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    public Inventory()
    {
      _items = new List<Item>();
    }

    #endregion Construction

    /// <summary>
    /// The items in the inventory.
    /// </summary>
    public IReadOnlyList<Item> Items => _items.AsReadOnly();
    private readonly List<Item> _items;

    /// <summary>
    /// Combined weight of all the items in the storage.
    /// </summary>
    public double ItemWeight => Items.Sum(i => i.Weight);

    /// <summary>
    /// Adds the given <paramref name="item"/> to the inventory.
    /// </summary>
    /// <param name="item">Item to add.</param>
    /// <exception cref="ArgumentNullException">
    /// When <paramref name="item"/> is null.</exception>
    public void AddItem(Item item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof(item));

      _items.Add(item);
    }

    /// <summary>
    /// Removes the given <paramref name="item"/> from the inventory.
    /// </summary>
    /// <param name="item">Item to remove.</param>
    /// <exception cref="ArgumentNullException">
    /// When <paramref name="item"/> is null.</exception>
    /// <exception cref="ArgumentException">
    /// When the given <paramref name="item"/> is not contained in the inventory.</exception>
    public void RemoveItem(Item item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof(item));
      if (!Items.Contains(item))
        throw new ArgumentException(nameof(item), "Item not in the inventory");

      _items.Remove(item);
    }
  }
}