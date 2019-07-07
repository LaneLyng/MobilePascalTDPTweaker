using System.Drawing;
using System.Windows.Forms;

namespace PascalTDPTweaker.Models.Controllers
{
    public static class BiosController
    {
        // Maximum length to use for correcting checksum.
        private static readonly int SAFE_LENGTH = 70; 

        // Modify vBIOS values in place.
        public static void ModBIOSValue(Firmware.Bios bios, int index, int decValue, int type)
        {
            if (index != -1)
            {
                string hexValue = "";
                // TDP = 1.
                if (type == 1)
                {
                    //Console.WriteLine(decValue);
                    hexValue = decValue.ToString("X2");
                    if (hexValue.Length < 8)
                    {
                        hexValue = "00000000" + hexValue;
                        hexValue = hexValue.Substring(hexValue.Length - 8);
                        //Console.WriteLine(hexValue);
                    }
                    byte[] data = Models.Helper.HexToDecString(Models.Helper.ReverseTDP(hexValue));
                    int j = index;
                    for (int i = 0; i < data.Length; i++)
                    {
                        bios.ByteArray[j] = data[i];
                        j++;
                    }
                }
                // Temperature = 2.
                else if (type == 2)
                {
                    //Console.WriteLine(decValue);
                    hexValue = (decValue * 32).ToString("X2");
                    if (hexValue.Length < 4)
                    {
                        hexValue = "0000" + hexValue;
                        hexValue = hexValue.Substring(hexValue.Length - 4);
                        //Console.WriteLine(hexValue);
                    }
                    byte[] data = Models.Helper.HexToDecString(Models.Helper.ReverseTemp(hexValue));
                    int j = index;
                    for (int i = 0; i < data.Length; i++)
                    {
                        bios.ByteArray[j] = data[i];
                        j++;
                    }
                }
            }
        }

        // Modify vBIOS slider in place.
        public static void ModBIOSSlide(Firmware.Bios bios, int index, bool adj, bool fix, string signal)
        {
            if (adj == true && fix == false)
            {
                byte[] data = Models.Helper.HexToDecString(signal.Substring(0, 8));
                int j = index;
                for (int i = 0; i < data.Length; i++)
                {
                    bios.ByteArray[j] = data[i];
                    j++;
                }
            }
            else if (fix == true && adj == false)
            {
                byte[] data = Models.Helper.HexToDecString(signal.Substring(8, 8));
                int j = index;
                for (int i = 0; i < data.Length; i++)
                {
                    bios.ByteArray[j] = data[i];
                    j++;
                }
            }
        }

        // Correct checksum based on offset.
        public static int CorrectCS(Firmware.Bios bios, long checksumValue, long offset, TextBox tb, NumericUpDown nud, int mode)
        {
            long fixCS = (long)nud.Value;
            int range = bios.IndexCollection.CheckSum32Index + SAFE_LENGTH;
            long rest = offset;

            // For backup.
            byte[] bkp_bios = new byte[bios.Length()];

            for (int i = 0; i < bios.Length(); i++)
            {
                bkp_bios[i] = bios.ByteArray[i];
            }

            for (int i = bios.IndexCollection.CheckSum32Index; i < range; i++)
            {
                int cur = bios.ByteArray[i];
                if (rest >= cur)
                {
                    rest -= cur;
                    bios.ByteArray[i] = (byte)00;
                }
                else if (rest > 0 && rest < cur)
                {
                    bios.ByteArray[i] = (byte)(cur - rest);
                    rest = 0;
                }
                else if (rest < 0)
                {
                    int spare = 255 - cur;
                    if (-rest >= spare)
                    {
                        rest = rest + spare;
                        bios.ByteArray[i] = (byte)255;
                    }
                    else if (-rest < spare)
                    {
                        bios.ByteArray[i] = (byte)(-rest + cur);
                        rest = 0;
                    }
                }
                if (rest == 0)
                    break;
            }

            long CS = CalculateChecksum(bios.ByteArray, tb, nud);
            // For regular modding: mode = 1
            if (mode == 1 && CS == checksumValue)
            {
                return 1;
            }
            // Checksum fix: mode = 2
            else if (mode == 2 && CS == fixCS)
            {
                return 1;
            }
            else
            {
                SetChecksum(checksumValue, tb, nud);
                bios.ByteArray = bkp_bios;
                return -1;
            }
        }

        // Calculate vBIOS checksum value.
        public static long CalculateChecksum(byte[] byteToCalculate, TextBox tb, NumericUpDown nud)
        {
            long checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xffffffff;
            SetChecksum(checksum, tb, nud);
            return checksum;
        }

        // Set checksum value on application.
        public static void SetChecksum(long checksum, TextBox tb, NumericUpDown nud)
        {
            string r = checksum.ToString("X2");
            tb.Text = "0" + r + " (" + checksum + ")";
            nud.Value = checksum;
            // Only check if 8 bit correct.
            if ((r.Substring(r.Length - 2)).Equals("00"))
                tb.BackColor = Color.LemonChiffon;
            else
                tb.BackColor = Color.White;
        }
    }
}
