using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static shop.ShopObserver;

namespace shop
{
    public partial class Form1 : Form
    {
        private Shop shop;

        public Form1()
        {
            InitializeComponent();
            shop = new Shop();
            shop.RegisterObserver(new ShopObserver(pictureBox1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shop.SetShop(ShopType.Refrigerator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shop.SetShop(ShopType.Kettle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shop.SetShop(ShopType.Micro);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shop.SetShop(ShopType.Mixer);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
