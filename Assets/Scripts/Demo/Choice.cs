using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame.Engine
{
    public struct Choice
    {
        public string text;
        public Action action;

        public Choice(string choiceText, Action choiceAction)
        {
            text = choiceText;
            action = choiceAction;
        }
    }
}
