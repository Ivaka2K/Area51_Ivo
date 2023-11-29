using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public static class AgentExtensions
    {
        public static void Move(this Agent agent, Elevator elevator)
        {
            Random random = new Random();

            while (true)
            {
                Floor targetFloor = (Floor)random.Next(0, 4);

                Thread.Sleep(random.Next(1000, 5000));

                elevator.CallElevator(agent);

                if (elevator.OpenDoor(agent))
                {
                    elevator.MoveToFloor(targetFloor);
                    agent.CurrentFloor = targetFloor;
                }
            }
        }
    }
}

