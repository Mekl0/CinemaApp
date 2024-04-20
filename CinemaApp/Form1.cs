using CinemaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void AddItem(Film item)
        {
            using (var db = new DbBaglanti())
            {
                db.Filmler.Add(item);
                db.SaveChanges();
            }
        }
        void DeleteItem(int id)
        {
            using (var db = new DbBaglanti())
            {
                var item = db.Filmler.Find(id);
                if (item == null) return;
                db.Filmler.Remove(item);
                db.SaveChanges();
            }
        }

                private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] seanslist=new string[5];
            Film film = new Film();
            film.Ad = textBox1.Text.ToString();
            seanslist.Append(textBox2.Text.ToString());
            film.Seanslar = seanslist;
            
            
            
        }

    }
}
