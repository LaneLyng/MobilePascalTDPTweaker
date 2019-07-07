using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PascalTDPTweaker.Controllers
{
    public static class TextController
    {
        // Set text on main application.
        public static int SetText(byte[] dataPos, byte[] file, int i, int dataLen, int shift, TextBox tb, int type)
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
                    string result = "";
                    int index = pos - dataLen;

                    for (int k = index; k < (pos + shift); k++)
                    {
                        result += file[k].ToString("X2");
                    }

                    if (type == 1)
                        tb.Text = Models.Helper.HexToString(result);
                    else if (type == 2)
                        tb.Text = result;
                    else if (type == 3)
                        tb.Text = Models.Helper.HexToDeviceID(result);
                    return index;
                }
            }
            return -1;
        }
    }
}
