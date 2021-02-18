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
    class Szkolenie : Wydarzenie
    {
        protected int zaliczylo;
        protected string zakresszkolenia, stopienszkolonych, zakwaterowanie;

        public Szkolenie() : base()
        {
            zaliczylo = 0;
            zakresszkolenia = "...";
            stopienszkolonych = "...";
            zakwaterowanie = "...";
        }
        public Szkolenie(string miejscowosc, string budynek, string glownodowodzacy, int allpolicjantow, int iloscpolicjantow, int koszt, int allRadiowoz, int uzyRadiowoz, DateTime startakcji, DateTime koniecakcji, Bitmap pic, int zaliczylo, string zakresszkolenia, string stopienszkolonych, string zakwaterowanie) : base(miejscowosc, budynek, glownodowodzacy, iloscpolicjantow, allpolicjantow, koszt, allRadiowoz, uzyRadiowoz, startakcji, koniecakcji, pic)
        {
            this.zaliczylo = zaliczylo;
            this.zakresszkolenia = zakresszkolenia;
            this.stopienszkolonych = stopienszkolonych;
            this.zakwaterowanie = zakwaterowanie;
        }
        override public void Write(ListBox lp, PictureBox kl)
        {
            base.Write(lp, kl);
            lp.Items.Add("Zaliczone szkolenia: " + zaliczylo);
            lp.Items.Add("Niezaliczone szkolenia: " + niezal());
            lp.Items.Add("Zakres Szkolenia: " + zakresszkolenia);
            lp.Items.Add("Stopien Szkolonych: " + stopienszkolonych);
            lp.Items.Add(zak());
            lp.Items.Add("");
            kl.Image = pic;
        }
        override public void Write(ListBox lp)
        {
            base.Write(lp);
            lp.Items.Add("Zaliczone szkolenia: " + zaliczylo);
            lp.Items.Add("Niezaliczone szkolenia: " + niezal());
            lp.Items.Add("Zakres Szkolenia: " + zakresszkolenia);
            lp.Items.Add("Stopien Szkolonych: " + stopienszkolonych);
            lp.Items.Add(zak());
            lp.Items.Add("");
        }
        int niezal()
        {
            int niez = iloscpolicjantow - zaliczylo;
            return niez;
        }
        string zak()
        {
            string zakw = "Zakwaterowanie: " + zakwaterowanie;
            return zakw;
        }
        public override void Zapisz(StreamWriter wr)
        {
            nazwa = "Szkolenie";
            base.Zapisz(wr);
            wr.WriteLine(zaliczylo.ToString());
            wr.WriteLine(zakresszkolenia);
            wr.WriteLine(stopienszkolonych);
            wr.WriteLine(zakwaterowanie);
        }
        public override void Czytaj(StreamReader sr)
        {
            base.Czytaj(sr);
            zaliczylo = Convert.ToInt32(sr.ReadLine());
            zakresszkolenia=sr.ReadLine();
            stopienszkolonych=sr.ReadLine();
            zakwaterowanie=sr.ReadLine();
        }
    }
}
