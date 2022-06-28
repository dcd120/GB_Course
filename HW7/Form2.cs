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
    public partial class Form2 : Form
    {
        public int compNumber;
        public int userNumber;
        public int count;
        InputTextForm txtForm;
        Random Rand;
        public Form2()
        {
            InitializeComponent();
            Rand = new Random();
            NewGame();
            update();

            // попробуем подключить запрос текста через отдельную форму
            txtForm = new InputTextForm();
        }

        public void NewGame()
        { 
            compNumber = Rand.Next(1,101);
            userNumber = 0;
            count = 0;
        }

        public void update()
        {
            //joke.Text = $"Я загадал число {compNumber}, угадай!";
            joke.Text = $"Я загадал число от 1 до 100! Угадаешь? ({count} попыток)";
            if (userNumber == 0)
            {
                myStatus.Text = "С чего начнем? )";
            } else if (userNumber > compNumber) { myStatus.Text = $"Твое число {userNumber} больше моего!"; }
            else if (userNumber < compNumber) { myStatus.Text = $"Твое число {userNumber} меньше моего!"; }
            else 
            { 
                myStatus.Text = $"Угадал! Я загадал именно {userNumber}!";
                if (MessageBox.Show("Вы выйграли! Желаете попробовать еще раз?", "Победа!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { NewGame(); update(); }
                else { Close(); }    
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //userNumber = int.Parse(plTxt.Text.Trim());
            txtForm.ShowDialog();

            userNumber = int.Parse(txtForm.myN.Text.Trim());

            count++;
            update();
        }
    }
}
