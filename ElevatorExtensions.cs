using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public static class ElevatorExtensions
    {
        public static void CallElevator(this Elevator elevator, Agent agent)
        {
            Console.WriteLine($"{agent.Name} is calling the elevator on floor {agent.CurrentFloor}.");
            elevator.MoveToFloor(agent.CurrentFloor);
        }
    }
}
