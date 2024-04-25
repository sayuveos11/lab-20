using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання значень сторін з текстових полів
                double side1 = double.Parse(Side1.Text);
                double side2 = double.Parse(Side2.Text);
                double side3 = double.Parse(Side3.Text);

                // Перевірка чи сторони утворюють трикутник
                if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    // Обчислення периметра
                    double perimeter = side1 + side2 + side3;
                    MessageBox.Show($"Периметр трикутника: {perimeter}");
                }
                else
                {
                    MessageBox.Show("Введені значення не утворюють трикутник.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено некоректне значення. Будь ласка, введіть число.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }
    }
}
