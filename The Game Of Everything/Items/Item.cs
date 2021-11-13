using System;

namespace TGOE.Items
{
  /// <summary>
  /// Base class for all items.
  /// </summary>
  public abstract class Item
  {
    #region Construction

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="name">Name of the item.</param>
    /// <param name="description">Description of the item.</param>
    /// <param name="weight">Weight of the item in kilo.</param>
    public Item(string name, string description, double weight)
    {
      Name = name;
      Description = description;
      Weight = weight;
    }

    #endregion Construction

    #region Properties

    /// <summary>
    /// Name of the item.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Description of the item.
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Weight of the item in kilo.
    /// </summary>
    public double Weight
    {
      get => _weight;
      private set
      {
        if (value <= 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Weight can't be <= 0");

        if (Weight != value)
          _weight = value;
      }
    }
    private double _weight;

    #endregion Properties
  }
}