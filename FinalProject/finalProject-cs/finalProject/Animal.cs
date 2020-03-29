using System;
using System.Collections.Generic;
using System.IO;
namespace finalProject
{
    public class Animal
    {
        private string  _name;
        private string  _gender;
        private int     _age;
        private string _species;
        private Diet _diet;
        private List<HabitatTask> _habitatTasks;

        public Animal(string name, string gender, int age, string species)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _species = species;
            _diet = new Diet();
            _habitatTasks = new List<HabitatTask>();
        }

        public string Name
        {
            get { return _name; }
        }
        public string Gender
        {
            get { return _gender; }
        }
        public int Age
        {
            get { return _age; }
        }
        public string Species
        {
            get { return _species; }
        }
        public List<HabitatTask> Tasks
        {
            get { return _habitatTasks; }
        }

        public virtual void Eat()
        {
            string foodChoice = "";

            // Check if the diet has any items and if not, give the wizard to add items
            if (!_diet.HasDiet())
            {
                AddToDiet();
            }

            // Get the user's choice for a food item or to create a new one
            _diet.ListDiet();
            foodChoice = Validation.StringNotEmpty($"\n  Choose a food to feed {_name}\n  Or enter 'new' to add a new dietary item: ");
            while (foodChoice.ToLower() == "new")
            {
                AddToDiet();
                _diet.ListDiet();
                foodChoice = Validation.StringNotEmpty($"\n  Choose a food to feed {_name}\n  Or enter 'new' to add a new dietary item: ");
            }

            // Loop to get the correct item to feed
            while (!_diet.CanEat(foodChoice))
            {
                Console.WriteLine($"  {foodChoice} is not a part of {_name}'s diet.");
                foodChoice = Validation.StringNotEmpty($"  Choose a food to feed {_name}: ");
            }

            // Eat the food
            _diet.EatFoodItem(foodChoice, _name);
        }

        public void AddToDiet()
        {
            string foodChoice = Validation.StringNotEmpty($"  Enter a food to add to {_name}'s diet: ");
            decimal qty = Validation.GetDecimal($"  How many grams of {foodChoice} does {_name} eat? ");
            _diet.AddDietItem(foodChoice, qty);
        }

        // This method grew to be quite large and cumbersome. With more time, I
        // would have liked to refactor this to be more organized
        // It also does more than the name implies, which is not ideal...
        public void ListHabitatTasks()
        {
            bool addingTasks = true;
            while (addingTasks)
            {
                Console.Clear();
                Console.WriteLine("\n  --  Habitat Maintenance  --\n");

                if (_habitatTasks.Count == 0)
                {
                    Console.WriteLine("  This animal has no habitat tasks created.\n");
                }
                else
                {
                    foreach (HabitatTask t in _habitatTasks)
                    {
                        string lastPerformed = "Never";

                        if (t.LastPerformed > -1 && t.LastPerformed < 1)
                        {
                            lastPerformed = "Today";
                        }
                        else if (t.LastPerformed != -1)
                        {
                            lastPerformed = t.LastPerformed.ToString() + " days ago";
                        }

                        Console.WriteLine(
                            $"   {_habitatTasks.IndexOf(t) + 1}. {t.Name}\n" +
                            $"          Repeats every {t.Frequency} days\n" +
                            $"          Is due: {t.IsTaskDue().ToString()}\n" +
                            $"          Last Completed: {lastPerformed}");
                    }
                    Console.WriteLine("\n");
                }

                Console.WriteLine("   Commands: [cancel] [new]");

                string choice = Validation.StringNotEmpty("\n  Please choose a task number or other command: ").ToLower();
                // Try to parse the input to see if it was a number
                Int32.TryParse(choice, out int intChoice);
                intChoice -= 1;
                if (choice == "cancel")
                {
                    // Break out of the loop if they say cancel
                    break;
                }
                else if (choice == "new")
                {
                    // Add a single task if they say new and then loop unti lthey want to be done
                    AddToHabitatTasks();
                    string keepAdding = Validation.StringNotEmpty("\n  Add another task? (y/n): ").ToLower();
                    switch (keepAdding)
                    {
                        case "y":
                        case "yes":
                            {
                                AddToHabitatTasks();
                            }
                            break;
                        case "n":
                        case "no":
                            {
                                addingTasks = false;
                            }
                            break;
                        default:
                            {
                                Console.Write($"  Invalid entry: {keepAdding}\n  Press any key to continue: ");
                                Console.ReadKey(true);
                            }
                            break;
                    }

                }
                else if (intChoice >= 0 && intChoice < _habitatTasks.Count)
                {
                    // make a temporary task from the one we picked to complete it
                    // This could probably be condensed to:
                    // _habitatTasks[intChoice].CompleteTask();
                    HabitatTask tmpTask = _habitatTasks[intChoice];
                    tmpTask.CompleteTask();
                }
                else
                {
                    Console.Write($"  Invalid entry: {intChoice+1}\n  Press any key to continue: ");
                    Console.ReadKey(true);
                }
            }
        }

        public void AddToHabitatTasks()
        {
            // Fairly self explanatory. This one adds the tasks to the animal's list
            Console.Clear();
            Console.WriteLine("\n  --  New Habitat Task  --\n");
            string taskName = Validation.StringNotEmpty("  Enter the name for this task:  ");
            int taskFrequency = Validation.GetInt("  How many days should pass between performing this task: ");

            HabitatTask newTask = new HabitatTask(taskName, taskFrequency);
            _habitatTasks.Add(newTask);

            Console.WriteLine($"\n  Successfully added {taskName} to {_name}'s habitat checklist!");
        }
    }
}
