using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeGameNS
{
// Concrete OrdinaryRoom class
public class OrdinaryRoom : Room
{
    public override void Connect(Room room)
    {
        // Logic for connecting ordinary rooms
        Console.WriteLine($"I am a {this.ToString()} in the MazeGame to be connected to another {this.ToString()}");
    }
}
}