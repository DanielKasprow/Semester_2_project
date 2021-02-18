using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WindowsFormsApp1
{
    class Akcja : Wydarzenie
    {
        protected int zuzytaamunicja, szkodymienia;
        protected string szef, iloscprzestepcow;
        protected int[] amunicja = new int[10];

        public string ADD;

        public static Akcja operator +(Akcja aaa1, Akcja aaa2)
        {
            Akcja aaa3 = aaa1.Add(aaa2);
            return aaa3;
        }
        public Akcja Add(Akcja aaa)
        {
            Akcja aaa3 = new Akcja();
            aaa3.ADD = this.ADD + aaa.ADD;
            return aaa3;
        }
        public static bool operator ==(Akcja aaa1, Akcja aaa2)
        {
            if ((aaa1.koszt == aaa2.koszt) && (aaa1.iloscpolicjantow == aaa2.iloscpolicjantow))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Akcja aaa1, Akcja aaa2)
        {
            if (!(aaa1 == aaa2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Akcja() : base()
        {
            iloscprzestepcow = "0";
            zuzytaamunicja = 0;
            szkodymienia = 0;
            szef = "...";
            koszt = 0;
            iloscpolicjantow = 0;
            ADD = "";
        }

        public Akcja(string miejscowosc, string budynek, string glownodowodzacy, int allpolicjantow, int iloscpolicjantow, int koszt, int allRadiowoz, int uzyRadiowoz, DateTime startakcji, DateTime koniecakcji, Bitmap pic, string iloscprzestepcow, int zuzytaamunicja, int szkodymienia, string szef) : base(miejscowosc, budynek, glownodowodzacy, iloscpolicjantow, allpolicjantow, koszt, allRadiowoz, uzyRadiowoz, startakcji, koniecakcji, pic)
        {
            this.iloscprzestepcow = iloscprzestepcow;
            this.zuzytaamunicja = zuzytaamunicja;
            this.szkodymienia = szkodymienia;
            this.szef = szef;
        }
        public Akcja(Akcja policja) : base()
        {
            iloscprzestepcow = policja.iloscprzestepcow;
            zuzytaamunicja = policja.zuzytaamunicja;
            szkodymienia = policja.szkodymienia;
            szef = policja.szef;
         }

        override public void Write(ListBox lp, PictureBox kl)
        {
            base.Write(lp, kl);
            lp.Items.Add(iloscprzestepcow);
            lp.Items.Add("Zuzyta amunicja: " + zuzytaamunicja);
            lp.Items.Add("Zuzyta amunicja na osobe: " + Amunicja());
            lp.Items.Add("Szkody mienia: " + szkodymienia + "zł");
            lp.Items.Add("Rodzaj przewinienia: " + szef);
            lp.Items.Add(calkoszt());
            lp.Items.Add("");
            kl.Image = pic;
        }
        override public void Write(ListBox lp)
        {
            base.Write(lp);
            lp.Items.Add(iloscprzestepcow);
            lp.Items.Add("Zuzyta amunicja: " + zuzytaamunicja);
            lp.Items.Add("Zuzyta amunicja na osobe: " + Amunicja());
            lp.Items.Add("Szkody mienia: " + szkodymienia + "zł");
            lp.Items.Add("Rodzaj przewinienia: " + szef);
            lp.Items.Add(calkoszt());
            lp.Items.Add("");
        }
        string Amunicja()
        {
            var rand = new Random();
            string ammo = "";
            int limit = zuzytaamunicja, number;
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    ammo = ammo + limit + " ";
                }
                else
                {
                    number = (rand.Next(limit + 1));
                    ammo = ammo + number + " ";
                    limit = limit - number;
                }
            }
            return ammo;
        }
        string calkoszt()
        {
            int koszty = koszt + szkodymienia;
            string cal = "Całkowity koszt: " + koszty + "zl";
            return cal;
        }
        public override void Zapisz(StreamWriter wr)
        {
            nazwa = "Akcja";
            base.Zapisz(wr);
            wr.WriteLine(iloscprzestepcow.ToString());
            wr.WriteLine(zuzytaamunicja.ToString());
            wr.WriteLine(szkodymienia.ToString());
            wr.WriteLine(szef);
        }
        public override void Czytaj(StreamReader sr)
        {
            base.Czytaj(sr);
            iloscprzestepcow = sr.ReadLine();
            zuzytaamunicja = Convert.ToInt32(sr.ReadLine()); 
            szkodymienia = Convert.ToInt32(sr.ReadLine()); 
            szef = sr.ReadLine(); 
        }
    }
}
