using Dungeon_Crawl.src.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl.src
{
    internal interface IItem
    {
        string GetName();

        void Use(Player player);
    }
}