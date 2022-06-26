using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    public partial class Form1 : Form
    {
        public int plNu;
        public int cmpNu;
        public int cmndCount;
        Stack<int> steps;
        Random rand;
        public Form1()
        {
            InitializeComponent();

            plNu = 0;
            cmpNu = 0;
            cmndCount = 0; //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
            rand = new Random();
            steps = new Stack<int>();

            NewGame();

        }

        public void update()
        {
            CrntNumber.Text = $"Загаданное число: {cmpNu}";
            usersNumber.Text = $"Ваше число: {plNu}";
            mySteps.Text = $"Сделано ходов: {cmndCount}";
        }

        public void NewGame()
        {
            cmndCount = 0;
            plNu = 0;
            cmpNu = rand.Next(20);
            update();
            steps.Clear();
        }

        public void CheckWin()
        {
            if (plNu == cmpNu) // win
            { if (MessageBox.Show("ТЫ ПОБЕДИЛ! Хочешь сыграть снова?", "Победа!", MessageBoxButtons.YesNo) == DialogResult.Yes) { NewGame(); } else { Application.Exit(); } }
            if (plNu > cmpNu) // lose
            { if (MessageBox.Show("ТЫ ПРОИГРАЛ! Хочешь сыграть снова?", "Проигрышь!", MessageBoxButtons.YesNo) == DialogResult.Yes) { NewGame(); } else { Application.Exit(); } }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Plus1_Click(object sender, EventArgs e)
        {
            steps.Push(plNu);
            plNu++;
            cmndCount++;
            update();
            CheckWin();
        }

        private void Multi2_Click(object sender, EventArgs e)
        {
            steps.Push(plNu);
            plNu *= 2;
            cmndCount++;
            update();
            CheckWin();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ng_Click(object sender, EventArgs e)
        {
            //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
            MessageBox.Show($"Для победы вы должны набрать число {cmpNu} за минимальное количество шагов!", "Как играть");
        }

        private void cancelStep_Click(object sender, EventArgs e)
        {
            //в) *Добавить кнопку «Отменить», которая отменяет последние ходы.
            //Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int> Stack.
            if (steps.Count != 0)
            {
                cmndCount--;
                plNu = steps.Pop();
                update();
            }
        }
    }
}
