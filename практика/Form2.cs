using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PopulateComboBox();
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
            Logger.Log($"добавление товара");
            // Получаем имя файла и текст из текстовых полей
            string fileName = textBox1.Text;
            string fileContent = textBox2.Text;
            string fileContent2 = textBox3.Text;
          

            // Проверяем, выбрана ли папка в ComboBox
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            // Получаем имя папки из ComboBox
            string folderName = comboBox2.SelectedItem.ToString();

            // Получаем путь к папке, из которой нужно выбирать папки
            string folderPath = @"C:\Users\Пользователь\Desktop\ломбард";

            // Проверяем, введено ли имя файла
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Пожалуйста, введите имя товара.", "Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(fileContent))
            {
                MessageBox.Show("Пожалуйста, введите описание товара.", "Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(fileContent2))
            {
                MessageBox.Show("Пожалуйста, введите цену товара.", "Ошибка");
                return;
            }
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
            // Добавляем расширение .txt, если его нет
            if (!fileName.EndsWith(".txt"))
            {
                fileName += ".txt";
            }

            // Создаем полный путь к файлу
            string filePath = Path.Combine(folderPath, folderName, fileName);

            // Создаем файл и записываем в него текст
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(fileContent + ";" + fileContent2);
                }

                MessageBox.Show($"товар успешно создан.", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании товара: {ex.Message}", "Ошибка");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string parentFolderPath = @"C:\Users\Пользователь\Desktop\ломбард";
            string newFolderName = textBox4.Text;

            // Составляем полный путь к новой папке
            string newFolderPath = Path.Combine(parentFolderPath, newFolderName);
           
            // Проверяем, существует ли папка
            if (Directory.Exists(newFolderPath))
            {
                MessageBox.Show("такая категория уже есть!");
            }
            else
            {
                // Создаем папку
                Directory.CreateDirectory(newFolderPath);
                MessageBox.Show("категория успешно создана!");
            }
        }
        private void PopulateComboBox()
        {
            // Получаем путь к папке, из которой нужно выбирать папки
            string folderPath = @"C:\Users\Пользователь\Desktop\ломбард";

            // Получаем список папок в указанной папке
            string[] subfolders = Directory.GetDirectories(folderPath);

            // Добавляем папки в ComboBox
            foreach (string subfolder in subfolders)
            {
                string folderName = Path.GetFileName(subfolder);
                comboBox2.Items.Add(folderName);
            }
        }
       
    }
}


