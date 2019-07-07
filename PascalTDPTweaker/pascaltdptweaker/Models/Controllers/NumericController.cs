using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PascalTDPTweaker.Models.Controllers
{
    public static class NumericController
    {
        // Set numeric value on main application.
        public static int SetValue(byte[] dataPos, byte[] file, int i, int dataLen, int shift, NumericUpDown nud, int type)
        {
            int pos = i;
            int posLen = dataPos.Length;

            for (int j = (posLen - 1); j >= 0; j--)
            {
                if (dataPos[j].Equals(file[pos]))
                    pos--;
                else
                    return -1;

                // Indicating there is a match.
                if (pos == (i - (posLen - 1)))
                {
                    // Immediately return index to correct checksum.
                    if (type == 0)
                        return (pos + posLen);

                    string result = "";
                    int index = pos - dataLen;

                    for (int k = index; k < (pos + shift); k++)
                    {
                        result += file[k].ToString("X2");
                    }

                    // TDP = 1
                    if (type == 1)
                    {
                        int num = int.Parse(Models.Helper.ReverseTDP(result), System.Globalization.NumberStyles.HexNumber);
                        if (num <= nud.Maximum)
                            nud.Value = num;
                    }
                    // Temp = 2
                    else if (type == 2)
                    {
                        int num = int.Parse(Models.Helper.ReverseTemp(result), System.Globalization.NumberStyles.HexNumber) / 32;
                        if (num <= nud.Maximum)
                            nud.Value = num;
                    }

                    return index;
                }
            }
            return -1;
        }
    }
}
