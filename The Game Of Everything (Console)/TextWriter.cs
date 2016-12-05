using System;
using System.Threading;
using TGOE;

namespace The_Game_Of_Everything
{
  /// <summary>
  /// Static class to print text to the console in different ways.
  /// </summary>
  static class TextWriter
  {
    #region Private Member

    /// <summary>
    /// The minimum time in ms to wait between character printing.
    /// </summary>
    private const int MINTEXTWAITMS = 75;

    /// <summary>
    /// The maximum time in ms to wait between character printing.
    /// </summary>
    private const int MAXTEXTWAITMS = 115;

    /// <summary>
    /// The default time in ms to wait after a new line in a <see cref="Dialog"/>.
    /// </summary>
    private const int NEWLINEWAITMS = 300;

    /// <summary>
    /// The minimum frequency to generate a beep with.
    /// </summary>
    private const int MINBEEPHZ = 800;

    /// <summary>
    /// The maximum frequency to generate a beep with.
    /// </summary>
    private const int MAXBEEPHZ = 1200;

    #endregion Private Member

    #region Public Functions

    /// <summary>
    /// Simply writes the given <paramref name="text"/> to 
    /// the console.
    /// </summary>
    /// <param name="text"></param>
    public static void WriteText(string text)
    {
      Console.Write(text);
    }

    /// <summary>
    /// Writes the given <paramref name="dialog"/> to the console.
    /// There will be a slight delay and sound between single characters.
    /// </summary>
    /// <param name="dialog">Dialog to write.</param>
    public static void WriteDialog(Dialog dialog)
    {
      Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
      foreach (string text in dialog.Lines)
      {
        foreach (char c in text)
        {
          Console.Write(c);
          int rndMs = rnd.Next(MINTEXTWAITMS, MAXTEXTWAITMS);
          if (c != ' ')
            Console.Beep(rnd.Next(MINBEEPHZ, MAXBEEPHZ), rndMs);
          Thread.Sleep(rndMs);
        }

        Console.WriteLine();
        Thread.Sleep(NEWLINEWAITMS);
      }
    }

    #endregion Public Functions
  }
}