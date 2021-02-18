using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        // public static List<Wydarzenie> wczytajlista = new List<Wydarzenie>();
        int i = 0;
        int wczytaj = 0;
        int srednia = 0;
        int y = 0;
        public Form5()
        {
            InitializeComponent();
            if (Form1.mojalista.Count > 0)
            {
                Form1.mojalista[0].Write(listBox1, pictureBox1);
                Form1.mojalista[0].Write(listBox1);
            }
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            listBox1.Items.Clear();
            if (i + 1 == Form1.mojalista.Count || i == Form1.mojalista.Count)
                button1.Enabled = false;

            else button1.Enabled = true;

            if (i > 0)
                button2.Enabled = true;

            if (wczytaj == 0)
                Form1.mojalista[i].Write(listBox1, pictureBox1);
            else
                Form1.mojalista[i].Write(listBox1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            listBox1.Items.Clear();
            if (i + 1 == Form1.mojalista.Count || i == Form1.mojalista.Count)
                button2.Enabled = false;

            else button2.Enabled = true;

            if (i == 0)
                button2.Enabled = false;

            if (i + 1 != Form1.mojalista.Count || i != Form1.mojalista.Count)
            {
                button1.Enabled = true;
            }

            if (wczytaj == 0)
                Form1.mojalista[i].Write(listBox1, pictureBox1);
            else
                Form1.mojalista[i].Write(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.mojalista.Sort();
                if (wczytaj == 0)
                    Form1.mojalista[i].Write(listBox1, pictureBox1);
                else
                    Form1.mojalista[i].Write(listBox1);
                button4.Enabled = false;
                button1.Enabled = true;
                if (i + 1 == Form1.mojalista.Count || i == Form1.mojalista.Count)
                    button1.Enabled = false;
                try
                {
                    foreach (Wydarzenie s in Form1.mojalista)
                    {
                        srednia = srednia + s.Srednia();
                        y = y + 1;
                    }
                    srednia = srednia / y;
                    label2.Text = "" + srednia;
                }
                catch
                {
                }
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "save and txt File";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            foreach (Wydarzenie s in Form1.mojalista)
            {
                s.Zapisz(sw);
            }
            sw.Close();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Form1.mojalista.Clear();
                StreamReader sr = new StreamReader(dialog.FileName);
                Szkolenie s;
                Akcja a;
                while (!sr.EndOfStream)
                {
                    string nazwa = sr.ReadLine();
                    if (nazwa == "Akcja")
                    {
                        a = new Akcja();
                        a.Czytaj(sr);
                        Form1.mojalista.Add(a);
                    }
                    else
                    {
                        s = new Szkolenie();
                        s.Czytaj(sr);
                        Form1.mojalista.Add(s);
                    }
                }
                wczytaj = 1;
                sr.Close();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // Form1.mojalista.Sort();
            //Array.Sort(Form1.mojalista);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form1.mojalista.RemoveAt(i);
                listBox1.Items.Clear();
                if (button1.Enabled == false)
                {
                    i = i - 1;
                }
                if (i + 1 == Form1.mojalista.Count || i == Form1.mojalista.Count)
                    button1.Enabled = false;

                if (i == 0)
                    button2.Enabled = false;

                if (wczytaj == 0)
                    Form1.mojalista[i].Write(listBox1, pictureBox1);
                else
                    Form1.mojalista[i].Write(listBox1);
            }
            catch { label2.Text = ""; }
            try
            {
                y = 0;
                srednia = 0;
                foreach (Wydarzenie s in Form1.mojalista)
                {
                    srednia = srednia + s.Srednia();
                    y = y + 1;
                }
                srednia = srednia / y;
                label2.Text = "" + srednia;
            }
            catch
            {
            }
        }

        private void Form5_Move(object sender, EventArgs e)
        {
            this.Text = "Nie ruszaj !!!";

        }

        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        { 
            if(button4.Enabled==false)
            {
            int g = i + 1;
            this.Text = "Object nr." + g;
            }
        }
    }
}
