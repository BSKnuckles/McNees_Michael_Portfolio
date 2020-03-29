using System;
using System.Collections.Generic;

namespace finalProject
{
    public class Diet
    {
        private Dictionary<string, decimal> _diet = null;

        public Diet()
        {
            _diet = new Dictionary<string, decimal>();
        }

        // Add item to the diet dictionary
        public void AddDietItem(string food, decimal quantity)
        {
            _diet.Add(food, quantity);
            Console.WriteLine($"\n  Successfully added {food} to the diet!");
        }

        // Eat one fo the items in the list
        // Could be interesting to expand it to track an inventory of food
        public void EatFoodItem(string food, string petName)
        {
            if (_diet.ContainsKey(food))
            {
                _diet.TryGetValue(food, out decimal qty);
                Console.WriteLine($"\n  {petName} ate {qty} grams of {food}!");
            }
            else
            {
                Console.WriteLine($"\n  {petName} doesn't eat {food}.");
            }
        }

        public bool CanEat(string food)
        {
            if (_diet.ContainsKey(food))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasDiet()
        {
            if (_diet.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // In hindsight, this probably should have built a string and returned it
        // rather than printing out directly. Working through the project in JS
        // made some of these types of separations more obvious
        public void ListDiet()
        {
            Console.WriteLine("  \n  - Diet Options -");
            foreach (string food in _diet.Keys)
            {
                decimal qty;
                _diet.TryGetValue(food, out qty);

                Console.WriteLine($"   {food}: {qty} grams");
            }
        }
    }
}
