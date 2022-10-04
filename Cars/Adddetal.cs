using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Adddetal : Form
    {
        readonly DetalDbContext db = new DetalDbContext();
        public Adddetal()
        {
            InitializeComponent();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GenerB.Text!=""||NameB.Text!=""||AmountB.Text!= "00000000000000000000" 
                ||Price.Text != "00000000000000000000")
            {
                Price price = new Price();
                price.Name_detals = NameB.Text;
                price.Params = GenerB.Text;
                price.amount =Convert.ToInt32(AmountB.Text);
                price.PriceDetal = Convert.ToInt32(Price.Text);
                db.Prices.Add(price);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Введите все даные!!!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
