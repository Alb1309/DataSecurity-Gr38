using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ProductionProject
{

    public partial class TextEmbedForm : Form
    {
        TextEmbedder embedder;
        TextExtractor retriever;
        Cryptog cry = new Cryptog();
        Caesar cae;
        int maxInputLength;
        double time = 0;
        Stopwatch sw;

        public TextEmbedForm()
        {
            InitializeComponent();
            embedder = new TextEmbedder(pBar1);
            retriever = new TextExtractor(pBar1);
            cae = new Caesar();
            encryptBtn.Enabled = false;
            decryptBtn.Enabled = false;
        }
        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void embedButton_Click(object sender, EventArgs e)
        {
            sw = Stopwatch.StartNew();
            //Error handling
            if (routeBox.Text == "")
            {
                MessageBox.Show("ERROR: no input image selected, see 'Image route' section.");
            }
            else if (textToEmbed.Text == "")
            {
                MessageBox.Show("ERROR: no input text available, see 'Text to embed' box.");
            }
            else if (!Lsb1Button.Checked)
            {
                MessageBox.Show("ERROR: no byte-density selected, please select one of the available options (i.e: '1LSB').");
            }

            //sw and LSB.
            else if (Lsb1Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed1lsb(routeBox.Text, textToEmbed.Text);
            }

            long timed = sw.ElapsedMilliseconds;
            MessageBox.Show("Koha e kaluar në milisekonda: " + timed);
            this.sw.Stop();
            saveStegoBtn.Enabled = true;
        }


        private void saveStegoBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxStego.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                stegobox.Text = saveFile.FileName.ToString();
                pictureBoxStego.ImageLocation = stegobox.Text;
                bmp.Save(stegobox.Text);

            }
        }

        private void openButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    routeBox.Text = open.FileName.ToString();
                    pictureBoxInput.ImageLocation = open.FileName;
                    //merr gjatesine maksimale te mundshme
                    Bitmap bmp = new Bitmap(routeBox.Text);
                    int length = (bmp.Width * bmp.Height); //-1 per pixellin e fundit qe ruan gjatesine
                    textToEmbed.MaxLength = length;
                    updateImgInfo(length);
                    updateLength(bmp);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Imazhi nuk u ngarkua");
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxInput.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                routeBox.Text = saveFile.FileName.ToString();
                pictureBoxInput.ImageLocation = routeBox.Text;
                bmp.Save(routeBox.Text);

            }
        }
        private void openStegoBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    stegobox.Text = open.FileName.ToString();
                    pictureBoxStego.ImageLocation = open.FileName;
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Imazhi nuk u ngarkua");
            }
        }
        private void saveStegoBtn_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxStego.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                stegobox.Text = saveFile.FileName.ToString();
                pictureBoxStego.ImageLocation = stegobox.Text;
                bmp.Save(stegobox.Text);
                bmp.Dispose();
            }
        }

        private void decodeButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stegobox.Text))
            {
                if (Lsb1Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve1lsb(stegobox.Text);
                }

                stegoLengthLabel.Text = "Length: " + decodedText.TextLength;
            }
            else
            {
                MessageBox.Show("No path specified, please assign a path using the textbox or 'open...' button");
            }
        }


        //make window draggable (after removing border)
        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textToEmbed.Text = cry.Crypt(textToEmbed.Text, textBox1.Text);
            }
            if (Caesar_btn.Checked)
            {
                textToEmbed.Text = cae.encrypt(textToEmbed.Text);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                decodedText.Text = cry.Decrypt(decodedText.Text, textBox1.Text);
            }
            if (Caesar_btn.Checked)
            {
                decodedText.Text = cae.decrypt(decodedText.Text);
            }
        }

        private void Lsb1Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //allow encryption button.
            if (textBox1.TextLength >= 8 && textToEmbed.TextLength > 0)
            {
                encryptBtn.Enabled = true;
            }
            else
            {
                encryptBtn.Enabled = false;
            }

            //allow decryption button.
            if (textBox1.TextLength >= 8 && decodedText.TextLength > 0)
            {
                decryptBtn.Enabled = true;
            }
            else
            {
                decryptBtn.Enabled = false;
            }
        }

        private void Caesar_btn_CheckedChanged(object sender, EventArgs e)
        {
            encryptBtn.Enabled = true;
            decryptBtn.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 8)
            {
                encryptBtn.Enabled = true;
                decryptBtn.Enabled = true;
            }
            else
            {
                encryptBtn.Enabled = false;
                decryptBtn.Enabled = false;
            }
        }

        private void openTextBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            textToEmbed.Text = File.ReadAllText(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void pBar1_Click(object sender, EventArgs e)
        {

        }
    }
}