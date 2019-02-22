using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame.Engine
{
    public class Prompt
    {
        public string text;
        public List<Choice> choices = new List<Choice>();

        public Prompt(string promptText)
        {
            text = promptText;
        }

        public Prompt(string promptText, List<Choice> promptChoices)
        {
            text = promptText;
            choices = promptChoices;
        }

        public static void RunPrompt(Prompt prompt)
        {
            Console.WriteLine(prompt.text);
            for (int i = 0; i < prompt.choices.Count; i++)
            {
                Console.WriteLine("[" + (i+1) + "] " + prompt.choices[i].text);
            }
            Console.WriteLine();
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case int i when (i >= 0 && i <= prompt.choices.Count):
                    prompt.choices[i-1].action();
                break;
            }
            Console.ReadKey();
        }
    }
}