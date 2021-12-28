using System;

namespace MapObjects
{
    public static class Interaction
    {

        public static void Make(Player player, object mapObject)
        {
            // Далее используйте сокращенный синтаксис преобразования типа:
            // mapObject is Dwelling dwellingObj
            // Он позволяет не производить множественных преобразований таких, как
            // ((Dwelling)mapObject).Owner = player.Id;
            // а сразу обращаться к объекту, если он является каким-то классом.
            // dwellingObj.Owner = player.Id;

            if (mapObject is Dwelling dwelling) { 
            dwelling.Make(player, mapObject); }

            // Перед выполнение задания используйте преобразование типа вместе с is
            // и избавьтесь от повторяющихся явных преобразований типа
            if (mapObject is Mine mine)
            {

                mine.Make(player, mapObject);
            }

            if (mapObject is Creeps creeps)
            {
                creeps.Make(player, mapObject);
            }
            if (mapObject is ResourcePile pile)
            {
                pile.Make(player, mapObject);
            }
        }
    }
    public interface IMake
    {
        void Make(Player player, object mapObject);
    }
}
