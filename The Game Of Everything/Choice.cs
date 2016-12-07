namespace TGOE
{
  /// <summary>
  /// Represents a single choice in a <see cref="ChoiceDialog"/>.
  /// </summary>
  public class Choice
  {
    #region Properties

    /// <summary>
    /// The text that this choice is displayed with.
    /// </summary>
    public string Text
    {
      get { return _text; }
      private set { _text = value; }
    }
    private string _text;

    /// <summary>
    /// The dialog following the selection of this choice.
    /// </summary>
    public Dialog Following
    {
      get { return _following; }
      private set { _following = value; }
    }
    private Dialog _following;

    #endregion Properties

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="text">Display text</param>
    /// <param name="following">Following dialog.</param>
    public Choice(string text, Dialog following)
    {
      Text = text;
      Following = following;
    }
  }
}