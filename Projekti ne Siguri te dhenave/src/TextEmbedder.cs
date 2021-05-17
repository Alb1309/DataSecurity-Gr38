
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing; //Libraria per krijimin e katroreve, trekendeshave e objekteve te tjera ku kemi te dhena ne program
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    class TextEmbedder 
    {
        Operations ops = new Operations();
        Bitmap bmp;
        private ProgressBar pBar1;
        public TextEmbedder(ProgressBar pBar1)
        {
            this.pBar1 = pBar1;
            pBar1.Visible = false;
        }

        public Bitmap Embed1lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            SetLength(inText_.Length);

            inText_.Insert(0, "0");

            for (int i = 0; i < inText_.Length; i++)
            {
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                bitString = bitString + newBit;
            }

            int noOfPixels = (inText_.Length * 8) / 3;

            pBarSetup(noOfPixels);

            for (int i = 0; i < noOfPixels; i++)
            {

                pBar1.PerformStep();
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                int finalR = 0, finalG = 0, finalB = 0;
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    string rFirstFour = rBitString.Substring(0, 7);
                                    string lFirstFour = bitString.Substring(0, 1);
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gFirstFour = gBitString.Substring(0, 7);
                                    string lLastFour = bitString.Substring(0, 1);
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    string bFirstFour = bBitString.Substring(0, 7);
                                    string lLastFour = bitString.Substring(0, 1);
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }
            pBar1.Visible = false;
            return bmp;
        }

        private void pBarSetup(int max_)
        {
            pBar1.Visible = true;
            pBar1.Minimum = 1;
            pBar1.Maximum = max_ / 8;
            pBar1.Value = 1;
            pBar1.Step = 1;
        }

    }
}

