using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
            DrawSalesChart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DrawSalesChart()
        {
            // Пример данных о продажах
            string[] months = { "Янв", "Фев", "Мар", "Апр", "Май" };
            int[] sales = { 120, 150, 130, 180, 200 };

            // Настройка графика
            int chartWidth = pictureBox1.Width;
            int chartHeight = pictureBox1.Height;
            int barWidth = chartWidth / months.Length;
            int maxSales = 250; // Максимальное значение на оси Y

            // Создание объекта Bitmap для рисования
            Bitmap bmp = new Bitmap(chartWidth, chartHeight);
            Graphics g = Graphics.FromImage(bmp);

            // Заливка фона
            g.Clear(Color.White);

            // Рисование столбцов графика
            for (int i = 0; i < months.Length; i++)
            {
                // Высота столбца пропорциональна значению продаж
                int barHeight = (int)((double)sales[i] / maxSales * chartHeight);

                // Позиция столбца
                int x = i * barWidth;
                int y = chartHeight - barHeight;

                // Цвет столбца
                g.FillRectangle(Brushes.Blue, x, y, barWidth - 5, barHeight); // -5 для отступа между столбцами

                // Подпись месяца под столбцом
                StringFormat format = new StringFormat();
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;
                g.DrawString(months[i], Font, Brushes.Black, x + barWidth / 2, chartHeight - 20, format);
            }

            // Оси X и Y
            g.DrawLine(Pens.Black, 0, chartHeight - 30, chartWidth, chartHeight - 30); // Ось X
            g.DrawLine(Pens.Black, 10, 0, 10, chartHeight - 30); // Ось Y

            // Присваиваем Bitmap PictureBox
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png"; // Формат сохранения
            saveFileDialog.Title = "Сохранить график как";

            // Отображение диалога и сохранение файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Сохраняем изображение из PictureBox в файл
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                    MessageBox.Show("График успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении графика: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}