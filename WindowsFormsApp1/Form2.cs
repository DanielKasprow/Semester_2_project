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
    public partial class Form2 : Form
    {
        public static List<Wydarzenie> akcjalista = new List<Wydarzenie>();
        Akcja akc;

        public Form2()
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
                if (Form1.mojalista.Count > 1)
                {
                    Wydarzenie policja1 = new Wydarzenie(Form1.mojalista[0]);
                    Wydarzenie policja2 = new Wydarzenie(Form1.mojalista[1]);
                
                if (policja1 == policja2)
                    MessageBox.Show("równają się");

            }
            }
            catch { }
           try
            {
                if (Form1.mojalista.Count > 1)
                {
                    Wydarzenie policja1 = new Wydarzenie(Form1.mojalista[0]);
                    Wydarzenie policja2 = new Wydarzenie(Form1.mojalista[1]);

                    if (policja1 != policja2)

                        MessageBox.Show("rożnia się");

                }
            }
            catch { }

            
               
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
                                            if (Convert.ToInt32(textBox7.Text) >= 1&& Convert.ToInt32(textBox8.Text) >= 1 && Convert.ToInt32(textBox9.Text) >= 1 &&
                                                Convert.ToInt32(textBox10.Text) >= 1 && Convert.ToInt32(textBox11.Text) >= 1 && Convert.ToInt32(textBox12.Text) >= 1 )
                                            {
                                                try
                                                {
                                                    if (Convert.ToInt32(textBox13.Text) >= 0)
                                                    {
                                                        try
                                                        {
                                                            if (Convert.ToInt32(textBox14.Text) >= 0)
                                                            {
                                                                try
                                                                {
                                                                    if (Convert.ToInt32(textBox15.Text) >= 0)
                                                                    {
                                                                        akc = new Akcja(textBox1.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox3.Text),
                                             50, Convert.ToInt32(textBox5.Text), 10, Convert.ToInt32(textBox6.Text),
                                             new DateTime(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), 0, 0, 0), new DateTime(Convert.ToInt32(textBox10.Text),
                                             Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), 0, 0, 0),
                                             new Bitmap("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg"),
                                             textBox13.Text, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox15.Text), textBox16.Text);


                                                                        Form1.mojalista.Add(akc);

                                                                        akc.Write(listBox1, pictureBox1);
                                                                    }
                                                                    else MessageBox.Show("szkody mienia nie moze byc na minusie");
                                                                }
                                                                catch
                                                                {
                                                                    MessageBox.Show("Szkody mienia musi byc liczba");
                                                                }
                                                            }
                                                            else MessageBox.Show("Zuzyta amunicja nie moze byc na minusie");
                                                        }
                                                        catch
                                                        {
                                                            MessageBox.Show("Zuzyta amunicja musi byc liczba");
                                                        }
                                                    }
                                                    else MessageBox.Show("Zlapanych przestepcow nie moze byc na minusie");
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("Zlapani przestepcy musi byc liczba ");
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
                        }
                        catch
                        {
                            MessageBox.Show("koszt akcji musi byc liczba");
                        }
                    }
                    else MessageBox.Show("koszt akcji musi byc wieksza od 0");
                }
                catch
                {
                    MessageBox.Show("Ilosc policiantow musi byc liczba");
                }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Lubliniec";
            textBox2.Text = "Sklep Delikatesy";
            textBox4.Text = "Mieczyslaw Wojtek";
            textBox3.Text = "15";
            textBox5.Text = "5000";
            textBox6.Text = "5";
            textBox7.Text = "2020";
            textBox8.Text = "1";
            textBox9.Text = "1";
            textBox10.Text = "2020";
            textBox11.Text = "1";
            textBox12.Text = "2";
            textBox13.Text = "5";
            textBox14.Text = "20";
            textBox15.Text = "10000";
            textBox16.Text = "Napad";
            pictureBox1.Image = new Bitmap("F:\\szkoła\\programowanie 2\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("C:\\Users\\Daniel\\Desktop\\akcja.txt");

                label19.Text = "";

                akc = new Akcja(textBox1.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox3.Text), 50, Convert.ToInt32(textBox5.Text), 10, Convert.ToInt32(textBox6.Text),
                new DateTime(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), 0, 0, 0), new DateTime(Convert.ToInt32(textBox10.Text),
                Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), 0, 0, 0),
                new Bitmap("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg"),
                textBox13.Text, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox15.Text), textBox16.Text);

                akcjalista.Add(akc);

            foreach (Akcja s in akcjalista)
                s.Zapisz(wr);
            wr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Daniel\\Desktop\\Akcja.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                pictureBox1.Image = new Bitmap("C:\\Users\\Daniel\\Desktop\\programowanie\\Daniel Kasprów\\WindowsFormsApp1\\Radiowoz.jpg");
            }
            catch
            {
                MessageBox.Show("Nie znaleziono pliku Akcja.txt na pulpicie");
            }
        }
    }
}
