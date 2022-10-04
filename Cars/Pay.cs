using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Cars
{
    public partial class Pay : Form
    {
        readonly DetalDbContext db;
        public Pay(int id)
        {
            InitializeComponent();
            db = new DetalDbContext();
            db.Prices.Load();
            TablePr.DataSource = db.Prices.Local.ToBindingList();
            Id = id;
            Insert(Id);

        }
        public void Insert(int Id)
        {
            var busketl = db.baskets.Where(n => n.Id_user == Id).ToList();
            foreach (var item in busketl)
            {
                Price insert = db.Prices.Find(item.Id_detal);
                Tablbasket.Rows.Add(item.Id, insert.Name_detals, DateTime.Now, insert.PriceDetal);

            }
        }

        public int Id { get; set; }
        private void Pay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TablePr.SelectedRows.Count > 0)
            {
                int index = TablePr.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(TablePr[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Price price = db.Prices.Find(id);
                if (price.amount<=0)
                {
                    MessageBox.Show("Больше нет в наличии!!!!");
                   
                }
                else 
                {

                    Basket basket = new Basket();
                   
                    basket.Id_detal = id;
                    basket.Id_user = Id;
                    price.amount -= 1;
                    db.baskets.Add(basket);
                    db.SaveChanges();
                    TablePr.Refresh();
                    db.Prices.Load();
                    TablePr.DataSource = db.Prices.Local.ToBindingList();
                    TablePr.Refresh();
                    Tablbasket.Rows.Clear();
                    Insert(Id);

                }
                
            }
       }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tablbasket.SelectedRows.Count > 0)
            {
                int index = Tablbasket.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(Tablbasket[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Basket bs = db.baskets.Find(id);
                Price pr = db.Prices.Find(bs.Id_detal);
                pr.amount += 1;
                db.baskets.Remove(bs);
                Tablbasket.Rows.Clear();

                db.SaveChanges();
                TablePr.Refresh();
                db.Prices.Load();
                TablePr.DataSource = db.Prices.Local.ToBindingList();
                TablePr.Refresh();
                Insert(Id);




            }
        }
    }
}
