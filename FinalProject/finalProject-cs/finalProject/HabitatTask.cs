using System;
namespace finalProject
{
    public class HabitatTask
    {
        private string _name;
        private int _frequency;
        private DateTime _lastPerformed;

        public HabitatTask(string name, int frequency)
        {
            _name = name;
            _frequency = frequency;
        }

        public string Name
        {
            get { return _name; }
        }
        public int Frequency
        {
            get { return _frequency; }
        }

        public int LastPerformed
        {
            get
            {
                DateTime today = DateTime.Now;
                DateTime last  = _lastPerformed;
                Double   days  = Math.Round((today - last).TotalDays);
                int    intDays = Convert.ToInt32(days);

                if (intDays > 1825)
                {
                    return -1;
                }
                return intDays;
            }
        }

        public bool IsTaskDue()
        {
            if (LastPerformed >= _frequency)
            {
                return true;
            }
            else if (LastPerformed == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CompleteTask()
        {
            _lastPerformed = DateTime.Now;
            Console.WriteLine($"  Marked {_name} complete!");
        }
    }
}
