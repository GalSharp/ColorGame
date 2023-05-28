using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class Form1 : Form
    {
        //Список переменных
        private int score;
        private Dictionary<String, Color> colorsDictionary;
        private Button[] buttons;
        private List<Color> colorsList;
        private List<String> colorsText;
        Random random;
        private int previousScore = 0;
        private PictureBox[] health;// Жизни
        private int healthCount;// Количество сердечек
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()// Инициализация переменных
        {
            colorsDictionary = new Dictionary<String, Color>()
            {
                {"Зеленый", Color.Green},
                {"Желтый", Color.Yellow},
                {"Синий", Color.Blue},
                {"Красный", Color.Red},
                {"Черный", Color.Black},
                {"Фиолетовый", Color.Purple},
                {"Оранжевый", Color.Orange}
            };
            health = new PictureBox[]
            {
                health1,
                health2,
                health3
            };
            healthCount = health.Length - 1;
            buttons = new Button[]
            {
                button1,
                button2,
                button3
            };
            colorsText = new List<string>();
            colorsList = new List<Color>();
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
            score = 0;
            random = new Random();
            NextMove();
        }
        private void FillList()// Заполнение листов
        {
            colorsText = colorsDictionary.Keys.ToList();
            colorsList = colorsDictionary.Values.ToList();
            colorsText.Remove(colorsDictionary.ElementAt(GetIndex()).Key);// Удаляем текст цвета нашей надписи чтобы не было повторений
        }
        private void ScoreLabelUpdate()// Обновление надписи очков
        {
            scoreLabel.Text = $"ОЧКИ: {score}";
        }
        private void SetLabel()// Настройка главной надписи
        {
            mainLabel.Text = colorsDictionary.ElementAt(random.Next(colorsDictionary.Count)).Key;// Записываем в надпись случайный цвет
            mainLabel.ForeColor = colorsDictionary.ElementAt(random.Next(colorsDictionary.Count)).Value;// Присваиваем надписи случайный цвет
            colorsList.Remove(mainLabel.ForeColor);// Удаляем цвет из листа цветов
            colorsText.Remove(mainLabel.Text);// Удаляем цвет как текст из листа цветов
        }
        private void SetButtons()// Настройка кнопок
        {
            int rightButtonIndex = random.Next(buttons.Length);// Выбираем рандомную правильную кнопку
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].ForeColor = colorsList[random.Next(colorsList.Count)];// Цвет тексту кнопки выбираем рандомный
                colorsList.Remove(buttons[i].ForeColor);// Удаляем этот цвет чтобы не было повторений
                if (i == rightButtonIndex)// Проверка правильная у нас кнопка или нет
                {
                    buttons[i].Text = colorsDictionary.ElementAt(GetIndex()).Key;// Если правильная то находим цвет нашей надписи и берем от цвета текст в словаре 
                }
                else
                {
                    buttons[i].Text = colorsText[random.Next(colorsText.Count)];// Устанавливаем кнопке рандомный текст
                }
                colorsText.Remove(buttons[i].Text);// Удаляем текст чтобы не было повторений
            }
        }
        private void NextMove()// Следующий ход
        {
            SetLabel();// Настраиваем  главную надпись
            FillList();// Заполняем листы
            SetButtons();// Настраиваем кнопки
            ScoreLabelUpdate();// Обновляем очки
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int scoreUpdate = button.Text == colorsDictionary.ElementAt(GetIndex()).Key ? 50 : 0;// Проверяем правильный ли мы сделали выбор
                Check(scoreUpdate);
            }
        }
        private void Check(int scoreCount = 0)
        {
            progressBar.Value = 100;
            score += scoreCount;
            if (scoreCount == 0) MinusHealth();
            NextMove();
            if (healthCount < 0 || score >= 1000)
            {
                WinOrLose();
            }
            if (score % 100 == 0 && score > previousScore)
            {
                timer.Interval -= 5;
                previousScore = score;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 0)
            {
                Check();
            }
            else
                progressBar.Value--;
        }
        private int GetIndex()// Получаем индекс нашей главной надписи
        {
            int index = 0;
            foreach (Color color in colorsDictionary.Values)
            {
                if (color == mainLabel.ForeColor) break; // Если цвет равен цвету нашей надписи то выходим из цикла
                index++;
            }
            return index;// Возвращаем найденный индекс
        }
        private void WinOrLose()// Функция которая отвечает за победу и проигрыш
        {
            timer.Stop();
            var result = MessageBox.Show($"Вы {(healthCount < 0 ? "Проиграли" : "Победили")}\nЖелаете сыграть еще раз???", "Игра окончена", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
        private void MinusHealth()// Урон
        {
            health[healthCount].Visible = false;
            healthCount--;
        }
    }
}
