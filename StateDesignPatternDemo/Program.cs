using StateDesignPatternDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan();
            fan.Turn();
            fan.Turn(); 
            fan.Turn();
        }
    }
}
