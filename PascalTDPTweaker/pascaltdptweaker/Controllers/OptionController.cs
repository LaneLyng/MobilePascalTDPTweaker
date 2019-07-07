using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PascalTDPTweaker.Controllers
{
    public static class OptionController
    {

        // Set radio button on main application.
        public static int SetRadio(byte[] dataPos, byte[] file, int i, int dataLen, int shift, RadioButton adj, RadioButton fix, string signal)
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

                    if (result.Equals(signal.Substring(0, 8)))
                        adj.Checked = true;
                    else if (result.Equals(signal.Substring(8, 8)))
                        fix.Checked = true;

                    return index;
                }
            }
            return -1;
        }
    }
}
