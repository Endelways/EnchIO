using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnchIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Weapon weapon = new Weapon(Image.FromFile("D:\\my\\Projects\\Coding\\C#\\EnchIO\\EnchIO\\EnchIO\\img\\sword.png"), Item.ItemRarity.White, 1, 1, 0.2), 
            weapon2 = new Weapon(Image.FromFile("D:\\my\\Projects\\Coding\\C#\\EnchIO\\EnchIO\\EnchIO\\img\\sword2.png"), Item.ItemRarity.Blue, 2, 10, 0.1), 
            weapon3 = new Weapon(Image.FromFile("D:\\my\\Projects\\Coding\\C#\\EnchIO\\EnchIO\\EnchIO\\img\\sword3.png"), Item.ItemRarity.Yellow, 10, 100, 0.5),
            selWeapon;

        PictureBox selBox;
        Label selLabel;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selWeapon = weapon3;
            selLabel = parameters3;
            selBox = pb3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selWeapon = weapon2;
            selLabel = parameters2;
            selBox = pb2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selWeapon = weapon;
            selLabel = parameters;
            selBox = pb;
        }

        private void EnchBtn_Click(object sender, EventArgs e)
        {
            Enchant.TryEnchant(selWeapon);
            selBox.Image = selWeapon.Img;
            selLabel.Text = $"DPS : { selWeapon.DamagePerSecond()}\n" +
                              $"EnchLvl : {selWeapon.enchLevel}\n" +
                              $"Rarity : {selWeapon.Rarity}\n" +
                              $"Power: {selWeapon.Power}\n" +
                              $"Speed: {selWeapon.Speed}\n" +
                              $"Cost: {selWeapon.Cost}";
        }
    }
}