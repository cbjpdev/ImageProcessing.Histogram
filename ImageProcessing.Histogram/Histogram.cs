using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing.Histogram
{
    public class Histogram
    {
        int oldC = 0, oldD = 0, newA = 0, newB = 0;
        int oldCr, oldDr;
        int oldCg, oldDg;
        int oldCb, oldDb;

        long[] myHistogramR = new long[256];
        long[] myHistogramG = new long[256];
        long[] myHistogramB = new long[256];

        int maxVal;
        String filepath;

        public long[] GetHistogram(System.Drawing.Bitmap picture)
        {
            long[] myHistogram = new long[256];

            Array.Clear(myHistogram, 0, myHistogram.Length);
            Array.Clear(myHistogramR, 0, myHistogramR.Length);
            Array.Clear(myHistogramG, 0, myHistogramG.Length);
            Array.Clear(myHistogramB, 0, myHistogramB.Length);

            for (int i = 0; i < picture.Size.Width; i++)
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    System.Drawing.Color c = picture.GetPixel(i, j);

                    long Temp = 0;
                    long TempR = c.R;
                    long TempG = c.G;
                    long TempB = c.B;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;

                    myHistogram[Temp]++;
                    myHistogramR[TempR]++;
                    myHistogramG[TempB]++;
                    myHistogramB[TempG]++;
                }

            bool sta = true;
            for (int a = 0; a < myHistogram.Length; a++)
            {
                if (myHistogram[a] > 0 && sta)
                {
                    oldC = a;
                    sta = false;
                }
                else if (myHistogram[a] > 0 && !sta)
                {
                    oldD = a;
                }
            }

            bool staR = true;
            for (int r = 0; r < myHistogramR.Length; r++)
            {
                if (myHistogramR[r] > 0 && staR)
                {
                    oldCr = r;
                    staR = false;
                }
                else if (myHistogramR[r] > 0 && !staR)
                {
                    oldDr = r;
                }
            }

            bool staG = true;
            for (int g = 0; g < myHistogramG.Length; g++)
            {
                if (myHistogramG[g] > 0 && staG)
                {
                    oldCg = g;
                    staG = false;
                }
                else if (myHistogramG[g] > 0 && !staG)
                {
                    oldDg = g;
                }
            }

            bool staB = true;
            for (int b = 0; b < myHistogramB.Length; b++)
            {
                if (myHistogramB[b] > 0 && staB)
                {
                    oldCb = b;
                    staB = false;
                }
                else if (myHistogramB[b] > 0 && !staB)
                {
                    oldDb = b;
                }
            }
            return myHistogram;
        }


        private void drawHistro(long[] myValues, int boxNo)
        {
            Pen skyBluePen = new Pen(Brushes.Black);
            long[] newValues = new long[256];

            for (int jj = 0; jj < myValues.Length; jj++)
            {
                int deff = 0;
                double temp = 0;
                temp = (double)myValues[jj];
                temp = temp / maxVal;
                temp = temp * 200;
                int.TryParse(Math.Round(temp).ToString(), out deff);
                newValues[jj] = deff;
                //newValues[jj] = (int)temp;
            }

            /* for (int j = 0; j < myValues.Length; j++)
             {               
                // txt.Text += newValues[j].ToString();
                // txt.Text += " ";
             }*/

            if (boxNo == 1)
            {
                Graphics g = picBox11.CreateGraphics();
                for (int i = 0; i < myValues.Length; i++)
                {
                    g.DrawLine(skyBluePen, i, 199, i, (200 - (int)newValues[i]));
                }
            }

            else if (boxNo == 2)
            {
                Graphics gg = picBox22.CreateGraphics();
                for (int i = 0; i < myValues.Length; i++)
                {
                    gg.DrawLine(skyBluePen, i, 199, i, (200 - (int)newValues[i]));
                }
            }
            skyBluePen.Dispose();
        }

        private void setContrast()
        {
            try
            {
                int newBr = 0, newBg = 0, newBb = 0;
                int newAr = 0, newAg = 0, newAb = 0;
                int range = oldD - oldC;
                double pVal;
                int num;
                int.TryParse(tbval.Text.ToString(), out num);
                //int.TryParse (newAval.Text.ToString (), out num);
                num -= 50;
                pVal = num / 100.00;
                double val = range * pVal;
                int prec;
                int.TryParse(Math.Round(val).ToString(), out prec);
                newBr = oldDr + prec;
                newAr = oldCr - prec;
                newBg = oldDg + prec;
                newAg = oldCg - prec;
                newBb = oldDb + prec;
                newAb = oldCb - prec;
                Bitmap b = new Bitmap(filepath, true);
                int newRed = 0, newGreen = 0, newBlue = 0;

                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        try
                        {
                            newRed = ((b.GetPixel(i, j).R - oldCr) * (newBr - newAr) / (oldDr - oldCr)) + newAr;
                            newGreen = ((b.GetPixel(i, j).G - oldCg) * (newBg - newAg) / (oldDg - oldCg)) + newAg;
                            newBlue = ((b.GetPixel(i, j).B - oldCb) * (newBb - newAb) / (oldDb - oldCb)) + newAb;
                        }
                        catch (Exception e)
                        {
                        }
                        if (newRed > 255)
                            newRed = 255;
                        if (newGreen > 255)
                            newGreen = 255;
                        if (newBlue > 255)
                            newBlue = 255;
                        if (newRed < 0)
                            newRed = 0;
                        if (newGreen < 0)
                            newGreen = 0;
                        if (newBlue < 0)
                            newBlue = 0;
                        b.SetPixel(i, j, Color.FromArgb(newRed, newGreen, newBlue));
                    }
                }
                picBox2.Image = b;
            }
            catch (Exception es)
            {
                MessageBox.Show("Image missing. " + es.Message);
            }
        }
    }
}
