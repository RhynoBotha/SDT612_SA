namespace SectionC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string make = txtMake.Text.Trim();
            string checkQuantity = txtQuantity.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(make))
            {
                MessageBox.Show("Error : Please enter values in the mobile code and quanity");
                return;
            }

            if (!int.TryParse(checkQuantity, out int quantity))
            {
                MessageBox.Show("Invalid Input : Make sure you enter a number in the quantity field");
                return;
            }

            tblMobilePhones.Items.Add($"Mobile Code : {code} || Make : {make} || Quantity : {quantity.ToString()}");

            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();

            if (tblMobilePhones.Items.Contains(code))
            {
                tblMobilePhones.Items.Remove(code);
                MessageBox.Show("Record Deleted!!");
                return;
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();

            if (tblMobilePhones.Items.Contains(code))
            {
                MessageBox.Show($"Record Found: {code}");
                return;
            } else
            {
                lblOutput.Text = "Record NOT FOUND";
            }
        }
    }
}
