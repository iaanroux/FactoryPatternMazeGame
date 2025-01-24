using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeGameNS
{
// Abstract MazeGame class
public abstract class MazeGame
{
    private readonly List<Room> _rooms = new List<Room>();

    protected MazeGame()
    {
        Room room1 = MakeRoom();
        Room room2 = MakeRoom();
        room1.Connect(room2);
        _rooms.Add(room1);
        _rooms.Add(room2);
    }

    protected abstract Room MakeRoom();
}

}