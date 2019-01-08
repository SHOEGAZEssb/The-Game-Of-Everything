using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TGOE;

namespace The_Game_Of_Everything
{
  class Program
  {
    static void Main(string[] args)
    {
      TextWriter.WriteDialog(new Dialog(new string[] { "This is a test.", "With multiple lines!", "And this sentence has a lot of words to see how the method behaves!" }));
      ChoiceDialog d = new ChoiceDialog("Does this work?", new Choice[] { new Choice("Yes", new Dialog("Cool.")), new Choice("No", new Dialog("Sad")), new Choice("Maybe", new Dialog("Make up your mind!") )});
      DialogHandler.HandleChoiceDialog(d);
    }
  }
}
