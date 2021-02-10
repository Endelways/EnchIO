using System.Drawing;

namespace EnchIO
{
    public class Item
    {
        public enum ItemRarity
        {
            White,
            Blue,
            Purple,
            Yellow,
            Green,
            Black
        }

        protected Image img;
        public ItemRarity rarity;
        protected int cost;
        public int enchLevel = 0; 
/*        protected Item(Image Img, ItemRarity Rarity, int Cost)
        {
            this.img = Img;
            this.rarity = Rarity;
            this.cost = Cost;

        } */

    }
}