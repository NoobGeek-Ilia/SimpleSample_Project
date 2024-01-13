namespace SimpleSample
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            TopMost = true;
            this.f1 = f1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.keyBase.getKey[0].Add(textBox1.Text);
            MessageBox.Show("Key added!");
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
