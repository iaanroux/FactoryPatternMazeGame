using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeGameNS
{
// Concrete MagicMazeGame class
public class MagicMazeGame : MazeGame
{
    protected override Room MakeRoom()
    {
        Console.WriteLine("I am a MagicMaze Game");
        return new MagicRoom();
    }
}
}