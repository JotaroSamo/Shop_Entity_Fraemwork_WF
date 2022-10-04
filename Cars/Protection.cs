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
    public partial class Protection : Form
    {
        readonly DetalDbContext db;
        public Protection(bool f)
        {
            InitializeComponent();
            db = new DetalDbContext();
            F = f;
        }
        public bool F { get; set; }
        private void Protection_Load(object sender, EventArgs e)
        {

        }
        public void button2_Click(object sender, EventArgs e)
        {
            var serch = db.userAnds.ToList();
            bool d = false;
            switch (F)
            {

                case true:
                   
                    foreach (var item in serch)
                    {
                        if (item.Login == loginB.Text && item.Password == PasswordB.Text && item.Priority == 1)
                        {
                            Adddetal open = new Adddetal();
                            DialogResult result = open.ShowDialog();
                            if (result == DialogResult.Cancel)
                            {
                                return;
                            }

                            break;
                        }
                        else if (item.Login == loginB.Text && item.Password == PasswordB.Text && item.Priority == 0)
                        {
                            Pay open = new Pay(item.Id);
                                this.Hide();
                            open.Show();
                        }

                    }
                    break;
                case false:
                    foreach (var item in serch)
                    {
                        if (item.Login == loginB.Text && item.Priority == 0)
                        {
                            MessageBox.Show("Такой пользователь уже есть!!!!");
                            d = false;
                            break;
                        }
                        else
                        {
                            d = true;
                        }

                    }
                    if (d==true)
                    {
                        UserAnd_Admin add = new UserAnd_Admin();
                        add.Login = loginB.Text;
                        add.Password = PasswordB.Text;
                        add.Priority = 0;
                        db.userAnds.Add(add);
                        db.SaveChanges();
                        MessageBox.Show("Успешная регестрация");
                        this.Hide();

                    }
                    break;
            }
            
           
        }
    }
}
