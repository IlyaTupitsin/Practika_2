using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Получаем имя файла и текст из текстовых полей
                string fileName = textBox1.Text;
                string fileContent = textBox2.Text;
                string fileContent2 = textBox3.Text;
                if (int.Parse(label5.Text) < int.Parse(textBox3.Text))
                {
                    MessageBox.Show("У нас нет денег, чтобы выкупить данный товар", "Ошибка");
                    return;
                }
                else
                {
                    int balans = int.Parse(label5.Text) - int.Parse(textBox3.Text);
                    label5.Text = balans.ToString();
                }
                // Задаем определенную папку для сохранения
                string folderPath = @"C:\Users\Пользователь\Desktop\ломбард"; // Путь к вашей папке

                // Проверяем, введено ли имя файла
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                    return;
                }

                // Добавляем расширение .txt, если его нет
                if (!fileName.EndsWith(".txt"))
                {
                    fileName += ".txt";
                }

                // Создаем полный путь к файлу
                string filePath = Path.Combine(folderPath, fileName);

                // Создаем файл и записываем в него текст
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(fileContent+";"+fileContent2);
                    }

                    MessageBox.Show($"Файл '{fileName}' успешно создан в папке '{folderPath}'.", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании файла: {ex.Message}", "Ошибка");
                }
            }
        }

       
    }
}


