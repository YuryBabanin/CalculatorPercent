using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorpercent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pv = Convert.ToInt32(textBox1.Text + "000");
                int n = Convert.ToInt32(textBox2.Text);
                double r = Convert.ToDouble(textBox3.Text) / 100;

                //Расчет простых процентов
                double fv = pv * (1 + n * r);

                //Ежемесячный платёж
                double m = fv / (n * 12);

                MessageBox.Show(String.Format("Будущая сумма кредита: {0} рублей\nВыплата в месяц: {1} рублей", Convert.ToString(fv), Convert.ToString(m)), "Расчет суммы кредита");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы не ввели число");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Вы ввели слишком большое число");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yurybabanin");
        }
    }
}
