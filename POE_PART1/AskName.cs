using System;

using System.Text.RegularExpressions;
using System.Threading;

namespace POE_PART1
{
    public class AskName
    {
        private string name;
       

        public string Name
        {

            get
            { return name; }

            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;


                }
                else
                {
                    Console.WriteLine("The field can not be empty\nTry again");



                }


                if (Name.Length < 2)
                {
                    TypeText("Name has to be 2 characters long\nTry again", 25);
                    Name = Console.ReadLine();

                }
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    TypeText("Name should be in letters\nTry again", 25);
                    Name = Console.ReadLine();

                }


                TypeText($"Welcome to the app bro {name}", 25);
                Console.WriteLine();
            }
        }

    
      public void TypeText(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}
