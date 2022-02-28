using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorodsetek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = (200 - textBox1.TextLength).ToString("000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DateTime termin = dateTimePicker1.Value;
                DateTime umiesz = dateTimePicker2.Value;
                double kwota = double.Parse(textBox2.Text);

                double day = ((umiesz - termin).TotalDays);
                double odstki = kwota * day * 0.056 / 365.25;
                label17.Text = dateTimePicker1.Value.ToString("d")+ "-" + dateTimePicker2.Value.ToString("d");
                label18.Text =  day.ToString("0");
                label19.Text = "0.056 ";
                label20.Text = (odstki).ToString("0.00") + "PLN";
                label22.Text =  (kwota + odstki).ToString("0.00") + "PLN";

            }
            if (radioButton2.Checked)
            {
                DateTime termin = dateTimePicker1.Value;
                DateTime umiesz = dateTimePicker2.Value;
                double kwota = double.Parse(textBox2.Text);

                double day = ((umiesz - termin).TotalDays);
                double odstki = kwota * day * 0.05 / 365.25;
                label18.Text = day.ToString("0");
                label19.Text = "0.05 ";
                label20.Text = (odstki).ToString("0.00") + "PLN";
                label22.Text = (kwota + odstki).ToString("0.00") + "PLN";

            }
        }
    }
}
