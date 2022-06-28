using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Editor_Click(object sender, EventArgs e)
        {
            EditorForm ef = new EditorForm();
            ef.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор игры: \tЗаривной Николай \nРазработано в рамках учебного курса по азам C#\nПреподаватель: \tБайраковский Станислав\n28.06.2022 г.","О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
