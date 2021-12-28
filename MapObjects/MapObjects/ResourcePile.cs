using System;

namespace MapObjects
{
    public class ResourcePile : IMake
    {
        public Treasure Treasure { get; set; }

        public void Make(Player player, object mapObject)
        {

            if (mapObject is ResourcePile resourcePileObj)
            {
                player.Consume(resourcePileObj.Treasure);
                return;
            }
        }
    }
}
