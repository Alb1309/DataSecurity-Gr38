using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    class TextExtractor
    {
        Operations ops = new Operations();
        private ProgressBar pBar1;

        public TextExtractor(ProgressBar pBar1)
        {
            this.pBar1 = pBar1;
            pBar1.Visible = false;
        }

        public string Retrieve1lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string message = "";
            int counter = 0;
            pBarSetup(msgLength * 8);

            while (counter < msgLength * 8)
            {
                pBar1.PerformStep();
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                //loop per R/G/B
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    string rLastFour = rBitString.Substring(7, 1);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gLastFour = gBitString.Substring(7, 1);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    string bLastFour = bBitString.Substring(7, 1);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }
            }

            pBar1.Visible = false;
            return ops.BinaryToString(message);
        }

        private void pBarSetup(long inLength_)
        {
            int length = Convert.ToInt32(inLength_);
            pBar1.Visible = true;
            pBar1.Minimum = 1;
            pBar1.Maximum = length;
            pBar1.Value = 1;
            pBar1.Step = 1;
        }

    }
}