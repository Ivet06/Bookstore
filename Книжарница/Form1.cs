using System.Security.Cryptography;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Runtime.CompilerServices;

namespace Книжарница
{
    public partial class Form1 : Form
    {
        //Декларация на необходимите променливи

        string[] book = new string[100];

        string[] publisher = new string[100];

        string[] author = new string[100];

        string[] type = new string[13];

        int[] bookType = new int[100];

        double[] price = new double[100];

        int[] number = new int[100];

        int i = 0;

        int lastLoaded = 0;

        int k;

        string t;

        string[] lines = new string[100];

        string path = @"C:\Users\banan\Desktop\books.txt";

        int firstAdd;

        double sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitType(listBox1);
            LoadType(cbType);

        }

        private void LoadType(ComboBox cdType)
        {
            cdType.DataSource = type;

        }

        private void InitType(ListBox listBox)
        {
            for (int i = 0; i < type.Length; i++)
            {
                type[i] = listBox.Items[i].ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path, true);

            using (sr)
            {
                //Четене на редовете от текстовия документ
                string[] lines = sr.ReadToEnd().Split("\n").ToArray();

                //Зареждане на елементите след последния зареден
                if (lastLoaded != 0)
                {
                    i = lastLoaded + 1;
                }

                {

                    while (lines[i] != "" && i < lines.Length)
                    {


                        string[] fields = lines[i].Split(", ");

                        book[i] = fields[0];

                        publisher[i] = fields[1];

                        author[i] = fields[2];

                        string genre = fields[3];

                        price[i] = double.Parse(fields[4]);

                        number[i] = int.Parse(fields[5]);

                        bookType[i] = Array.IndexOf(type, genre);



                        cbBook.Items.Add(book[i]);


                        i++;


                    }
                }


                int totalBooks = number.Sum();

                txtTotal.Text = totalBooks.ToString();


                lastLoaded = i - 1;

                cbTitle.DataSource = cbBook.Items;
            }
        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtName.Text = book[cbBook.SelectedIndex];

            txtAuthor.Text = author[cbBook.SelectedIndex];

            txtPublisher.Text = publisher[cbBook.SelectedIndex];

            cbType.SelectedIndex = bookType[cbBook.SelectedIndex];

            txtPrice.Text = price[cbBook.SelectedIndex].ToString();

            txtCount.Text = number[cbBook.SelectedIndex].ToString();


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtName.Clear();
            txtPrice.Clear();
            cbBook.Text = "";
            cbType.Text = "";
            txtPublisher.Text = "";
            txtCount.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (lastLoaded == 0)
            {
                firstAdd = 0;
            }

            else
            {
                firstAdd = lastLoaded + 1;
            }


            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                MessageBox.Show("Посочете автор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                author[i] = txtAuthor.Text;
            }

            if (string.IsNullOrEmpty(txtPublisher.Text))
            {
                MessageBox.Show("Посочете издател!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                publisher[i] = txtPublisher.Text;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Посочете заглавие!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                book[i] = txtName.Text;

            }

            bookType[i] = cbType.SelectedIndex;

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Посочете цена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                price[i] = double.Parse(txtPrice.Text);
            }

            if (string.IsNullOrEmpty(txtCount.Text))
            {
                MessageBox.Show("Посочете брой!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                number[i] = int.Parse(txtCount.Text);
            }


            MessageBox.Show("Книгата бе успешно добавена за запазване!", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);



            i++;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            i = firstAdd;

            StreamWriter sw = new StreamWriter(path, true);

            DialogResult dr = MessageBox.Show("Сигурни ли сте че искате да запазите книгата/книгите в текстовия файл?", "Въпрос?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {

                using (sw)
                {
                    string[] fields = new string[6];

                    while (book[i] != null)
                    {


                        fields[0] = book[i];

                        cbBook.Items.Add(fields[0]);

                        fields[1] = publisher[i];

                        fields[2] = author[i];

                        string genre = type[bookType[i]];

                        fields[3] = genre;

                        fields[4] = price[i].ToString();

                        fields[5] = number[i].ToString();


                        i++;

                        if (dr == DialogResult.Yes)
                        {
                            string line = $"{fields[0]}, {fields[1]}, {fields[2]}, " +
                                $"{fields[3]}, {fields[4]}, {fields[5]}";

                            sw.WriteLine(line);
                        }

                    }

                    MessageBox.Show("Запазването стана успешно!", "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                }



            }


        }

        private void cbTitle_TextChanged(object sender, EventArgs e)
        {
            lblPrice.Text = price[cbTitle.SelectedIndex].ToString();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            string order = $"Заглавие : {cbTitle.Text};  Брой : {txtNSale.Text}";

            lblChoose.Items.Add(order); 

            sum += price[cbTitle.SelectedIndex] * double.Parse(txtNSale.Text);

            lblSum.Text = $"{sum:f2}";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblChoose.Items.Clear(); 
            lblSum.Text = "";
            cbTitle.Text = "";
            lblPrice.Text = "";
            txtNSale.Clear();
        }
    }
}
