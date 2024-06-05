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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            PopulateComboBox1();
        }
        private void PopulateComboBox1()
        {
            string folderPath = @"C:\Users\Пользователь\Desktop\ломбард";
            string[] fileEntries = Directory.GetFiles(folderPath);
            foreach (string fileName in fileEntries)
            {
                comboBox1.Items.Add(Path.GetFileName(fileName));

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFileName = comboBox1.SelectedItem.ToString();
            string filePath = Path.Combine("C:\\Users\\Пользователь\\Desktop\\ломбард", selectedFileName);
            DataTable dt2 = new DataTable();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = sr.ReadLine();
                string[] values = line.Split(';');

                // Проходим по всем значениям, чтобы сформировать уникальные имена столбцов 
                Dictionary<string, int> columnCounts = new Dictionary<string, int>();
                foreach (string header in values)
                {
                    string columnName = header;
                    if (columnCounts.ContainsKey(columnName))
                    {
                        columnCounts[columnName]++;
                        columnName = $"{columnName} ({columnCounts[columnName]})";
                    }
                    else
                    {
                        columnCounts.Add(columnName, 1);
                    }
                    // Добавляем столбец с уникальным именем
                    dt2.Columns.Add(columnName);
                }
            }

            dataGridView1.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем выбранный полный путь к файлу из комбобокса
            string selectedFileName = comboBox1.SelectedItem.ToString();
            string filePath = Path.Combine("C:\\Users\\Пользователь\\Desktop\\ломбард", selectedFileName);
            // Проверяем, выбрано ли имя файла
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Пожалуйста, выберите файл из списка.", "Ошибка");
                return;
            }

            // Проверяем, существует ли файл
            if (File.Exists(filePath))
            {
                // Удаляем файл
                try
                {
                    File.Delete(filePath);
                    MessageBox.Show($"Файл '{Path.GetFileName(filePath)}' успешно удален.", "Успех");

                    // Обновляем комбобокс после удаления
                    PopulateComboBox1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении файла: {ex.Message}", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show($"Файл '{Path.GetFileName(filePath)}' не найден.", "Ошибка");
            }
        }
    }
   
}

