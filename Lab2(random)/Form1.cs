using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_random_
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
                int min = int.Parse(textBox1.Text);
                int max = int.Parse(textBox2.Text);

                if (min >= max)
                {
                    MessageBox.Show("Минимальное значение должно быть меньше максимального.");
                    return;
                }

                Random random = new Random();
                int randomNumber = random.Next(min, max + 1); // +1, чтобы включить max в диапазон

                label1.Text = randomNumber.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целые числа в поля ввода.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
