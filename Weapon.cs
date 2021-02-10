using System.Drawing;

namespace EnchIO
{
    class Weapon : Item
    {
        public Weapon(Image Img, ItemRarity Rarity, int Cost, int Power, double Speed)
        {
            this.Img = Img;
            this.Rarity = Rarity;
            this.Cost = Cost;
            this.Power = Power;
            this.Speed = Speed;
        }

        public Image Img { get { return img; }  set { img = value;  } }
        public ItemRarity Rarity { get { return rarity; } set { rarity = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public int Power { get; set; }
        public double Speed { get; set; }
        
        public int EnchLevel { get { return enchLevel; } }
        public double DamagePerSecond() { return Power / Speed; }
        
    }
}
