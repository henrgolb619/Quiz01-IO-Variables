namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void q2SExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Jays!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To output two decimal places use F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 items at 2.25 each with tax will be $10.17");
        }

        private void q01Button_Click(object sender, EventArgs e)
        {
            q1OutputLabel.Text = "Go Bears!";
        }

        private void q02Button_Click(object sender, EventArgs e)
        {
            string favoriteTeam = q2TextBox.Text;
            q2OutputLabel.Text = "Go, " + favoriteTeam + "!";

        }

        private void q03Button_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(num1Box.Text);
            int num2 = Convert.ToInt32(num2Box.Text);
            q3OutputLabel.Text = num1 + " x " + num2 + " equals " + num1 * num2;

        }

        private void q04Button_Click(object sender, EventArgs e)
        {
            int numberOfItems = Convert.ToInt32(noItemsBox.Text);
            int cost = Convert.ToInt32(costBox.Text);
            int totalPrice = numberOfItems * cost;
            double tax = 1.13;
            double priceWithTax = totalPrice * tax;
            string priceWithTaxString = priceWithTax.ToString("F2");
            q4OutputLabel.Text = "With " + numberOfItems + " items at a price of " + cost + "$" + " , the price will amount to " + priceWithTaxString + "$";
        }
    }
}

