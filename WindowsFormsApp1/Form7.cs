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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policjaBzd.Policja' table. You can move, or remove it, as needed.
            this.policjaTableAdapter.Fill(this.policjaBzd.Policja);
            policjaBindingSource.DataSource = this.policjaBzd.Policja;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.policjaBzd.Policja.AddPolicjaRow(this.policjaBzd.Policja.NewPolicjaRow());
                policjaBindingSource.MoveLast();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                policjaBindingSource.ResetBindings(false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            policjaBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            policjaBindingSource.ResetBindings(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                policjaBindingSource.EndEdit();
                policjaTableAdapter.Update(this.policjaBzd.Policja);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                policjaBindingSource.ResetBindings(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                var query = from o in this.policjaBzd.Policja
                            where o.Budynek.Contains(textBox13.Text)
                            || o.Miejscowość.Contains(textBox13.Text)
                            select o;

                policjaBindingSource.DataSource = query.ToList();
        }
    }
}
