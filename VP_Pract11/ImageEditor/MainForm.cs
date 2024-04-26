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

using System.Drawing.Imaging;

namespace ImageEditor
{

    public partial class MainForm : Form
    {
        private Bitmap _sourceImage;
        private Stack<Bitmap> _undoStack; // Стек для хранения предыдущих состояний изображения
        private Stack<Bitmap> _redoStack; // Стек для хранения отмененных изменений
        private string _sourceFileName;

        public MainForm()
        {
            InitializeComponent();
            // обработчик события KeyDown
            this.KeyDown += MainForm_KeyDown;
            // Добавляем обработчик события KeyDown для pictureBox
            pictureBox.KeyDown += MainForm_KeyDown;
       

            // Устанавливаем фокус на форму, чтобы она могла получать события клавиатуры
            this.Focus();
            // Инициализация стеков
            _undoStack = new Stack<Bitmap>();
            _redoStack = new Stack<Bitmap>();

            pictureBox.Enabled = false;
            imageMenuItem.Enabled = false;
            saveAsMenuItem.Enabled = false;
            gaussKoef.Visible = true;
            undo.Enabled = false;
            redo.Enabled = false;
            this.KeyPreview = true;

            /// openFileDialog
            openFileDialog.Filter = "Изображения(*.bmp; *.jpeg; *.jpg)|*.bmp; *.jpeg; *.jpg";

            /// saveFileDialog
            saveFileDialog.Filter = "Изображение BMP|*.bmp|" +
                "Изображение JPEG|*.jpeg|" +
                "Изображение JPG|*.jpg";

            /// picturebox
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() != DialogResult.OK) return;

            _sourceFileName = openFileDialog.FileName;
            _sourceImage = new Bitmap(_sourceFileName);
            pictureBox.Image = _sourceImage;
            //pictureBox.Size = _sourceImage.Size
            this.Width = pictureBox.Width + 40;
            this.Height = pictureBox.Height + 77;
            //this.CenterToScreen();
            pictureBox.Enabled = true;
            imageMenuItem.Enabled = true;
            saveAsMenuItem.Enabled = true;
            undo.Enabled = true;
            redo.Enabled = true;

            saveMenuItem_Click(this, new EventArgs());
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            _undoStack.Clear();
            _redoStack.Clear();

            _sourceImage = new Bitmap(pictureBox.Image);
            pictureBox.Image.Dispose();

            File.Delete(_sourceFileName);
            _sourceImage.Save(_sourceFileName);

            pictureBox.Image = _sourceImage;
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName == "") return;
            
           // /*FileStream*/ var fs = saveFileDialog.OpenFile();

            switch (saveFileDialog.FilterIndex)
            {
                case 1: //bmp
                    pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                    break;
                case 2: //jpeg
                case 3: //jpg
                    pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    break;
            }

           // fs.Close();
        }

        private void exitMenuItem_Click(object sender, EventArgs e) => this.Close();



        private void filterMenuItem_Click(object sender, EventArgs e)
        {
            //var resultBitmap = ImageProcess.FilterImage(_sourceImage);
            //pictureBox.Image = resultBitmap;

            // Сохранение текущего состояния изображения перед применением изменений
            PushUndoStack();
            
            pictureBox.Image = ImageProcess.FilterImage(new Bitmap(pictureBox.Image));

            // Очистка стека отмены при применении новых изменений
            _redoStack.Clear();

            MessageBox.Show("Выполнено повышение контрастности", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GaussMenuItem_Click(object sender, EventArgs e)
        {
            gaussKoef.Visible = true;
            // Получение значения из текстового поля gaussKoef
            if (int.TryParse(gaussKoef.Text, out int blurRadius) && blurRadius > 0)
            {
                // Сохранение текущего состояния изображения перед применением изменений
                PushUndoStack();

                // Применение размытия по Гауссу с указанным радиусом
                pictureBox.Image = ImageProcess.ApplyGaussianBlur(new Bitmap(pictureBox.Image), (int)blurRadius);

                // Очистка стека отмены при применении новых изменений
                _redoStack.Clear();

                MessageBox.Show("Выполнено Гауссово размытие",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Пожалуйста, введите корректное число больше нуля в поле для размытия.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
          
        }

        private void undo_Click(object sender, EventArgs e)
        {
            // Проверка наличия предыдущего состояния изображения в стеке отмены
            if (_undoStack.Count > 0)
            {
                // Сохранение текущего состояния изображения перед применением изменений
                PushRedoStack();

                // Откат к предыдущему состоянию изображения
                Bitmap previousImage = _undoStack.Pop();
                pictureBox.Image = (Bitmap)previousImage.Clone();
            }
            else MessageBox.Show("Предыдущего состояния изображения нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void redu_Click(object sender, EventArgs e)
        {
            // Проверка наличия отмененных состояний изображения в стеке повтора
            if (_redoStack.Count > 0)
            {
                // Сохранение текущего состояния изображения перед применением изменений
                PushUndoStack();

                // Возврат к следующему состоянию изображения
                Bitmap nextImage = _redoStack.Pop();
                pictureBox.Image = (Bitmap)nextImage.Clone();
            }
            else MessageBox.Show("Более поздних состояний изображения нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PushUndoStack()
        {
            // Клонирование текущего изображения и добавление его в стек отмены
            _undoStack.Push((Bitmap)pictureBox.Image.Clone());
        }

        private void PushRedoStack()
        {
            // Клонирование текущего изображения и добавление его в стек повтора
            _redoStack.Push((Bitmap)pictureBox.Image.Clone());
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Если нажата комбинация клавиш для отмены (Ctrl + Z)
            if (e.Control && e.KeyCode == Keys.Z)
            {
                undo_Click(sender, e); // Вызываем метод отмены изменений
            }
            // Если нажата комбинация клавиш для возврата изменений (Ctrl + Y)
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                redu_Click(sender, e); // Вызываем метод возврата изменений
            }

            //// Если нажата комбинация клавиш для сохраненияКак (Ctrl + S)
            else if (e.Control && e.KeyCode == Keys.S)
            {
                saveAsMenuItem_Click(sender,e); // Вызываем метод сохранения изображения
            }
        }

    }

}
