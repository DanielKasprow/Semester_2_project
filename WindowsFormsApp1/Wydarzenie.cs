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
    public class Wydarzenie : IComparable<Wydarzenie>
    {
        public string nazwa = "";
        protected string miejscowosc, budynek,glownodowodzacy;

        protected int iloscpolicjantow,allpolicjantow, koszt,allRadiowoz,uzyRadiowoz;

        protected DateTime startakcji,koniecakcji;

        protected Bitmap pic;

        //Konstruktor bezargumentowy (domyślny)
        public Wydarzenie()
        {
            miejscowosc = "...";
            budynek = "...";
            glownodowodzacy = "...";
            startakcji = new DateTime(2019, 1, 1, 0, 0, 0);
            koniecakcji = new DateTime(2020, 1, 1, 0, 0, 0);
            allRadiowoz = 10;
            uzyRadiowoz = 0;
            iloscpolicjantow = 0;
            koszt = 0;
            pic = new Bitmap ("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg");
        }

        //Konstruktor wieloargumentowy
        public Wydarzenie(string miejscowosc,string budynek,string glownodowodzacy,int allpolicjantow,int iloscpolicjantow,int koszt,int allRadiowoz,int uzyRadiowoz,DateTime startakcji,DateTime koniecakcji,Bitmap pic)
        {
            this.miejscowosc= miejscowosc;
            this.budynek=budynek;
            this.glownodowodzacy = glownodowodzacy;
            this.allpolicjantow = allpolicjantow;
            this.iloscpolicjantow=iloscpolicjantow;
            this.koszt=koszt;
            this.allRadiowoz = allRadiowoz;
            this.uzyRadiowoz = uzyRadiowoz;
            this.startakcji = startakcji;
            this.koniecakcji = koniecakcji;
            this.pic = pic;
        }

        //Konstruktor kopiujący
        public Wydarzenie(Wydarzenie policja)
        {
            miejscowosc = policja.miejscowosc;
            budynek = policja.budynek;
            glownodowodzacy = policja.glownodowodzacy;
            allpolicjantow = policja.allpolicjantow;
            iloscpolicjantow = policja.iloscpolicjantow;
            koszt = policja.koszt;
            allRadiowoz = policja.allRadiowoz;
            uzyRadiowoz = policja.uzyRadiowoz;
            startakcji = policja.startakcji;
            koniecakcji = policja.koniecakcji;
        }

        ~Wydarzenie()
        {

        }
        virtual public void Write(ListBox lp, PictureBox kl)
        {
            lp.Items.Add("Glowny dowodzacy operacji: " + glownodowodzacy);
            lp.Items.Add("Miejscowosc: " + miejscowosc);
            lp.Items.Add("Budynek: " + budynek);
            lp.Items.Add("Ilosc policjantow w wydarzeniu: " + iloscpolicjantow);
            lp.Items.Add("Ilosc policjantow w komisariacie" + pozospolicjanci());
            lp.Items.Add("Koszt operacji: " + koszt + "zl");
            lp.Items.Add("Wykorzystane Radiowozy: " + uzyRadiowoz);
            lp.Items.Add("Pozostale Radiowozy: " + pozosRadiowozy());
            lp.Items.Add("Czas trwania wydarzenie: " + Czas() + " dni");
        }
        virtual public void Write(ListBox lp)
        {
            lp.Items.Add("Glowny dowodzacy operacji: " + glownodowodzacy);
            lp.Items.Add("Miejscowosc: " + miejscowosc);
            lp.Items.Add("Budynek: " + budynek);
            lp.Items.Add("Ilosc policjantow w wydarzeniu: " + iloscpolicjantow);
            lp.Items.Add("Ilosc policjantow w komisariacie" + pozospolicjanci());
            lp.Items.Add("Koszt operacji: " + koszt + "zl");
            lp.Items.Add("Wykorzystane Radiowozy: " + uzyRadiowoz);
            lp.Items.Add("Pozostale Radiowozy: " + pozosRadiowozy());
            lp.Items.Add("Czas trwania wydarzenie: " + Czas() + " dni");
        }
        public string kosztWrite()
        {
            return koszt + " " + iloscpolicjantow +" " + uzyRadiowoz;
        }

        public int Srednia()
        {
            int Srednia = koszt;
            return Srednia;
        }

        int pozospolicjanci()
        {
            int pozos = allpolicjantow - iloscpolicjantow;
            return pozos;
        }
        int pozosRadiowozy()
        {
            int uzyte = allRadiowoz - uzyRadiowoz;
            return uzyte;
        }
        string Czas()
        {
            TimeSpan result = koniecakcji - startakcji;
            string czas = result.TotalDays.ToString();
            return czas;
        }
        public virtual void Zapisz(StreamWriter wr)
        {
            wr.WriteLine(nazwa.ToString());
            wr.WriteLine(glownodowodzacy);
            wr.WriteLine(miejscowosc);
            wr.WriteLine(budynek);
            wr.WriteLine(iloscpolicjantow.ToString());
            wr.WriteLine(allpolicjantow.ToString());
            wr.WriteLine(koszt.ToString());
            wr.WriteLine(uzyRadiowoz.ToString());
            wr.WriteLine(allRadiowoz.ToString());
            wr.WriteLine(startakcji.ToString());
            wr.WriteLine(koniecakcji.ToString());
        }

        public virtual void Czytaj(StreamReader sr)
        {
            glownodowodzacy = sr.ReadLine();
            miejscowosc = sr.ReadLine();
            budynek = sr.ReadLine();
            iloscpolicjantow=Convert.ToInt32(sr.ReadLine());
            allpolicjantow= Convert.ToInt32(sr.ReadLine());
            koszt= Convert.ToInt32(sr.ReadLine());
            uzyRadiowoz= Convert.ToInt32(sr.ReadLine());
            allRadiowoz= Convert.ToInt32(sr.ReadLine());
            startakcji=Convert.ToDateTime(sr.ReadLine());
            koniecakcji= Convert.ToDateTime(sr.ReadLine());
        }
        public int Koszt { get; set; }
        public int Radiowoz { get; set; }

        public Wydarzenie(int koszt,int uzyRadiowoz)
        {
            Koszt = koszt;
            Radiowoz = uzyRadiowoz;
        }
        
        public int CompareTo(Wydarzenie other)
        {
            if (this.Koszt > other.Koszt) return 1;
            else if (this.Koszt < other.Koszt) return -1;
            else if (this.Radiowoz > other.Radiowoz) return 1;
            else if (this.Radiowoz < other.Radiowoz) return -1;
            else return 0;
        }
    }
}
