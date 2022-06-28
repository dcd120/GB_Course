using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace HW8
{
    public partial class GameForm : Form
    {
        BindingList<Question> questions;
        int Score;
        int CurrentQ;

        bool isGameActive;
        public GameForm()
        {
            InitializeComponent();
            questions = new BindingList<Question>();
            Score = 0;
            CurrentQ = 0;
            isGameActive = false;
        }


        public void NewGame()
        { 
            Score = 0;
            CurrentQ = 0;
            // загружаем вопросы из файла
            XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Question>));

            OpenFileDialog ofd = new OpenFileDialog();
            String fileName;
            ofd.Filter = "quiz files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) fileName = ofd.FileName; else return;

            Stream fStream = new FileStream(fileName, FileMode.Open,
            FileAccess.Read);
            questions = (BindingList<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();

            //MessageBox.Show($"Список вопросов из файла {fileName} успешно загружен", "Данные загружены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // удаляем некорректные вопросы, если вдруг такие есть
            isGameActive=true;
            update();
        }
        public void Choose(int var)
        {
            // проверим, правильный ли вариант
            if (var == questions[CurrentQ].CorrectVariant)
            {
                // сообщаем об этом пользователю!
                MessageBox.Show("Это правильный ответ!", "Верно!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Score++;
            }
            else 
            {
                // сообщаем о неверном ответе!
                MessageBox.Show("Это НЕ верный ответ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CurrentQ++;
            if (CurrentQ == questions.Count)
            {
                if (MessageBox.Show($"Игра окончена!\nВам удалось набрать {Score} очков из {questions.Count} возможных!\nЖелаете сыграть еще раз?", "Игра окончена!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    isGameActive = false;
                    NewGame();
                }
                else {
                    this.Close();
                    isGameActive = false;
                }
            }
            update();
        }
        public void update()
        {
            if (isGameActive)
            {
                // если вдруг мы выбрали все вопросы, то игра окончена!
                if ((CurrentQ > questions.Count) || (questions.Count == 0)) { isGameActive = false; update(); return; }

                // включаем кнопки, иначе - выключаем
                Sel_0.Enabled = true;
                Sel_1.Enabled = true;
                Sel_2.Enabled = true;
                Sel_3.Enabled = true;

                label1.Text = $"Количество очков: {Score}";
                TitleLBL.Text = $"Вопрос №{CurrentQ+1} из {questions.Count}:\t {questions[CurrentQ].Title}";
                DescLBL.Text = $"\t{questions[CurrentQ].Description}\t";
                // Варианты ответов присваиваем кнопкам
                Sel_0.Text = $"A:\t{questions[CurrentQ].Variant0}";
                Sel_1.Text = $"B:\t{questions[CurrentQ].Variant1}";
                Sel_2.Text = $"C:\t{questions[CurrentQ].Variant2}";
                Sel_3.Text = $"D:\t{questions[CurrentQ].Variant3}";


            } else {
                Sel_0.Enabled = false;
                Sel_1.Enabled = false;
                Sel_2.Enabled = false;
                Sel_3.Enabled = false;

                label1.Text = $"Количество очков: 00";
                TitleLBL.Text = $"Вопрос №0";
                DescLBL.Text = $"\tДумаем...\t";
                // Варианты ответов присваиваем кнопкам
                Sel_0.Text = $"A:";
                Sel_1.Text = $"B:";
                Sel_2.Text = $"C:";
                Sel_3.Text = $"D:";
            }

        }

        private void Sel_0_Click(object sender, EventArgs e)
        {
            Choose(0);
        }

        private void Sel_1_Click(object sender, EventArgs e)
        {
            Choose(1);
        }

        private void Sel_2_Click(object sender, EventArgs e)
        {
            Choose(2);
        }

        private void Sel_3_Click(object sender, EventArgs e)
        {
            Choose(3);
        }

        private void NewGameBTN_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
