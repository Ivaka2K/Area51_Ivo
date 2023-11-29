using System;

namespace Area51 
{
    public enum SecurityLevel
    {
        Confidential,
        Secret,
        TopSecret
    }
    public enum Floor
    {
        G,
        S,
        T1,
        T2
    }
    class Program
     {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();

            Agent agent1 = new Agent { Name = "Agent 1", SecurityLevel = SecurityLevel.Confidential, CurrentFloor = Floor.G };
            Agent agent2 = new Agent { Name = "Agent 2", SecurityLevel = SecurityLevel.Secret, CurrentFloor = Floor.S };
            Agent agent3 = new Agent { Name = "Agent 3", SecurityLevel = SecurityLevel.TopSecret, CurrentFloor = Floor.T1 };

            // Simulate agents calling the elevator
            elevator.CallElevator(agent1);
            elevator.CallElevator(agent2);
            elevator.CallElevator(agent3);

            // Simulate agents moving around and using the elevator
            agent1.Move(elevator);
            agent2.Move(elevator);
            agent3.Move(elevator);

            Console.ReadLine();

        }
     }
}