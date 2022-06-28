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
    public partial class EditorForm : Form
    {
        BindingList<Question> questions;
        public EditorForm()
        {
            InitializeComponent();
            questions = new BindingList<Question>();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Question>));

            SaveFileDialog sfd = new SaveFileDialog();
            String fileName;
            sfd.Filter = "quiz files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) fileName = sfd.FileName; else return;
            
            Stream fStream = new FileStream(fileName, FileMode.Create,FileAccess.Write);
            xmlFormat.Serialize(fStream, questions);
            fStream.Close();

            MessageBox.Show($"Список вопросов успешно сохранен в файле {fileName}","Данные сохранены!",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void Load_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Question>));

            OpenFileDialog ofd = new OpenFileDialog();
            String fileName;
            ofd.Filter = "quiz files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) fileName = ofd.FileName; else return;

            Stream fStream = new FileStream(fileName, FileMode.Open,
            FileAccess.Read);
            questions = (BindingList<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();

            MessageBox.Show($"Список вопросов из файла {fileName} успешно загружен", "Данные загружены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dGV.DataSource = questions;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            dGV.DataSource = questions;
        }

        private void удалитьПоследнююЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questions.RemoveAt(questions.Count - 1);
        }
    }
}
