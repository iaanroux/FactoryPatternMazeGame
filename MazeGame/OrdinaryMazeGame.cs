using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeGameNS
{
    // Concrete OrdinaryMazeGame class
    public class OrdinaryMazeGame : MazeGame
    {
        protected override Room MakeRoom()
        {
            Console.WriteLine("I am an OrdinaryMaze Game");
            return new OrdinaryRoom();
        }
    }
}