using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp5;
namespace DiplomaApp
{
    public partial class Form1 : Form
    {
        private Student[] students;  
        private int studentCount;   
        private string currentFilePath = "students.dat";
        public Form1()
        {
            InitializeComponent();
            students = new Student[100]; // Максимум 100 студентов
            studentCount = 0;
        }
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewInput.Rows.Count == 0)
                {
                    MessageBox.Show("Добавьте хотя бы одну запись перед сохранением!",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                studentCount = 0;
                for (int i = 0; i < dataGridViewInput.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridViewInput.Rows[i];
                    if (row.IsNewRow) continue;// Пропускаем пустую строку для новой записи

                    if (row.Cells["LastName"].Value != null &&
                        row.Cells["FirstName"].Value != null &&
                        row.Cells["Group"].Value != null &&
                        row.Cells["Grade"].Value != null)
                    {
                        string lastName = row.Cells["LastName"].Value.ToString();
                        string firstName = row.Cells["FirstName"].Value.ToString();
                        string group = row.Cells["Group"].Value.ToString();
                        int grade;
                        if (int.TryParse(row.Cells["Grade"].Value.ToString(), out grade))
                        {
                            if (grade >= 2 && grade <= 5)
                            {
                                students[studentCount].LastName = lastName;
                                students[studentCount].FirstName = firstName;
                                students[studentCount].Group = group;
                                students[studentCount].Grade = grade;
                                studentCount++;
                            }
                            else
                            {
                                MessageBox.Show($"Оценка для студента {lastName} {firstName} должна быть от 2 до 5!",
                                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
                if (studentCount == 0)
                {
                    MessageBox.Show("Нет корректных данных для сохранения!",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(currentFilePath, FileMode.Create)))// Сохраняем в двоичный файл
                {
                    writer.Write(studentCount);
                    for (int i = 0; i < studentCount; i++)
                    {
                        writer.Write(students[i].LastName);
                        writer.Write(students[i].FirstName);
                        writer.Write(students[i].Group);
                        writer.Write(students[i].Grade);
                    }
                }
                MessageBox.Show($"Данные успешно сохранены в файл\nСохранено записей: {studentCount}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLoadAndSearch_Click(object sender, EventArgs e)// Обработчик кнопки чтения из файла и поиска
        {
            try
            {
                if (!File.Exists(currentFilePath)) // Проверяем, что файл существует
                {
                    MessageBox.Show($"Файл '{currentFilePath}' не найден!\nСначала сохраните данные.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (BinaryReader reader = new BinaryReader(File.Open(currentFilePath, FileMode.Open)))// Читаем данные из двоичного файла
                {
                    studentCount = reader.ReadInt32();
                    students = new Student[100]; // Создаем новый массив

                    for (int i = 0; i < studentCount; i++)
                    {
                        students[i].LastName = reader.ReadString();
                        students[i].FirstName = reader.ReadString();
                        students[i].Group = reader.ReadString();
                        students[i].Grade = reader.ReadInt32();
                    }
                }
               
                dataGridViewInput.Rows.Clear(); // Отображаем все загруженные данные в первой таблице
                for (int i = 0; i < studentCount; i++)
                {
                    dataGridViewInput.Rows.Add(students[i].LastName, students[i].FirstName,
                        students[i].Group, students[i].Grade);
                }
                string searchGroup = txtGroup.Text.Trim();// Получаем параметры поиска
                string searchGrade = cmbGrade.SelectedItem?.ToString();
                dataGridViewResults.Rows.Clear();// Выполняем поиск
                if (string.IsNullOrEmpty(searchGroup) && string.IsNullOrEmpty(searchGrade))// Если группа не введена и оценка не выбрана - показываем всех
                {
                    for (int i = 0; i < studentCount; i++)// Показываем всех студентов
                    {
                        dataGridViewResults.Rows.Add(students[i].LastName, students[i].FirstName,
                            students[i].Group, students[i].Grade);
                    }
                    if (studentCount > 0)
                    {
                        MessageBox.Show($"Всего студентов: {studentCount}",
                            "Все студенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridViewResults.Rows.Add("Ответ не найден", "", "", "");
                        MessageBox.Show("Нет данных для отображения.",
                            "Ответ не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (!string.IsNullOrEmpty(searchGroup) && string.IsNullOrEmpty(searchGrade))// Если введена только группа
                {
                    int foundCount = 0;
                    for (int i = 0; i < studentCount; i++)// Ищем студентов из указанной группы
                    {
                        if (students[i].Group == searchGroup)
                        {
                            dataGridViewResults.Rows.Add(students[i].LastName, students[i].FirstName,
                                students[i].Group, students[i].Grade);
                            foundCount++;
                        }
                    }
                    if (foundCount > 0)
                    {
                        MessageBox.Show($"Найдено студентов в группе '{searchGroup}': {foundCount}",
                            "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridViewResults.Rows.Add("Ответ не найден", "", "", "");
                        MessageBox.Show($"Студенты из группы '{searchGroup}' не найдены.",
                            "Ответ не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (string.IsNullOrEmpty(searchGroup) && !string.IsNullOrEmpty(searchGrade))// Если выбрана только оценка
                {
                    int targetGrade = int.Parse(searchGrade);
                    int foundCount = 0;
                    for (int i = 0; i < studentCount; i++)// Ищем студентов с указанной оценкой
                    {
                        if (students[i].Grade == targetGrade)
                        {
                            dataGridViewResults.Rows.Add(students[i].LastName, students[i].FirstName,
                                students[i].Group, students[i].Grade);
                            foundCount++;
                        }
                    }
                    if (foundCount > 0)
                    {
                        MessageBox.Show($"Найдено студентов с оценкой {targetGrade}: {foundCount}",
                            "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridViewResults.Rows.Add("Ответ не найден", "", "", "");
                        MessageBox.Show($"Студенты с оценкой {targetGrade} не найдены.",
                            "Ответ не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else// Если введены и группа, и оценка
                {
                    int targetGrade = int.Parse(searchGrade);
                    int foundCount = 0;
                    for (int i = 0; i < studentCount; i++)// Ищем студентов из указанной группы с указанной оценкой
                    {
                        if (students[i].Group == searchGroup && students[i].Grade == targetGrade)
                        {
                            dataGridViewResults.Rows.Add(students[i].LastName, students[i].FirstName,
                                students[i].Group, students[i].Grade);
                            foundCount++;
                        }
                    }
                    if (foundCount > 0)
                    {
                        MessageBox.Show($"Найдено студентов из группы '{searchGroup}' с оценкой {targetGrade}: {foundCount}",
                            "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridViewResults.Rows.Add("Ответ не найден", "", "", "");
                        MessageBox.Show($"Студенты из группы '{searchGroup}' с оценкой {targetGrade} не найдены.",
                            "Ответ не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericRecordCount_ValueChanged(object sender, EventArgs e)// Обработчик изменения количества записей
        {
            int targetRowCount = (int)numericRecordCount.Value;
            int currentRowCount = dataGridViewInput.Rows.Count;
            int actualRowCount = currentRowCount;// Убираем строку для новой записи при подсчете
            if (currentRowCount > 0 && dataGridViewInput.Rows[currentRowCount - 1].IsNewRow)
            {
                actualRowCount--;
            }
            if (targetRowCount > actualRowCount)
            {
                for (int i = actualRowCount; i < targetRowCount; i++)// Добавляем строки
                {
                    dataGridViewInput.Rows.Add();
                }
            }
            else if (targetRowCount < actualRowCount)
            {
                for (int i = actualRowCount - 1; i >= targetRowCount; i--)// Удаляем лишние строки
                {
                    if (i < dataGridViewInput.Rows.Count)
                    {
                        dataGridViewInput.Rows.RemoveAt(i);
                    }
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewInput.Rows.Clear();
            dataGridViewResults.Rows.Clear();
            txtGroup.Clear();
            cmbGrade.SelectedIndex = -1;
            numericRecordCount.Value = 0;
            studentCount = 0;
            MessageBox.Show("Все данные очищены!", "Очистка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
