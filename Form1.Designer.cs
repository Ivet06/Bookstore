namespace Книжарница
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
            listGenre = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listGenre
            // 
            listGenre.BackColor = SystemColors.Control;
            listGenre.BorderStyle = BorderStyle.None;
            listGenre.FormattingEnabled = true;
            listGenre.ItemHeight = 25;
            listGenre.Items.AddRange(new object[] { "Хуманитарна литература", "Художествена литература", "Психология", "Компютри", "Чужди езици", "Техника", "Медицина", "Икономика", "Справочна литература", "Право", "Хоби", "Педагогика", "Друг" });
            listGenre.Location = new Point(1002, 462);
            listGenre.Name = "listGenre";
            listGenre.Size = new Size(10, 0);
            listGenre.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(293, 140);
            button1.Name = "button1";
            button1.Size = new Size(154, 62);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 630);
            Controls.Add(button1);
            Controls.Add(listGenre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listGenre;
        private Button button1;
    }
}
