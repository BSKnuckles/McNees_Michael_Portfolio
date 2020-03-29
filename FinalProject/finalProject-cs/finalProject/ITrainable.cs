using System;
using System.Collections.Generic;

namespace finalProject
{
    public interface ITrainable
    {
        Dictionary<string, string> Behaviors { get; set; }
        void ListCommands();
        string Train(string signal, string behavior);
    }
}
