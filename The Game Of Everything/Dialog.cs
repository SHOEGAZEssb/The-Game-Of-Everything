namespace TGOE
{
  /// <summary>
  /// Represents a basic dialog.
  /// Basic means, no input afterwards.
  /// (Expect for a button press to discard the dialog).
  /// </summary>
  public class Dialog
  {
    #region Properties

    /// <summary>
    /// The text of the dialog.
    /// </summary>
    public string[] Lines { get; private set; }

    #endregion Properties

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="lines">Text of the dialog.</param>
    public Dialog(string[] lines)
    {
      Lines = lines;
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="line">Text of the dialog.</param>
    public Dialog(string line)
    {
      Lines = new string[] { line };
    }
  }
}