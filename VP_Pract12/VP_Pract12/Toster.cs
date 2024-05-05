using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Pract12
{
    public partial class Toster : Form
    {
        private int remainingTimeSeconds = 0;
        private Timer timer = new Timer();
        private bool isTimerRunning = false; // Флаг для отслеживания состояния таймера

        public Toster()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeComboBoxes();

            // Заблокировать кнопку Старт при запуске
            startButton.Enabled = true;
        }

        private void InitializeTimer()
        {
            timer.Interval = 1000; // Интервал в миллисекундах (1000 мс = 1 секунда)
            timer.Tick += Timer_Tick; // Привязываем обработчик события Tick
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTimeSeconds--;

            if (remainingTimeSeconds <= 0)
            {
                timer.Stop();
                remainingTimeLabel.Text = "00:00:00";
                startButton.Enabled = true; // Разблокировать кнопку Старт по истечении времени
            }
            else
            {
                // Обновляем Label с оставшимся временем
                remainingTimeLabel.Text = TimeSpan.FromSeconds(remainingTimeSeconds).ToString(@"hh\:mm\:ss");
            }
        }

        private void InitializeComboBoxes()
        {
            // Добавляем варианты в комбо-боксы
            breadTypeComboBox.Items.AddRange(new object[] { "Белый", "Ржаной" });
            slicesComboBox.Items.AddRange(new object[] { "1 ломтик", "2 ломтика" });

            // Устанавливаем стиль комбо-бокса, чтобы пользователь не мог вводить текст
            breadTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            slicesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Выбираем первый элемент по умолчанию
            breadTypeComboBox.SelectedIndex = 0;
            slicesComboBox.SelectedIndex = 0;
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            // Блокировать кнопку Старт при нажатии, пока идет таймер
            startButton.Enabled = false;

            // Считываем значения выбранных параметров
            string breadType = breadTypeComboBox.SelectedItem.ToString();
            int slicesCount = slicesComboBox.SelectedIndex + 1;
            int toastTimeSeconds;

            if (!int.TryParse(toastTimeTextBox.Text, out toastTimeSeconds) || toastTimeSeconds < 1 || toastTimeSeconds > 300)
            {
                MessageBox.Show("Пожалуйста, введите корректное время поджарки (от 1 до 300 секунд).", "Ошибка");
                startButton.Enabled = true; // Разблокировать кнопку Старт при некорректных данных
                return;
            }

            remainingTimeSeconds = toastTimeSeconds;
            remainingTimeLabel.Text = TimeSpan.FromSeconds(remainingTimeSeconds).ToString(@"hh\:mm\:ss");

            timer.Start();

            // Имитация поджарки
            await Task.Delay(toastTimeSeconds * 1000);

            timer.Stop();
            for (int i = 0; i < 3; i++)
            {
                Console.Beep(1000, 250);
                System.Threading.Thread.Sleep(100);
            }

            // Отображаем уведомление о завершении поджарки
            string toastStatus = GetToastStatus(toastTimeSeconds);
            MessageBox.Show($"Хлеб поджарен ({toastStatus})!", "Уведомление");

            // Сброс выбранных параметров после завершения поджарки
            breadTypeComboBox.SelectedIndex = 0;
            slicesComboBox.SelectedIndex = 0;
            toastTimeTextBox.Clear();
            remainingTimeLabel.Text = "00:00:00";
            startButton.Enabled = true; // Разблокировать кнопку Старт после завершения поджарки
        }

        private string GetToastStatus(int toastTimeSeconds)
        {
            // Определяем степень прожарки хлеба в зависимости от времени поджарки
            if (toastTimeSeconds <= 60)
            {
                return "легкая прожарка";
            }
            else if (toastTimeSeconds <= 120)
            {
                return "средняя прожарка";
            }
            else if (toastTimeSeconds <= 180)
            {
                return "золотистая прожарка";
            }
            else if (toastTimeSeconds <= 240)
            {
                return "коричневая прожарка";
            }
            else
            {
                return "темная прожарка";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // Проверяем, запущен ли таймер перед его остановкой
            if (timer.Enabled)
            {
                timer.Stop();
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep(1000, 250);
                    System.Threading.Thread.Sleep(100);
                }

                remainingTimeLabel.Text = "00:00:00";
                startButton.Enabled = true; // Разблокировать кнопку Старт при нажатии на Стоп

                // Получаем время поджарки из текстового поля
                int toastTimeSeconds;
                if (!int.TryParse(toastTimeTextBox.Text, out toastTimeSeconds) || toastTimeSeconds < 1 || toastTimeSeconds > 300)
                {
                    MessageBox.Show("Пожалуйста, введите корректное время поджарки (от 1 до 300 секунд).", "Ошибка");
                    return;
                }

                // Получаем оставшееся время поджарки
                int remainingSeconds = toastTimeSeconds - remainingTimeSeconds;

                // Получаем степень прожарки на основе оставшегося времени поджарки
                string toastStatus = GetToastStatus(remainingSeconds);

                // Выводим соответствующее уведомление о прерванной поджарке
                MessageBox.Show($"Поджарка прервана: достигнута степень прожарки '{toastStatus}'", "Уведомление");
            }
        }
    }
}