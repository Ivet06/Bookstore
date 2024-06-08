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
            pageSetupDialog1 = new PageSetupDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            txtCount = new TextBox();
            btnAdd = new Button();
            txtPrice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtTotal = new TextBox();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtName = new TextBox();
            cbType = new ComboBox();
            cbBook = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnNew = new Button();
            btnCheck = new Button();
            btnLoad = new Button();
            txtNSell = new TabPage();
            btnClear = new Button();
            lblSum = new Label();
            label15 = new Label();
            txtNSale = new TextBox();
            lblPrice = new Label();
            btnAddSale = new Button();
            label12 = new Label();
            label11 = new Label();
            cbTitle = new ComboBox();
            label10 = new Label();
            lblChoose = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            txtNSell.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(txtNSell);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1167, 724);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(txtCount);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtTotal);
            tabPage1.Controls.Add(txtPublisher);
            tabPage1.Controls.Add(txtAuthor);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(cbType);
            tabPage1.Controls.Add(cbBook);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(btnNew);
            tabPage1.Controls.Add(btnCheck);
            tabPage1.Controls.Add(btnLoad);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1159, 686);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Въвеждане";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Хуманитарна Литература ", "Художествена Литература", "Психология", "Компютри", "Чужди езици", "Техника", "Медицина", "Икономика", "Справочна литература", "Право", "Хоби", "Педагогика", "Друг" });
            listBox1.Location = new Point(843, 378);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(10, 4);
            listBox1.TabIndex = 47;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(435, 590);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(150, 31);
            txtCount.TabIndex = 46;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(701, 571);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 47);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Добави";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(123, 593);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(350, 596);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 41;
            label8.Text = "Брой:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 593);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 40;
            label9.Text = "Цена:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.InactiveBorder;
            txtTotal.Location = new Point(389, 48);
            txtTotal.Margin = new Padding(4, 5, 4, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(106, 31);
            txtTotal.TabIndex = 39;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(184, 476);
            txtPublisher.Margin = new Padding(4, 5, 4, 5);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(510, 31);
            txtPublisher.TabIndex = 36;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(184, 342);
            txtAuthor.Margin = new Padding(4, 5, 4, 5);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(510, 31);
            txtAuthor.TabIndex = 35;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 278);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(510, 31);
            txtName.TabIndex = 34;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(184, 411);
            cbType.Margin = new Padding(4, 5, 4, 5);
            cbType.Name = "cbType";
            cbType.Size = new Size(510, 33);
            cbType.TabIndex = 33;
            // 
            // cbBook
            // 
            cbBook.FormattingEnabled = true;
            cbBook.Location = new Point(193, 130);
            cbBook.Margin = new Padding(4, 5, 4, 5);
            cbBook.Name = "cbBook";
            cbBook.Size = new Size(596, 33);
            cbBook.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(672, 746);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 31;
            label7.Text = "Брой:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 746);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 30;
            label6.Text = "Цена:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 476);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 29;
            label5.Text = "Издателство:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 411);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 28;
            label4.Text = "Жанр:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 339);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 27;
            label3.Text = "Автор:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 281);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 26;
            label2.Text = "Заглавие:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 25;
            label1.Text = "Общ брой заглавия:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(660, 44);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 38);
            btnSave.TabIndex = 23;
            btnSave.Text = "Запази";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(31, 203);
            btnNew.Margin = new Padding(4, 5, 4, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 47);
            btnNew.TabIndex = 22;
            btnNew.Text = "Ново заглавие";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(31, 119);
            btnCheck.Margin = new Padding(4, 5, 4, 5);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 53);
            btnCheck.TabIndex = 21;
            btnCheck.Text = "Справка";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(31, 43);
            btnLoad.Margin = new Padding(4, 5, 4, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 46);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Зареди";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtNSell
            // 
            txtNSell.Controls.Add(lblChoose);
            txtNSell.Controls.Add(btnClear);
            txtNSell.Controls.Add(lblSum);
            txtNSell.Controls.Add(label15);
            txtNSell.Controls.Add(txtNSale);
            txtNSell.Controls.Add(lblPrice);
            txtNSell.Controls.Add(btnAddSale);
            txtNSell.Controls.Add(label12);
            txtNSell.Controls.Add(label11);
            txtNSell.Controls.Add(cbTitle);
            txtNSell.Controls.Add(label10);
            txtNSell.Location = new Point(4, 34);
            txtNSell.Name = "txtNSell";
            txtNSell.Padding = new Padding(3);
            txtNSell.Size = new Size(1159, 686);
            txtNSell.TabIndex = 1;
            txtNSell.Text = "Продажба";
            txtNSell.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(709, 561);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 64);
            btnClear.TabIndex = 12;
            btnClear.Text = "Изчисти";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblSum
            // 
            lblSum.BackColor = Color.WhiteSmoke;
            lblSum.BorderStyle = BorderStyle.FixedSingle;
            lblSum.Location = new Point(195, 571);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(94, 44);
            lblSum.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(107, 581);
            label15.Name = "label15";
            label15.Size = new Size(58, 25);
            label15.TabIndex = 10;
            label15.Text = "Сума:";
            // 
            // txtNSale
            // 
            txtNSale.BackColor = Color.WhiteSmoke;
            txtNSale.Location = new Point(495, 110);
            txtNSale.Multiline = true;
            txtNSale.Name = "txtNSale";
            txtNSale.Size = new Size(103, 46);
            txtNSale.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.WhiteSmoke;
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Location = new Point(195, 112);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(94, 44);
            lblPrice.TabIndex = 8;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(709, 109);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(115, 64);
            btnAddSale.TabIndex = 6;
            btnAddSale.Text = "Добави";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(394, 129);
            label12.Name = "label12";
            label12.Size = new Size(58, 25);
            label12.TabIndex = 4;
            label12.Text = "Брой:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 129);
            label11.Name = "label11";
            label11.Size = new Size(57, 25);
            label11.TabIndex = 2;
            label11.Text = "Цена:";
            // 
            // cbTitle
            // 
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(168, 31);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(579, 33);
            cbTitle.TabIndex = 1;
            cbTitle.TextChanged += cbTitle_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 39);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 0;
            label10.Text = "Книга:";
            // 
            // lblChoose
            // 
            lblChoose.BackColor = Color.WhiteSmoke;
            lblChoose.FormattingEnabled = true;
            lblChoose.ItemHeight = 25;
            lblChoose.Location = new Point(107, 211);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(520, 304);
            lblChoose.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 721);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Книжарница";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            txtNSell.ResumeLayout(false);
            txtNSell.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PageSetupDialog pageSetupDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage txtNSell;
        
        
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtName;
        private ComboBox cbType;
        private ComboBox cbBook;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
       
        private Button btnSave;
        private Button btnNew;
        private Button btnCheck;
        private Button btnLoad;
        private TextBox txtPrice;
        private Label label8;
        private Label label9;
        private Button btnAdd;
        private TextBox txtCount;
        private ListBox listBox1;
        private TextBox txtTotal;
        private Label label11;
        private ComboBox cbTitle;
        private Label label10;
        private Label lblPrice;
        private Button btnAddSale;
        private Label label12;
        private TextBox txtNSale;
        private Button btnClear;
        private Label lblSum;
        private Label label15;
        private ListBox lblChoose;
    }
}
