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
    public partial class Form3 : Form
    {
        public static List<Wydarzenie> szkolenielista = new List<Wydarzenie>();
        Szkolenie szk;
        public Form3()
        {
            InitializeComponent();
            if (Form1.mojalista.Count > 0)
            {
                Form1.mojalista[0].Write(listBox1, pictureBox1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox3.Text) > 0)
                {
                    try
                    {
                        if (Convert.ToInt32(textBox5.Text) > 0)
                        {
                            try
                            {
                                if (Convert.ToInt32(textBox6.Text) >= 0)
                                {
                                    try
                                    {
                                        if (Convert.ToInt32(textBox7.Text) >= 1 && Convert.ToInt32(textBox8.Text) >= 1 && Convert.ToInt32(textBox9.Text) >= 1 &&
                                            Convert.ToInt32(textBox10.Text) >= 1 && Convert.ToInt32(textBox11.Text) >= 1 && Convert.ToInt32(textBox12.Text) >= 1)
                                        {
                                            try
                                            {
                                                if (Convert.ToInt32(textBox13.Text) >= 0)
                                                {
                                                    szk = new Szkolenie(textBox1.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox3.Text), 50, Convert.ToInt32(textBox5.Text), 10, Convert.ToInt32(textBox6.Text),
                                            new DateTime(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), 0, 0, 0), new DateTime(Convert.ToInt32(textBox10.Text),
                                            Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), 0, 0, 0), new Bitmap("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg"),
                                            Convert.ToInt32(textBox13.Text), textBox14.Text, textBox15.Text, textBox16.Text);


                                                    Form1.mojalista.Add(szk);

                                                    szk.Write(listBox1, pictureBox1);
                                                }
                                                else MessageBox.Show("Zaliczone szkolenia nie moze byc ujemne");
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Zaliczone szkolenia ma byc liczba");
                                            }
                                        }
                                        else MessageBox.Show("Dzien/miesiac/rok nie moze byc mniejsze od 1");
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Bledna data");
                                    }
                                }
                                else MessageBox.Show("Uzyte radiowozy nie moga byc na minusie");
                            }
                            catch
                            {
                                MessageBox.Show("Uzyte radiowozy musi byc liczba");
                            }
                        }
                        else MessageBox.Show("koszt szkolenia nie moze byc liczba ujemna");
                    }
                    catch
                    {
                        MessageBox.Show("koszt szkolenia musi byc liczba");
                    }
                }
                else MessageBox.Show("ilosc szkolonych policjantow musi byc wieksza od 0");
            }
            catch
            {
                MessageBox.Show("Ilosc szkolonych policjantow musi byc liczba");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Lodz";
            textBox2.Text = "Ośrodek Szkolenia Policji";
            textBox4.Text = "Mieczyslaw Wojtek";
            textBox3.Text = "15";
            textBox5.Text = "15000";
            textBox6.Text = "0";
            textBox7.Text = "2019";
            textBox8.Text = "7";
            textBox9.Text = "5";
            textBox10.Text = "2020";
            textBox11.Text = "1";
            textBox12.Text = "1";
            textBox13.Text = "15";
            textBox14.Text = "Ogólne doszkolenie";
            textBox15.Text = "Szeregowy";
            textBox16.Text = "Ośrodek Szkolenia Policji";
            pictureBox1.Image = new Bitmap("F:\\szkoła\\programowanie 2\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg");
         }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("C:\\Users\\Daniel\\Desktop\\szkolenie.txt");
            szk = new Szkolenie(textBox1.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox3.Text), 50, Convert.ToInt32(textBox5.Text), 10, Convert.ToInt32(textBox6.Text),
           new DateTime(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), 0, 0, 0), new DateTime(Convert.ToInt32(textBox10.Text),
           Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), 0, 0, 0), new Bitmap("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg"),
           Convert.ToInt32(textBox13.Text), textBox14.Text, textBox15.Text, textBox16.Text);

            szkolenielista.Add(szk);
            foreach (Szkolenie s in szkolenielista)
                s.Zapisz(wr);
            wr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Daniel\\Desktop\\szkolenie.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                pictureBox1.Image = new Bitmap("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg");
            }
            catch
            {
                MessageBox.Show("Nie znaleziono pliku Szkolenie.txt na pulpicie");
            }
        }
        
    }
}
