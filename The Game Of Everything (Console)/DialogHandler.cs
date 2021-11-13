using DialogSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGOE;

namespace The_Game_Of_Everything
{
  /// <summary>
  /// Handles the progression through dialogs.
  /// </summary>
  public static class DialogHandler
  {
    public static void HandleSimpleDialog(Dialog dlg)
    {
      TextWriter.WriteDialog(dlg);
      Console.ReadKey();
    }

    public static void HandleChoiceDialog(ChoiceDialog dlg)
    {
      TextWriter.WriteDialog(dlg);
      Console.WriteLine();

      int bufferIndex = Console.CursorTop;
      int currentIndex = 0;
      ConsoleKey key = ConsoleKey.A;
      while (key != ConsoleKey.Enter)
      {
        TextWriter.WriteChoices(dlg.Choices, currentIndex, bufferIndex);
        key = Console.ReadKey().Key;

        if (key == ConsoleKey.UpArrow)
        {
          if (currentIndex - 1 < 0)
          {
            // todo: play sound
            continue;
          }
          else
            currentIndex--;
        }
        else if (key == ConsoleKey.DownArrow)
        {
          if (currentIndex + 1 >= dlg.Choices.Length)
          {
            // todo: play sound
            continue;
          }
          else
            currentIndex++;
        }
      }

      Console.WriteLine();
      var following = dlg.Choices[currentIndex].Following;

      if (following is ChoiceDialog cd)
        HandleChoiceDialog(cd);
      else if (following == null)
        return;
      else
        HandleSimpleDialog(following);


    }
  }
}