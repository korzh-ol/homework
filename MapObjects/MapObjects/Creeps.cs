using System;

namespace MapObjects
{
    public class Creeps:IMake
    {
        public Army Army { get; set; }
        public Treasure Treasure { get; set; }

        public void Make(Player player, object mapObject)
        {
            if (mapObject is Creeps creepsObj)
            {
                if (player.CanBeat(creepsObj.Army))
                    player.Consume(creepsObj.Treasure);
                else
                    player.Die();
                return;
            }
        }
    }
}
