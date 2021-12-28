using System;


namespace MapObjects
{
    public class Dwelling:IMake
    {
        public int Owner { get; set; }

        public void Make(Player player, object mapObject)
        {
            if (mapObject is Dwelling dwellingObj)
            {
                dwellingObj.Owner = player.Id;
                return;
            }
        }
    }
}
