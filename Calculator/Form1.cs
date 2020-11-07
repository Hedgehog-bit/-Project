using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private int h = 30;
        static private int n = 0;
        DateTimePicker[] stores = new DateTimePicker[n];
        int data;


        public Form1()
        {
            InitializeComponent();
        }

        private void Adding(object sender, EventArgs e)
        {
            Array.Resize(ref stores, stores.Length + 2);
            stores[n] = new DateTimePicker();
            stores[n].Location = new Point(15, 45 + h);
            stores[n].Size = new Size(162, 20);
            Controls.Add(stores[n]);
            n++;

            stores[n] = new DateTimePicker();
            stores[n].Location = new Point(214, 45 + h);
            stores[n].Size = new Size(123, 20);
            Controls.Add(stores[n]);
            n++;
            h += 30;
        }

        private void Deleting(object sender, EventArgs e)
        {
            if (stores.Length > 1)
            {
                Controls.Remove(stores[stores.Length - 1]);
                Controls.Remove(stores[stores.Length - 2]);
                Array.Resize(ref stores, stores.Length - 2);
            }
            if (h > 30) 
                h -= 30;
            if (n > 0)
                n -= 2;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            army.Text = "";
            textBox1.Text = "";
            vacation.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            while (n != 0)
            {
                Deleting(sender, e);
            }
        }

        private void Сalculate_Click(object sender, EventArgs e)
        {
            data = 0;
            Difference(dateTimePicker1, dateTimePicker2);
            if (n > 0)
            {
                for (int i = 0; i < stores.Length - 1; i += 2) 
                {
                    Difference(stores[i], stores[i + 1]);
                }
            }

            int month, year, day;
            year = data / 365;
            month = data / 30;
            if (year > 0)
            {
                month = month - 12 * year;
            }
            day = data % 30;
            if (army.Text == "Да, 1 год")
                year += 2;
            if (army.Text == "Да, 1,5 года")
                year += 3;
            if (army.Text == "Да, 2 года")
                year += 4;


            if (vacation.Text == "Да, за 1 ребенком")
            {
                year ++;
                month += 6;
                if (month >= 12)
                {
                    year++;
                    month -= 12;
                }
            }
            if (vacation.Text == "Да, за 2 детьми, в разное время")
                year += 3;
            if (vacation.Text == "Да, за 3 и более детьми, в разное время")
            {
                year += 4;
                month += 6;
                if (month >= 12)
                {
                    year++;
                    month -= 12;
                }
            }
            

            if ((year == 0) && (month != 0))
            {
                textBox1.Text = month.ToString() + " Месяцев " + day.ToString() + " Дней ";
                if ((month == 0) && (year == 0))
                    textBox1.Text = day.ToString() + " Дней ";
            }
            else textBox1.Text = year.ToString() + " Лет " + month.ToString() + " Месяцев " + day.ToString() + " Дней ";
            
        }
        private void Difference(DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
                TimeSpan data;
                data = dateTimePicker2.Value - dateTimePicker1.Value;
                this.data += data.Days; 
        }
    }
}

