using System;
using System.Windows.Forms;

namespace TugasWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            labelOutput.Text = textBoxKalimat.Text;
            if (textBoxKalimat.Text != "")
            {
                labelOutput.Visible = true;
                //labelOutput.Text = labelOutput.Text.ToUpper();
            }
            //string huruf = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            //string huruf = "abcdefghijklmnopqrstuvwxyz";
            string huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] urut = huruf.ToCharArray();
            string output = "";
            textBoxKalimat.CharacterCasing = CharacterCasing.Upper;
            char[] kalimat = textBoxKalimat.Text.ToCharArray();
            char[] huruf1 = textBoxHuruf.Text.ToCharArray();
            char[] huruf2 = textBoxMenjadi.Text.ToCharArray();
            char index = Convert.ToChar(textBoxHuruf.Text);
            char index2 = Convert.ToChar(textBoxMenjadi.Text);
            int jarak = (index2 - index);
            if (jarak < 0)
            {
                jarak += 26;
            }
            for (int i = 0; i < textBoxKalimat.Text.Length; i++)
            {
                for(int j = 0; j < 26; j++)
                {
                    if (kalimat[i] == urut[j])
                    {
                        int jarak2 = jarak + j;
                        if (jarak2 >= 26)
                        {
                            jarak2 -= 26;
                        }
                        kalimat[i] = urut[jarak2];
                        output += kalimat[i];
                        kalimat[i] = 'a';
                    }
                    else if (kalimat[i] == ' ')
                    {
                        output += " ";
                        kalimat[i] = ' ';
                        kalimat[i] = 'a';
                    }
                }
            }
            labelOutput.Text = output;
        }

    

        //  labelOutput.Text = Convert.ToString(jarak);
    

    private void labelOutput_Click(object sender, EventArgs e)
    {

    }

    private void textBoxKalimat_TextChanged(object sender, EventArgs e)
    {

    }
}
}

