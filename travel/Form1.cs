namespace travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Zehmet olmasa butun xanalari doldurun!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Haradan = comboBox1.Text;
            string haraya = comboBox2.Text;
            string tarix = maskedTextBox1.Text;
            string adSoyad = textBox2.Text;
            string fin = textBox3.Text;
            string yer = textBox1.Text;
            string telefon = maskedTextBox2.Text;
            string email = textBox4.Text;

            listBox1.Items.Add(adSoyad + " | " + Haradan + " -> " + haraya + " | Tel: " + telefon + " | yer: " + yer + " | tarix: " + tarix + " | fin: " + fin + " | email: " + email);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}