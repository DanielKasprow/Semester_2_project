using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
//    class koszt : IComparable<koszt>
//{ 
//    public int Koszt { get; set; }

//    public koszt(int koszt)
//    {
//        Koszt = koszt;
//    }

//    public int CompareTo(koszt other)
//    {
//        if (this.Koszt > other.Koszt) return 1;
//        else if (this.Koszt < other.Koszt) return -1;
//        else return 0;
//        //return Koszt.CompareTo(other.Koszt);
//    }
//}
    public partial class Form6 : Form
    {
        public static List<Wydarzenie> talista = new List<Wydarzenie>();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Form1.mojalista.Sort();
            foreach (Wydarzenie t in Form1.mojalista)
                listBox1.Items.Add(t.kosztWrite());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Wydarzenie t in Form1.mojalista)
                listBox1.Items.Add(t.kosztWrite());
        }
    }
}
