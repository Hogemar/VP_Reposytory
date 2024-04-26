using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Schema;

namespace ImageEditor
{

    internal static class ImageProcess
    {

        public static byte[] BmpToArray(Bitmap source)
        {
            int width = source.Width;
            int height = source.Height;
            var result = new byte[width * height * 3];

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Color pixel = source.GetPixel(i, j);
                    int index = (j * width + i) * 3;
                    result[index] = pixel.B; // Сначала записываем компонент синего цвета
                    result[index + 1] = pixel.G; // Затем зеленый
                    result[index + 2] = pixel.R; // Наконец, красный
                }
            }

            return result;
        }

        public static Bitmap ArrayToBmp(byte[] source, int width, int height)
        {
            var result = new Bitmap(width, height);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int index = (j * width + i) * 3;
                    Color color = Color.FromArgb(source[index + 2], 
                                                source[index + 1], 
                                                source[index]); // Считываем в обратном порядке
                    result.SetPixel(i, j, color);
                }
            }

            return result;
        }

        public static int RgbRange(int value) => Math.Max(0, Math.Min(value, 255));

        public static Bitmap FilterImage(Bitmap source)
        {
            byte[] src = BmpToArray(source);
            byte[] res = new byte[src.Length];

            // Маска для применения фильтра
            int[,] matrix = new int[3, 3]
            {
        { 0, -1, 0 },
        { -1, 5, -1 },
        { 0, -1, 0 }
            };

            int width = source.Width;
            int height = source.Height;

            // Проходим по каждому пикселю изображения
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int r = 0;
                    int g = 0;
                    int b = 0;

                    // Проходим по каждому элементу маски
                    for (int p = 0; p < 3; p++)
                    {
                        for (int q = 0; q < 3; q++)
                        {
                            // Вычисляем индексы соседних пикселей
                            int neighborX = i - 1 + p;
                            int neighborY = j - 1 + q;

                            // Проверяем, находимся ли мы в пределах изображения
                            if (neighborX >= 0 && neighborX < width && neighborY >= 0 && neighborY < height)
                            {
                                // Вычисляем индекс в одномерном массиве для соседнего пикселя
                                int neighborIndex = (neighborY * width + neighborX) * 3;

                                // Применяем маску к соседнему пикселю и добавляем к общей сумме
                                b += src[neighborIndex] * matrix[q, p]; // Сначала синий
                                g += src[neighborIndex + 1] * matrix[q, p]; // Затем зеленый
                                r += src[neighborIndex + 2] * matrix[q, p]; // Наконец, красный
                            }
                        }
                    }

                    b = RgbRange(b);
                    g = RgbRange(g);
                    r = RgbRange(r);

                    // Вычисляем новое значение цвета пикселя и записываем его в результирующий массив
                    int currentIndex = (j * width + i) * 3;
                    res[currentIndex] = (byte)b; // Сначала синий
                    res[currentIndex + 1] = (byte)g; // Затем зеленый
                    res[currentIndex + 2] = (byte)r; // Наконец, красный
                }
            }

            // Преобразуем массив байт обратно в изображение
            return ArrayToBmp(res, width, height);
        }


        //Создание Гауссова ядра
        private static double[,] CreateGaussianKernel(int radius)
        {
            // Вычисление размера ядра по радиусу
            int size = 2 * radius + 1;

            // Создание массива для хранения ядра Гауссова фильтра
            double[,] kernel = new double[size, size];

            // Вычисление значения сигмы для Гауссова распределения
            double sigma = radius / 3.0; // Значение сигмы подбирается эмпирически

            // Переменная для хранения суммы всех значений в ядре
            double sum = 0;

            // Проход по всем элементам ядра
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    // Вычисление расстояния до текущего элемента ядра
                    double r = Math.Sqrt(i * i + j * j);

                    // Вычисление значения Гауссовой функции для данного расстояния
                    double value = Math.Exp(-(r * r) / (2 * sigma * sigma)) / (2 * Math.PI * sigma * sigma);

                    // Запись значения в ядро Гауссова фильтра
                    kernel[i + radius, j + radius] = value;

                    // Подсчет суммы всех значений в ядре
                    sum += value;
                }
            }

            // Нормализация ядра
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // Деление каждого элемента ядра на сумму всех значений
                    kernel[i, j] /= sum;
                }
            }

            // Возврат ядра Гауссова фильтра
            return kernel;
        }

        public static Bitmap ApplyGaussianBlur(Bitmap source, int radius)
        {
            // Создание Гауссова ядра
            double[,] kernel = CreateGaussianKernel(radius);

            byte[] src = BmpToArray(source);
            byte[] res = new byte[src.Length];

            int width = source.Width;
            int height = source.Height;

            // Проходим по каждому пикселю изображения
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    double r = 0;
                    double g = 0;
                    double b = 0;

                    // Проходим по каждому элементу Гауссова ядра
                    for (int p = -radius; p <= radius; p++)
                    {
                        for (int q = -radius; q <= radius; q++)
                        {
                            // Вычисляем индексы соседних пикселей
                            int neighborX = i + p;
                            int neighborY = j + q;

                            // Проверяем, находимся ли мы в пределах изображения
                            if (neighborX >= 0 && neighborX < width && neighborY >= 0 && neighborY < height)
                            {
                                // Вычисляем индекс в одномерном массиве для соседнего пикселя
                                int neighborIndex = (neighborY * width + neighborX) * 3;

                                // Применяем Гауссово ядро к соседнему пикселю и добавляем к общей сумме
                                b += src[neighborIndex] * kernel[q + radius, p + radius]; // Сначала синий
                                g += src[neighborIndex + 1] * kernel[q + radius, p + radius]; // Затем зеленый
                                r += src[neighborIndex + 2] * kernel[q + radius, p + radius]; // Наконец, красный
                            }
                        }
                    }

                    // Вычисляем новое значение цвета пикселя и записываем его в результирующий массив
                    int currentIndex = (j * width + i) * 3;
                    res[currentIndex] = (byte)b; // Сначала синий
                    res[currentIndex + 1] = (byte)g; // Затем зеленый
                    res[currentIndex + 2] = (byte)r; // Наконец, красный
                }
            }

            // Преобразуем массив байт обратно в изображение
            return ArrayToBmp(res, width, height);
        }

    }

}
