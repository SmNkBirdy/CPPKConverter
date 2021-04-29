using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Resources;

namespace CPPKConverter
{
    public partial class Form1 : Form
    {
        public string filePath;
        List<string> fileText;
        public Form1()
        {
            InitializeComponent();
        }

        //код для драг и дропа(если он не работает то скорее всего вы запустили программу от имени админа
        //т.к. нельзя переносить файлы из приложения с низкими правами в приложение с высокими, хз почему но это так)
        private void fileEater_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void fileEater_DragDrop(object sender, DragEventArgs e)
        {
            filePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            dropInfo.Text = filePath;
        }

        //код для выбора файла при помощи нажатия
        OpenFileDialog fD = new OpenFileDialog();

        private void fileEater_Click(object sender, EventArgs e)
        {
            if (fD.ShowDialog() == DialogResult.OK)
            {
                dropInfo.Text = fD.FileName;
                filePath = fD.FileName;
            }
        }

        //код кнопки обработать файл
        private void scanFileButton_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
            string fileNameText = filePath.Split('\\')[filePath.Split('\\').Length-1];
            string fileTypeText = fileNameText.Split('.')[fileNameText.Split('.').Length-1];
            fileName.Text = fileNameText;
            fileType.Text = fileTypeText;
            panel2.Visible = true;
            //если файл ТКСТИ то пытаемся посчитать вопросы, если найдены вопросы то позваляем конвертировать файл
            bool check = fileTypeText == "txt";
            if (check)
            {
                fileText = fileScripts.readFile(filePath);
                fileQuestions.Text = "Количество вопросов в файле: " + fileScripts.countQuestions(fileText);
                fileEater.BackgroundImage = Properties.Resources._3;
                check = fileScripts.countQuestions(fileText) > 0;
            }
            else if (fileTypeText == "docx" || fileTypeText == "doc")
            {
                fileText = fileScripts.docToList(filePath);
                fileQuestions.Text = "Количество вопросов в файле не известно.";
                check = true;
            }
            else
            {
                fileQuestions.Text = "Неизвестное разрешение файла";
                fileEater.BackgroundImage = Properties.Resources._4;
            }

            //включение\выключение конвертации

            label2.Enabled = check;
            label4.Enabled = check;
            label5.Enabled = check;
            label6.Enabled = check;
            label7.Enabled = check;
            label8.Enabled = check;
            bakeStatus.Enabled = check;
            convertButton.Enabled = check;
            radioButton1.Enabled = check;
            radioButton2.Enabled = check;
            radioButton3.Enabled = check;
            radioButton4.Enabled = check;
            courseName.Enabled = check;
            themeName.Enabled = check;
            newFileName.Enabled = check;
            newFilePath.Enabled = check;
            folderChoose.Enabled = check;
            }
        }

        //импорт скриптов для функционала верхней плашки (она кастомная стандартная выключена)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //скрипты кнопок закрытия или минимизации окна
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //скрипт кнопки конвертации
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //lazy
                fileScripts.lazyConvert(fileText,courseName.Text,themeName.Text,newFilePath.Text + newFileName.Text + ".txt");
                bakeStatus.Text = newFileName.Text + ".txt готов!";
            }
            else if (radioButton2.Checked)
            {
                //xml1
                fileScripts.xlmConvert(fileText, courseName.Text, themeName.Text, newFilePath.Text + newFileName.Text + ".xml");
                bakeStatus.Text = newFileName.Text + ".xml готов!";
            }
            else if (radioButton3.Checked)
            {
                //moodle
                fileScripts.moodleConvert(fileText, courseName.Text, themeName.Text, newFilePath.Text + newFileName.Text + ".gift");
                bakeStatus.Text = newFileName.Text + ".gift готов!";
            }
            else
            {
                //xml2
                fileScripts.xlmSecondConvert(fileText, courseName.Text, themeName.Text, newFilePath.Text + newFileName.Text + ".xml");
                bakeStatus.Text = newFileName.Text + ".xml готов!";
            }
        }

        //скрипт кнопки выбора фолдера
        FolderBrowserDialog folderD = new FolderBrowserDialog();
        private void folderChoose_MouseClick(object sender, MouseEventArgs e)
        {
            if (folderD.ShowDialog() == DialogResult.OK)
            {
                newFilePath.Text = folderD.SelectedPath + "\\";
            }
        }
    }
}
