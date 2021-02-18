namespace WindowsFormsApp1
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.policjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policjaBzd = new WindowsFormsApp1.PolicjaBzd();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.głownyDowodzącySzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budynekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscSzkolonychPolicjantówDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztSzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzyteRadiowozyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaliczoneSzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakresSzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopienSzkoleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakwaterowanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.policjaTableAdapter = new WindowsFormsApp1.PolicjaBzdTableAdapters.PolicjaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.policjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policjaBzd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(963, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyjscie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Głowny dowodzący Szkolenia", true));
            this.textBox1.Location = new System.Drawing.Point(20, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // policjaBindingSource
            // 
            this.policjaBindingSource.DataMember = "Policja";
            this.policjaBindingSource.DataSource = this.policjaBzd;
            // 
            // policjaBzd
            // 
            this.policjaBzd.DataSetName = "PolicjaBzd";
            this.policjaBzd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Miejscowość", true));
            this.textBox2.Location = new System.Drawing.Point(185, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Budynek", true));
            this.textBox3.Location = new System.Drawing.Point(374, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "ilosc Szkolonych Policjantów", true));
            this.textBox4.Location = new System.Drawing.Point(550, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Koszt Szkolenia", true));
            this.textBox5.Location = new System.Drawing.Point(20, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Uzyte Radiowozy", true));
            this.textBox6.Location = new System.Drawing.Point(185, 108);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Data Rozpoczecia Szkolenia", true));
            this.textBox7.Location = new System.Drawing.Point(374, 108);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Data Zakonczenia Szkolenia", true));
            this.textBox8.Location = new System.Drawing.Point(550, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Zaliczone Szkolenia", true));
            this.textBox9.Location = new System.Drawing.Point(20, 195);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Zakres Szkolenia", true));
            this.textBox10.Location = new System.Drawing.Point(185, 195);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Stopien Szkolenia", true));
            this.textBox11.Location = new System.Drawing.Point(374, 195);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 11;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policjaBindingSource, "Zakwaterowanie", true));
            this.textBox12.Location = new System.Drawing.Point(550, 195);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.głownyDowodzącySzkoleniaDataGridViewTextBoxColumn,
            this.miejscowośćDataGridViewTextBoxColumn,
            this.budynekDataGridViewTextBoxColumn,
            this.iloscSzkolonychPolicjantówDataGridViewTextBoxColumn,
            this.kosztSzkoleniaDataGridViewTextBoxColumn,
            this.uzyteRadiowozyDataGridViewTextBoxColumn,
            this.dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn,
            this.dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn,
            this.zaliczoneSzkoleniaDataGridViewTextBoxColumn,
            this.zakresSzkoleniaDataGridViewTextBoxColumn,
            this.stopienSzkoleniaDataGridViewTextBoxColumn,
            this.zakwaterowanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.policjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 282);
            this.dataGridView1.TabIndex = 13;
            // 
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            // 
            // głownyDowodzącySzkoleniaDataGridViewTextBoxColumn
            // 
            this.głownyDowodzącySzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Głowny dowodzący Szkolenia";
            this.głownyDowodzącySzkoleniaDataGridViewTextBoxColumn.HeaderText = "Głowny dowodzący Szkolenia";
            this.głownyDowodzącySzkoleniaDataGridViewTextBoxColumn.Name = "głownyDowodzącySzkoleniaDataGridViewTextBoxColumn";
            // 
            // miejscowośćDataGridViewTextBoxColumn
            // 
            this.miejscowośćDataGridViewTextBoxColumn.DataPropertyName = "Miejscowość";
            this.miejscowośćDataGridViewTextBoxColumn.HeaderText = "Miejscowość";
            this.miejscowośćDataGridViewTextBoxColumn.Name = "miejscowośćDataGridViewTextBoxColumn";
            // 
            // budynekDataGridViewTextBoxColumn
            // 
            this.budynekDataGridViewTextBoxColumn.DataPropertyName = "Budynek";
            this.budynekDataGridViewTextBoxColumn.HeaderText = "Budynek";
            this.budynekDataGridViewTextBoxColumn.Name = "budynekDataGridViewTextBoxColumn";
            // 
            // iloscSzkolonychPolicjantówDataGridViewTextBoxColumn
            // 
            this.iloscSzkolonychPolicjantówDataGridViewTextBoxColumn.DataPropertyName = "ilosc Szkolonych Policjantów";
            this.iloscSzkolonychPolicjantówDataGridViewTextBoxColumn.HeaderText = "ilosc Szkolonych Policjantów";
            this.iloscSzkolonychPolicjantówDataGridViewTextBoxColumn.Name = "iloscSzkolonychPolicjantówDataGridViewTextBoxColumn";
            // 
            // kosztSzkoleniaDataGridViewTextBoxColumn
            // 
            this.kosztSzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Koszt Szkolenia";
            this.kosztSzkoleniaDataGridViewTextBoxColumn.HeaderText = "Koszt Szkolenia";
            this.kosztSzkoleniaDataGridViewTextBoxColumn.Name = "kosztSzkoleniaDataGridViewTextBoxColumn";
            // 
            // uzyteRadiowozyDataGridViewTextBoxColumn
            // 
            this.uzyteRadiowozyDataGridViewTextBoxColumn.DataPropertyName = "Uzyte Radiowozy";
            this.uzyteRadiowozyDataGridViewTextBoxColumn.HeaderText = "Uzyte Radiowozy";
            this.uzyteRadiowozyDataGridViewTextBoxColumn.Name = "uzyteRadiowozyDataGridViewTextBoxColumn";
            // 
            // dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn
            // 
            this.dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Data Rozpoczecia Szkolenia";
            this.dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn.HeaderText = "Data Rozpoczecia Szkolenia";
            this.dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn.Name = "dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn";
            // 
            // dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn
            // 
            this.dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Data Zakonczenia Szkolenia";
            this.dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn.HeaderText = "Data Zakonczenia Szkolenia";
            this.dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn.Name = "dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn";
            // 
            // zaliczoneSzkoleniaDataGridViewTextBoxColumn
            // 
            this.zaliczoneSzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Zaliczone Szkolenia";
            this.zaliczoneSzkoleniaDataGridViewTextBoxColumn.HeaderText = "Zaliczone Szkolenia";
            this.zaliczoneSzkoleniaDataGridViewTextBoxColumn.Name = "zaliczoneSzkoleniaDataGridViewTextBoxColumn";
            // 
            // zakresSzkoleniaDataGridViewTextBoxColumn
            // 
            this.zakresSzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Zakres Szkolenia";
            this.zakresSzkoleniaDataGridViewTextBoxColumn.HeaderText = "Zakres Szkolenia";
            this.zakresSzkoleniaDataGridViewTextBoxColumn.Name = "zakresSzkoleniaDataGridViewTextBoxColumn";
            // 
            // stopienSzkoleniaDataGridViewTextBoxColumn
            // 
            this.stopienSzkoleniaDataGridViewTextBoxColumn.DataPropertyName = "Stopien Szkolenia";
            this.stopienSzkoleniaDataGridViewTextBoxColumn.HeaderText = "Stopien Szkolenia";
            this.stopienSzkoleniaDataGridViewTextBoxColumn.Name = "stopienSzkoleniaDataGridViewTextBoxColumn";
            // 
            // zakwaterowanieDataGridViewTextBoxColumn
            // 
            this.zakwaterowanieDataGridViewTextBoxColumn.DataPropertyName = "Zakwaterowanie";
            this.zakwaterowanieDataGridViewTextBoxColumn.HeaderText = "Zakwaterowanie";
            this.zakwaterowanieDataGridViewTextBoxColumn.Name = "zakwaterowanieDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Wyszukiwanie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(836, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(963, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Usun";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(894, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Edytuj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(963, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Anuluj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(836, 427);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Zapisz";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // policjaTableAdapter
            // 
            this.policjaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 242);
            this.panel1.TabIndex = 20;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(781, 88);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(257, 20);
            this.textBox13.TabIndex = 21;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 590);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policjaBzd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PolicjaBzd policjaBzd;
        private System.Windows.Forms.BindingSource policjaBindingSource;
        private PolicjaBzdTableAdapters.PolicjaTableAdapter policjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn głownyDowodzącySzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budynekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscSzkolonychPolicjantówDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztSzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzyteRadiowozyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRozpoczeciaSzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZakonczeniaSzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaliczoneSzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakresSzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienSzkoleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakwaterowanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox13;
    }
}