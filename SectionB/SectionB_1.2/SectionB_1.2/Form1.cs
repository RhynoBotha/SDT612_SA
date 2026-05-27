namespace SectionB_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string name = txtInputName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Error : Please enter a name in the field");
                return;
            }

            MessageBox.Show($"Hello Mr.{name}");
        }
    }
}
