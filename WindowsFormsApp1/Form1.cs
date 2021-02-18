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
    public partial class Form1 : Form
    {
        public static List<Wydarzenie> mojalista = new List<Wydarzenie>();

        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        Form7 form7 = new Form7();

        // Wydarzenie wyd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* wyd = new Wydarzenie("Lubliniec","Szkola Podstawowa","Mieczyslaw Wojtek",20,4,2000,20,10, new DateTime(2000, 1, 1, 0, 0, 0), new DateTime(2020, 1, 1, 0, 0, 0));
            wyd.Wypisz(listBox1);

            Wydarzenie wyd2 = new Wydarzenie(wyd);
            wyd2.Wypisz(listBox1);*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            form6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form7.ShowDialog();
        }
    }
}
