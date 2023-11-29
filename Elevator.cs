using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public class Elevator
    {
        private Floor currentFloor;

        public Elevator()
        {
            currentFloor = Floor.G;
        }

        public void MoveToFloor(Floor targetFloor)
        {
            Console.WriteLine($"Elevator moving from {currentFloor} to {targetFloor}...");
            Thread.Sleep(1000); 
            currentFloor = targetFloor;
            Console.WriteLine($"Elevator arrived at {currentFloor} floor.");
        }

        public bool OpenDoor(Agent agent)
        {
            Console.WriteLine($"Security check for {agent.Name} with {agent.SecurityLevel} credentials...");

            bool hasAccess = agent.SecurityLevel >= currentFloor.GetRequiredSecurityLevel();

            if (hasAccess)
            {
                Console.WriteLine("Security check passed. Opening the door.");
            }
            else
            {
                Console.WriteLine("Security check failed. Door remains closed.");
            }

            return hasAccess;
        }
    }
    
}
