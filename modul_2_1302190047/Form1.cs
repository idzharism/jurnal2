namespace modul_2_1302190047
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void private void buttonTambah_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(textDisplay1.Text);
            textDisplay2.Text = "x";
            textDisplay1.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "3";
            }
            else
            {
                textDisplay1.Text += "3";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "1";
            }
            else
            {
                textDisplay1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "2";
            }
            else
            {
                textDisplay1.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                global::System.Boolean v = textDisplay1.Text == "4";
            }
            else
            {
                textDisplay1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "5";
            }
            else
            {
                textDisplay1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "6";
            }
            else
            {
                textDisplay1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "7";
            }
            else
            {
                textDisplay1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "8";
            }
            else
            {
                textDisplay1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text == "9";
            }
            else
            {
                textDisplay1.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text != "0")
            {
                textDisplay1.Text += "0";
            }
        }

        private void buttonSamadengan_Click(object sender, EventArgs e)
        {
            if (opr_selesai = true)
                bill2 = Convert.ToDecimal(textDisplay1.Text);
            {
                switch (opr)
                {
                    case 1;
                        textDisplay1.Text = Convert.ToString(bill1 + bill2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}