using System;

namespace MapObjects
{
    public class Mine:IMake
    {
        public int Owner { get; set; }
        public Army Army { get; set; }
        public Treasure Treasure { get; set; }

        public void Make(Player player, object mapObject)
        {
            if (mapObject is Mine mineObj)
            {
                if (player.CanBeat(mineObj.Army))
                {
                    mineObj.Owner = player.Id;
                    player.Consume(mineObj.Treasure);
                }
                else player.Die();
                return;
            }
        }
    }
}
