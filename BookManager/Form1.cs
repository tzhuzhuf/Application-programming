using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

namespace NoteList
{
    public partial class Form1 : Form
    {
        List<Note> notes = new List<Note>();

        public Form1()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            comboBoxCategory.Items.Add("Личные");
            comboBoxCategory.Items.Add("Работа");
            comboBoxCategory.Items.Add("Учеба");
            comboBoxCategory.Items.Add("Другое");
            comboBoxCategory.SelectedIndex = 0;
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            string content = textBoxContent.Text.Trim();
            string category = comboBoxCategory.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Note newNote = new Note(title, content, category);
            notes.Add(newNote);
            listBoxNotes.Items.Add(newNote);

            ClearInputs();
        }

        private void ClearInputs()
        {
            textBoxContent.Clear();
            textBoxTitle.Clear();
        }

        private void DeleteNote_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex < 0)
            {
                MessageBox.Show("Пожалуйста, выберите заметку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxNotes.SelectedIndex >= 0)
            {
                int selectIndex = listBoxNotes.SelectedIndex;
                notes.RemoveAt(selectIndex);
                listBoxNotes.Items.RemoveAt(selectIndex);
                ClearInputs();
            }

            listBoxNotes.Invalidate();
        }

        private void ChangeNote_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex < 0)
            {
                MessageBox.Show("Пожалуйста, выберите заметку для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxNotes.SelectedIndex >= 0)
            {
                int selectIndex = listBoxNotes.SelectedIndex;

                notes[selectIndex].Title = textBoxTitle.Text;
                notes[selectIndex].Content = textBoxContent.Text;
                notes[selectIndex].Category = comboBoxCategory.SelectedItem?.ToString();

                listBoxNotes.Items[selectIndex] = notes[selectIndex];
                ClearInputs();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.ToLower();
            listBoxNotes.Items.Clear();

            var filterNotes = notes.Where(note => note.Title.ToLower().Contains(keyword) || note.Content.ToLower().Contains(keyword)).ToList();

            foreach (var filterNote in filterNotes)
            {
                listBoxNotes.Items.Add(filterNote);
            }
        }


        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNote = notes[listBoxNotes.SelectedIndex];
            textBoxTitle.Text = selectedNote.Title;
            textBoxContent.Text = selectedNote.Content;
            comboBoxCategory.SelectedItem = selectedNote.Category;
        }
    }
}
