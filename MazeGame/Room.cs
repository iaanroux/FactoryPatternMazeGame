using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeGameNS
{
// Abstract Room class
public abstract class Room
{
    public abstract void Connect(Room room);
}
}