using System.Collections.Generic;

namespace TGOE.Items.Storage
{
  /// <summary>
  /// Interface for anything that can store items.
  /// </summary>
  interface IStorage
  {
    /// <summary>
    /// The items in the storage.
    /// </summary>
    IReadOnlyList<Item> Items { get; }

    /// <summary>
    /// Combined weight of all the items in the storage.
    /// </summary>
    double ItemWeight { get; }

    /// <summary>
    /// Adds the given <paramref name="item"/> to the storage.
    /// </summary>
    /// <param name="item">Item to add.</param>
    void AddItem(Item item);

    /// <summary>
    /// Removes the given <paramref name="item"/> from the storage.
    /// </summary>
    /// <param name="item"></param>
    void RemoveItem(Item item);
  }
}