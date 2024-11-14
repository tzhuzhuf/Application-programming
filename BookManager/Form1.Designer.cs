using System.Drawing;
using System.Windows.Forms;

namespace NoteList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTitle = new TextBox();
            comboBoxCategory = new ComboBox();
            listBoxNotes = new ListBox();
            textBox1 = new TextBox();
            AddNote = new Button();
            ChangeNote = new Button();
            DeleteNote = new Button();
            textBoxContent = new TextBox();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.White;
            textBoxTitle.Location = new Point(641, 34);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(341, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.WhiteSmoke;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(641, 87);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(341, 28);
            comboBoxCategory.TabIndex = 1;
            // 
            // listBoxNotes
            // 
            listBoxNotes.FormattingEnabled = true;
            listBoxNotes.Location = new Point(21, 23);
            listBoxNotes.Name = "listBoxNotes";
            listBoxNotes.Size = new Size(596, 644);
            listBoxNotes.TabIndex = 2;
            listBoxNotes.Click += listBoxNotes_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 687);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(596, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddNote
            // 
            AddNote.BackColor = Color.LightGray;
            AddNote.Location = new Point(641, 516);
            AddNote.Name = "AddNote";
            AddNote.Size = new Size(341, 41);
            AddNote.TabIndex = 4;
            AddNote.Text = "Добавить";
            AddNote.UseVisualStyleBackColor = false;
            AddNote.Click += AddNote_Click;
            // 
            // ChangeNote
            // 
            ChangeNote.BackColor = Color.LightGray;
            ChangeNote.Location = new Point(641, 563);
            ChangeNote.Name = "ChangeNote";
            ChangeNote.Size = new Size(341, 41);
            ChangeNote.TabIndex = 4;
            ChangeNote.Text = "Изменить";
            ChangeNote.UseVisualStyleBackColor = false;
            ChangeNote.Click += ChangeNote_Click;
            // 
            // DeleteNote
            // 
            DeleteNote.BackColor = Color.LightGray;
            DeleteNote.Location = new Point(641, 610);
            DeleteNote.Name = "DeleteNote";
            DeleteNote.Size = new Size(341, 41);
            DeleteNote.TabIndex = 4;
            DeleteNote.Text = "Удалить";
            DeleteNote.UseVisualStyleBackColor = false;
            DeleteNote.Click += DeleteNote_Click;
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(641, 121);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(341, 389);
            textBoxContent.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(994, 739);
            Controls.Add(textBoxContent);
            Controls.Add(DeleteNote);
            Controls.Add(ChangeNote);
            Controls.Add(AddNote);
            Controls.Add(textBox1);
            Controls.Add(listBoxNotes);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private ComboBox comboBoxCategory;
        private ListBox listBoxNotes;
        private TextBox textBox1;
        private Button AddNote;
        private Button ChangeNote;
        private Button DeleteNote;
        private TextBox textBoxContent;
    }
}
