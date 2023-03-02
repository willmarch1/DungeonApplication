using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Room
    {
        public Monster RoomMonster { get; set; }
        public string RoomDescription { get; set; }


        public override string ToString()
        {
            return $"{RoomDescription}\n\nOpponent:{RoomMonster}";
        }


    }

    
}
