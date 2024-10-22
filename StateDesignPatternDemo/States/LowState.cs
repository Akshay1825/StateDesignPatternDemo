using StateDesignPatternDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.States
{
    internal class LowState:IState
    {
        public void Handle(Fan fan)
        {
            Console.WriteLine("Turning fan to High speed");
            fan.SetState(new HighState());
        }

    }
}
