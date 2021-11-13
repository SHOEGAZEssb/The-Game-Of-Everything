using DialogSystem;
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
      //TextWriter.WriteDialog(new Dialog(new string[] { "This is a test.", "With multiple lines!", "And this sentence has a lot of words to see how the method behaves!" }));
      ChoiceDialog d2 = new ChoiceDialog("Wowzers", new Choice[] { new Choice("Continue?", new Dialog("Henlo")), new Choice("Uwu", new Dialog("RAWR x3")) });
      ChoiceDialog d = new ChoiceDialog("Does this work?", new Choice[] { new Choice("Yes", d2), new Choice("No", new Dialog("Sad")), new Choice("Maybe", new Dialog("Make up your mind!") )});
      DialogHandler.HandleChoiceDialog(d);
    }
  }
}
