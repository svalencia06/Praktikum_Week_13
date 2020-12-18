using System;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string output = new string(arr);
            labelOutput.Text = output;
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi text box terlebih dahulu");
            }

        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            string input2 = textBoxInput.Text;
            char[] arr2 = input2.ToCharArray();
            Array.Sort(arr2);
            string output2 = new string(arr2);
            labelOutput.Text = output2;
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi text box terlebih dahulu");
            }
        }
    }
}



