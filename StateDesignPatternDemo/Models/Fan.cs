using StateDesignPatternDemo.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.Models
{
    internal class Fan
    {
        IState _currentState;

        public Fan()
        {
            _currentState = new OffState();
        }

        public void SetState(IState newState)
        {
            _currentState = newState;
        }

        public void Turn()
        {
            _currentState.Handle(this);
        }
    }
}
