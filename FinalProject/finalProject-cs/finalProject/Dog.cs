using System;
using System.Collections.Generic;

namespace finalProject
{
    public class Dog : Animal, ITrainable
    {
        private Dictionary<string, string> _behaviors = null;

        public Dog(string name, string gender, int age, string species) : base(name, gender, age, species)
        {
            _behaviors = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Behaviors
        {
            get { return _behaviors; }
            set { _behaviors = value; }
        }

        public override void Eat()
        {
            // I ran out of creativity for this part...
            Console.WriteLine("  The dog could have a specialized eat method.\n");
            base.Eat();
        }

        public void ListCommands()
        {
            if (_behaviors.Count > 0)
            {
                Console.WriteLine("\n");
                foreach (string Signal in _behaviors.Keys)
                {
                    bool hasValue = _behaviors.TryGetValue(Signal, out string behavior);
                    Console.WriteLine($"  The {Signal} command will make {base.Name} perform {behavior}.");
                }
            }
            else
            {
                Console.WriteLine($"\n  {base.Name} does not know any commands yet.\n  Try teaching some with the [train] option.");
            }
            
        }

        public string Train(string signal, string behavior)
        {
            while (Behaviors.ContainsKey(signal))
            {
                Console.WriteLine($"\n  {base.Name} already knows a behavior with that signal.\n" +
                    $"  You will need to use another signal.");
                signal = Validation.StringNotEmpty($"\n  Enter a different signal you will use for {behavior}: ");
            }

            string pronoun = "";
            if (base.Gender.ToLower() == "f")
            {
                pronoun = "her";
            }
            else if (base.Gender.ToLower() == "m")
            {
                pronoun = "him";
            }
            else
            {
                pronoun = "it";
            }

            Behaviors.Add(signal, behavior);
            return $"  {base.Name} learned to {behavior} when you give {pronoun} the signal: {signal}";
        }
    }
}
