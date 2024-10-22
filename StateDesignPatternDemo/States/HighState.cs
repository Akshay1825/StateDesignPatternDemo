using StateDesignPatternDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.States
{
    internal class HighState:IState
    {
        public void Handle(Fan fan)
        {
            Console.WriteLine("Turning fan Off");
            fan.SetState(new OffState());
        }
    }
}
