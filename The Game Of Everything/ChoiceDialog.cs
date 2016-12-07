using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGOE
{
  public class ChoiceDialog : Dialog
  {
    #region Properties

    public Choice[] Choices
    {
      get { return _choices; }
      private set { _choices = value; }
    }
    private Choice[] _choices;

    #endregion Properties

    public ChoiceDialog(string[] lines, Choice[] choices) : base(lines)
    {
      Choices = choices;
    }

    public ChoiceDialog(string line, Choice[] choices) : base(line)
    {
      Choices = choices;
    }
  }
}
