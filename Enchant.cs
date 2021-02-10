using System;
using System.Collections.Generic;
using System.Text;

namespace EnchIO
{
    abstract class Enchant 
    {
        public static double[,] Chances = { { 100, 95, 90, 85, 80, 75, 70, 65, 60, 55 }, 
                                     { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 },
                                     { 100, 85, 70, 55, 40, 25, 10, 5, 1, 0.1 } };

        public static void TryEnchant(Item item)
        {
            if (item.enchLevel < 10)
            {
                int rar = (int)item.rarity;
                Random rnd = new Random();
                double num = rnd.NextDouble() * 100;
                if (num <= Chances[rar, item.enchLevel])
                {
                    item.enchLevel++;
                    return;
                }
                item.enchLevel = 0;
            }
        }
    }
}
