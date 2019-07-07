using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace PascalTDPTweaker
{
    public partial class MainForm : Form
    {
        private Models.Firmware.Bios bios;
        private readonly Models.Reader.Processor processor = new Models.Reader.Processor();
        private int globalCounter;
        private bool textChanging = false;
        private long checksumValue = 0;
        private string checksum8bit;
        private readonly string FORMAT = "ddd, MMM d, yyyy HH:mm:ss";

        // Indices for vBIOS information.
        private readonly int NUM_ADDR = typeof(Models.Firmware.IndexCollector).GetProperties().Length; // Total number of indices.

        public MainForm()
        {
            InitializeComponent();
        }

        // Load vBIOS file into byte array. 
        // Loop through byte by byte to locate predefined addresses and set values in form.
        private void OpenBIOS_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open BIOS";
            open.Filter = "BIOS Files (*.rom; *.bin)|*.rom;*.bin";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Load models config file.
                processor.ReadConfigFile("PascalTDPTweaker.Models.config", "Generic");

                InitForm();
                textBoxFileName.Text = open.SafeFileName;
                DateTime lastModified = File.GetLastWriteTime(open.FileName);
                textBoxModifiedDate.Text = lastModified.ToString(FORMAT);
                bios = new Models.Firmware.Bios(File.ReadAllBytes(open.FileName));
                open.Dispose();

                checksumValue = Models.Controllers.BiosController.CalculateChecksum(bios.ByteArray, textBoxChecksum32, numericUpDownTargetChecksum32);
                globalCounter = 0;

                // Sequentially read bytes; compare bytes read with addresses in 'Models.config'.
                // If address matched, set index and display value in form.
                for (int i = 0; i < bios.Length(); i++)
                {
                    // Break for-loop once all indices are set.
                    if (globalCounter == NUM_ADDR) break;

                    // Index to determine if black screen fix is needed.
                    bios.IndexCollection.BlackSreenIndex = SetValueIndex(processor.StartAdr.ID, bios.ByteArray, i, processor.StartAdr.Low, processor.StartAdr.High, null, 0, bios.IndexCollection.BlackSreenIndex, 1);

                    // vBIOS information section. //
                    bios.IndexCollection.DateIndex = SetTextIndex(processor.DateAdr.ID, bios.ByteArray, i, processor.DateAdr.Low, processor.DateAdr.High, textBoxDate, 1, bios.IndexCollection.DateIndex, 0);
                    bios.IndexCollection.VersionIndex = SetTextIndex(processor.VerAdr.ID, bios.ByteArray, i, processor.VerAdr.Low, processor.VerAdr.High, textBoxVersion, 1, bios.IndexCollection.VersionIndex, 0);
                    bios.IndexCollection.BoardIndex = SetTextIndex(processor.BoardAdr.ID, bios.ByteArray, i, processor.BoardAdr.Low, processor.BoardAdr.High, textBoxBoard, 1, bios.IndexCollection.BoardIndex, 0);
                    bios.IndexCollection.DeviceIndex = SetTextIndex(processor.DeviceAdr.ID, bios.ByteArray, i, processor.DeviceAdr.Low, processor.DeviceAdr.High, textBoxDeviceID, 3, bios.IndexCollection.DeviceIndex, 1);
                    // End information section.

                    // To be modded. //
                    // TDP section. //
                    bios.IndexCollection.TdpSliderIndex = SetRadioIndex(processor.TdpSliderAdr.ID, bios.ByteArray, i, processor.TdpSliderAdr.Low, processor.TdpSliderAdr.High, tdpAdjustable, tdpFixed, processor.TdpSliderSignal.Config, bios.IndexCollection.TdpSliderIndex);
                    bios.IndexCollection.BaseTdpIndex = SetValueIndex(processor.BaseTdpAdr.ID, bios.ByteArray, i, processor.BaseTdpAdr.Low, processor.BaseTdpAdr.High, numericUpDownTdpBase, 1, bios.IndexCollection.BaseTdpIndex, 0);
                    bios.IndexCollection.MaxTdpIndex = SetValueIndex(processor.MaxTdpAdr.ID, bios.ByteArray, i, processor.MaxTdpAdr.Low, processor.MaxTdpAdr.High, numericUpDownTdpMax, 1, bios.IndexCollection.MaxTdpIndex, 0);
                    // End TDP section.

                    // Advanced power section. //
                    bios.IndexCollection.P1BaseTdpIndex = SetValueIndex(processor.Power1BaseAdr.ID, bios.ByteArray, i, processor.Power1BaseAdr.Low, processor.Power1BaseAdr.High, numericUpDownP1Base, 1, bios.IndexCollection.P1BaseTdpIndex, 0);
                    bios.IndexCollection.P1MaxTdpIndex = SetValueIndex(processor.Power1MaxAdr.ID, bios.ByteArray, i, processor.Power1MaxAdr.Low, processor.Power1MaxAdr.High, numericUpDownP1Max, 1, bios.IndexCollection.P1MaxTdpIndex, 0);

                    bios.IndexCollection.P2BaseTdpIndex = SetValueIndex(processor.Power2BaseAdr.ID, bios.ByteArray, i, processor.Power2BaseAdr.Low, processor.Power2BaseAdr.High, numericUpDownP2Base, 1, bios.IndexCollection.P2BaseTdpIndex, 0);
                    bios.IndexCollection.P2MaxTdpIndex = SetValueIndex(processor.Power2MaxAdr.ID, bios.ByteArray, i, processor.Power2MaxAdr.Low, processor.Power2MaxAdr.High, numericUpDownP2Max, 1, bios.IndexCollection.P2MaxTdpIndex, 0);

                    bios.IndexCollection.P3BaseTdpIndex = SetValueIndex(processor.Power3BaseAdr.ID, bios.ByteArray, i, processor.Power3BaseAdr.Low, processor.Power3BaseAdr.High, numericUpDownP3Base, 1, bios.IndexCollection.P3BaseTdpIndex, 0);
                    bios.IndexCollection.P3MaxTdpIndex = SetValueIndex(processor.Power3MaxAdr.ID, bios.ByteArray, i, processor.Power3MaxAdr.Low, processor.Power3MaxAdr.High, numericUpDownP3Max, 1, bios.IndexCollection.P3MaxTdpIndex, 0);
                    // End advanced power section.

                    // Temperature section. //   
                    bios.IndexCollection.TempSliderIndex = SetRadioIndex(processor.TempSliderAdr.ID, bios.ByteArray, i, processor.TempSliderAdr.Low, processor.TempSliderAdr.High, tempAdjustable, tempFixed, processor.TempSliderSignal.Config, bios.IndexCollection.TempSliderIndex);
                    bios.IndexCollection.T1BaseTempIndex = SetValueIndex(processor.Temp1BaseAdr.ID, bios.ByteArray, i, processor.Temp1BaseAdr.Low, processor.Temp1BaseAdr.High, numericUpDownTemp1Base, 2, bios.IndexCollection.T1BaseTempIndex, 0);
                    bios.IndexCollection.T1MaxTempIndex = SetValueIndex(processor.Temp1MaxAdr.ID, bios.ByteArray, i, processor.Temp1MaxAdr.Low, processor.Temp1MaxAdr.High, numericUpDownTemp1Max, 2, bios.IndexCollection.T1MaxTempIndex, 0);
                    bios.IndexCollection.T1MinTempIndex = SetValueIndex(processor.Temp1MinAdr.ID, bios.ByteArray, i, processor.Temp1MinAdr.Low, processor.Temp1MinAdr.High, numericUpDownTemp1Min, 2, bios.IndexCollection.T1MinTempIndex, 0);

                    // Additional temperature settings.
                    bios.IndexCollection.T2BaseTempIndex = SetValueIndex(processor.Temp2BaseAdr.ID, bios.ByteArray, i, processor.Temp2BaseAdr.Low, processor.Temp2BaseAdr.High, numericUpDownTemp2Base, 2, bios.IndexCollection.T2BaseTempIndex, 0);
                    bios.IndexCollection.T2MaxTempIndex = SetValueIndex(processor.Temp2MaxAdr.ID, bios.ByteArray, i, processor.Temp2MaxAdr.Low, processor.Temp2MaxAdr.High, numericUpDownTemp2Max, 2, bios.IndexCollection.T2MaxTempIndex, 0);
                    bios.IndexCollection.T2MinTempIndex = SetValueIndex(processor.Temp2MinAdr.ID, bios.ByteArray, i, processor.Temp2MinAdr.Low, processor.Temp2MinAdr.High, numericUpDownTemp2Min, 2, bios.IndexCollection.T2MinTempIndex, 0);
                    // End Temperature section.

                    // Checksum index.
                    bios.IndexCollection.CheckSum32Index = SetValueIndex(processor.Checksum32Adr.ID, bios.ByteArray, i, processor.Checksum32Adr.Low, processor.Checksum32Adr.High, null, 0, bios.IndexCollection.CheckSum32Index, 0);
                    bios.IndexCollection.CheckSum8Index = SetTextIndex(processor.Checksum8Adr.ID, bios.ByteArray, i, processor.Checksum8Adr.Low, processor.Checksum8Adr.High, textBoxChecksum8, 2, bios.IndexCollection.CheckSum8Index, 2);

                    // Set unknown if date index cannot be found.
                    if (bios.IndexCollection.DateIndex == -1) textBoxDate.Text = "Unknown";
                }
            }
        }

        // Perform additional actions for some values.
        private void AdditionalStep(int index, int step)
        {
            switch (step)
            {
                case 1:
                    DisplayModel(index, this.textBoxModel, this.textBoxBiosName, this.textBoxDeviceID);
                    break;
                case 2:
                    this.checksum8bit = this.textBoxChecksum8.Text;
                    Is8bitCorrect();
                    break;
                default:
                    break;
            }
        }

        // Display model name.
        private void DisplayModel(int nameIndex, TextBox textBoxModel, TextBox textBoxBiosName, TextBox textBoxDeviceID)
        {
            if (nameIndex != -1)
            {
                string id = textBoxDeviceID.Text;
                string [] token = processor.ReadModel(id).Split(',');
                string model = token[0];
                if (token.Length > 1)
                    textBoxBiosName.Text = token[1];
                textBoxModel.Text = model;

                if (model == "Unsupported")
                {
                    textBoxModel.BackColor = Color.AntiqueWhite;
                    textBoxBiosName.BackColor = Color.AntiqueWhite;
                    textBoxBiosName.Text = model;
                }
            }
        }

        // Wrapper method calls SetText and return address index.
        private int SetTextIndex(byte[] address, byte[] vbios, int pos, int dataLen, int shift, TextBox tb, int type, int index, int step)
        {
            if (index == -1)
            {
                index = Models.Controllers.TextController.SetText(address, vbios, pos, dataLen, shift, tb, type);

                if (index != -1)
                {
                    globalCounter++;
                    AdditionalStep(index, step);
                    return index;
                }
            }
            return index;
        }

        // Wrapper method calls SetValue and return address index.
        private int SetValueIndex(byte[] address, byte[] vbios, int pos, int dataLen, int shift, NumericUpDown nud, int type, int index, int extra)
        {
            if (index == -1)
            {
                index = Models.Controllers.NumericController.SetValue(address, vbios, pos, dataLen, shift, nud, type);
                if (index != -1)
                {
                    globalCounter++;
                    if (extra == 1)
                    {
                        index -= 2;
                        ShowStarter();
                    }
                    return index;
                }
            }
            return index;
        }

        // Wrapper method calls SetRadio and return address index.
        private int SetRadioIndex(byte[] address, byte[] vbios, int pos, int dataLen, int shift, RadioButton rb1, RadioButton rb2, string signal, int index)
        {
            if (index == -1)
            {
                index = Models.Controllers.OptionController.SetRadio(address, vbios, pos, dataLen, shift, rb1, rb2, signal);
                if (index != -1)
                {
                    globalCounter++;
                    return index;
                }
            }
            return index;
        }

        // Save vBIOS file. 
        private void SaveBIOS_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save BIOS";
            save.Filter = "BIOS Files (*.rom; *.bin)|*.rom;*.bin";

            if (bios.IndexCollection.CheckSum32Index == 0)
                // No vBIOS file is opened.
                MessageBox.Show("Unhandled exception (empty)! BIOS cannot be saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (bios.IndexCollection.CheckSum32Index == -1)
                // Cannot locate "Power" String.
                MessageBox.Show("Unhandled exception (corrupted string section)! BIOS cannot be saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.BaseTdpIndex, (int)numericUpDownTdpBase.Value, 1);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.MaxTdpIndex, (int)numericUpDownTdpMax.Value, 1);

                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.P1BaseTdpIndex, (int)numericUpDownP1Base.Value, 1);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.P1MaxTdpIndex, (int)numericUpDownP1Max.Value, 1);

                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.P2BaseTdpIndex, (int)numericUpDownP2Base.Value, 1);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.P2MaxTdpIndex, (int)numericUpDownP2Max.Value, 1);

                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.P3BaseTdpIndex, (int)numericUpDownP3Base.Value, 1);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.P3MaxTdpIndex, (int)numericUpDownP3Max.Value, 1);

                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.T1BaseTempIndex, (int)numericUpDownTemp1Base.Value, 2);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.T1MaxTempIndex, (int)numericUpDownTemp1Max.Value, 2);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.T1MinTempIndex, (int)numericUpDownTemp1Min.Value, 2);

                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.T2BaseTempIndex, (int)numericUpDownTemp2Base.Value, 2);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.T2MaxTempIndex, (int)numericUpDownTemp2Max.Value, 2);
                Models.Controllers.BiosController.ModBIOSValue(bios, bios.IndexCollection.T2MinTempIndex, (int)numericUpDownTemp2Min.Value, 2);

                Models.Controllers.BiosController.ModBIOSSlide(bios, bios.IndexCollection.TdpSliderIndex, tdpAdjustable.Checked, tdpFixed.Checked, processor.TdpSliderSignal.Config);
                Models.Controllers.BiosController.ModBIOSSlide(bios, bios.IndexCollection.TempSliderIndex, tempAdjustable.Checked, tempFixed.Checked, processor.TempSliderSignal.Config);

                long newCS = Models.Controllers.BiosController.CalculateChecksum(bios.ByteArray, textBoxChecksum32, numericUpDownTargetChecksum32);
                long offset = newCS - checksumValue;

                //Console.WriteLine(offset);
                if (Models.Controllers.BiosController.CorrectCS(bios, checksumValue, offset, textBoxChecksum32, numericUpDownTargetChecksum32, 1) == 1)
                {
                    // Fix non G-SYNC vBIOS that has header.
                    if (headerRemove.Checked)
                        BlackScreenFix(); 
                    File.WriteAllBytes(save.FileName, bios.ByteArray);
                }
                else
                    MessageBox.Show("Unhandled exception (corrupted string section)! BIOS cannot be saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load modded preset values for major mobile models.
        private void Preset_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDownTdpBase.Value = processor.BaseTdpPreset.Value;
                numericUpDownTdpMax.Value = processor.MaxTdpPreset.Value;
                numericUpDownP1Base.Value = processor.Power1Preset.Value;
                numericUpDownP1Max.Value = processor.Power1Preset.Value;
                numericUpDownP2Base.Value = processor.Power2Preset.Value;
                numericUpDownP2Max.Value = processor.Power2Preset.Value;
                numericUpDownP3Base.Value = processor.Power3Preset.Value;
                numericUpDownP3Max.Value = processor.Power3Preset.Value;
                numericUpDownTemp1Base.Value = numericUpDownTemp1Max.Value = numericUpDownTemp1Min.Value = processor.TempPreset.Value;
                numericUpDownTemp2Base.Value = numericUpDownTemp2Max.Value = numericUpDownTemp2Min.Value = processor.TempPreset.Value;

                tdpAdjustable.Checked = true;
                tdpFixed.Checked = false;
            }
            catch (Exception)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Preset is not supported for this model.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Call CorrectCS to correct checksum. Standalone checksum correction.
        private void QuickFix_Click(object sender, EventArgs e)
        {
            if (bios.IndexCollection.CheckSum32Index == -1)
                MessageBox.Show("Unhandled exception (corrupted string section)! Checksum cannot be corrected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (bios.IndexCollection.CheckSum32Index != 0)
            {
                long fixCS = (long)numericUpDownTargetChecksum32.Value;
                long offset = checksumValue - fixCS;
                Console.WriteLine(offset);
                if (offset == 0)
                    MessageBox.Show("Checksum offset is 0. No checksum correction needed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (Models.Controllers.BiosController.CorrectCS(bios, checksumValue, offset, textBoxChecksum32, numericUpDownTargetChecksum32, 2) == 1)
                {
                    MessageBox.Show("Offset " + offset + ". Checksum has been corrected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checksumValue = fixCS;
                }
                else
                    MessageBox.Show("Unhandled exception (corrupted section/offset too large)! Checksum cannot be corrected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fix black screen issue for some older bios.
        private int BlackScreenFix()
        {
            if (bios.IndexCollection.BlackSreenIndex != 0)
            {
                byte[] new_bios = new byte[bios.Length() - bios.IndexCollection.BlackSreenIndex];
                int j = bios.IndexCollection.BlackSreenIndex;

                for (int i = 0; i < new_bios.Length; i++)
                {
                    new_bios[i] = bios.ByteArray[j];
                    j++;
                }
                bios.ByteArray = new_bios;
                return 1;
            }
            return -1;
        }

        // Experimental check on 8 bit checksum. Need testing to confirm if it works.
        private long Is8bitCorrect()
        {
            int headerSize = 0;
            for (int i = 0; i < bios.IndexCollection.BlackSreenIndex; i++)
            {
                headerSize += bios.ByteArray[i];
            }
            long validChecksum = checksumValue - headerSize;
            string r = validChecksum.ToString("X2");
            string lastDigits = r.Substring(r.Length - 2);

            if (lastDigits.Equals("00"))
            {
                textBoxChecksum8.Text = checksum8bit + "=>[" + checksum8bit + "]";
                textBoxChecksum8.BackColor = System.Drawing.Color.LemonChiffon;
                return 1;
            }
            else
            {
                int ld = Convert.ToInt32(lastDigits, 16);
                int bit = Convert.ToInt32(checksum8bit, 16);
                string diff = "";
                if (ld <= bit)
                    diff = (bit - ld).ToString("X2");
                else
                    diff = (256 - ld + bit).ToString("X2");
                textBoxChecksum8.Text = checksum8bit + "=>[" + diff + "]";
                textBoxChecksum8.BackColor = Color.White;
                return -1;
            }
        }

        // Reset values and indices when new vBIOS is open.
        private void InitForm()
        {
            bios = null;
            checksumValue = -1;
            textBoxModel.BackColor = Color.LightYellow;
            textBoxBiosName.BackColor = Color.LightYellow;
            textBoxModel.Text = "";
            textBoxBoard.Text = "";
            textBoxBiosName.Text = "";
            textBoxVersion.Text = "";
            textBoxDate.Text = "";
            numericUpDownTdpBase.Value = 0;
            numericUpDownTdpMax.Value = 0;
            numericUpDownTemp1Base.Value = 0;
            numericUpDownTemp1Max.Value = 0;
            numericUpDownTemp1Min.Value = 0;
            numericUpDownP1Base.Value = 0;
            numericUpDownP1Max.Value = 0;
            numericUpDownP2Base.Value = 0;
            numericUpDownP2Max.Value = 0;
            numericUpDownP3Base.Value = 0;
            numericUpDownP3Max.Value = 0;
            numericUpDownTemp2Base.Value = 0;
            numericUpDownTemp2Max.Value = 0;
            numericUpDownTemp2Min.Value = 0;
            tdpAdjustable.Checked = false;
            tdpFixed.Checked = false;
            tempAdjustable.Checked = false;
            tempFixed.Checked = false;
            headerPreserve.Checked = true;
            headerRemove.Checked = false;
        }

        // Hex value input box.
        private void HexValueTextChanged(object sender, EventArgs e)
        {
            if (textChanging == false)
            {
                textChanging = true;
                string hexValue = this.textBoxHexValue.Text;
                if (hexValue.Length > 0)
                {
                    long decValue = Convert.ToInt64(hexValue, 16);
                    textBoxDecValue.Text = "" + decValue;
                    while (hexValue.Length < 8)
                    {
                        hexValue = "0" + hexValue;
                    }
                    textBoxBigEndian.Text = Models.Helper.Spacing(hexValue);
                    textBoxLittleEndian.Text = Models.Helper.Spacing(Models.Helper.ReverseTDP(hexValue));
                }
                else
                {
                    textBoxDecValue.Text = "";
                    textBoxBigEndian.Text = "";
                    textBoxLittleEndian.Text = "";
                }
                textChanging = false;
            }
        }

        // Dec value input box.
        private void DecValueTextChanged(object sender, EventArgs e)
        {
            if (textChanging == false)
            {
                textChanging = true;
                string strValue = textBoxDecValue.Text;
                if (strValue.Length > 0)
                {
                    long decValue = Convert.ToInt64(strValue);
                    string hexValue = decValue.ToString("X2");
                    while (hexValue.Length < 8)
                    {
                        hexValue = "0" + hexValue;
                    }
                    this.textBoxHexValue.Text = hexValue;
                    textBoxBigEndian.Text = Models.Helper.Spacing(hexValue);
                    textBoxLittleEndian.Text = Models.Helper.Spacing(Models.Helper.ReverseTDP(hexValue));
                }
                else
                {
                    textBoxHexValue.Text = "";
                    textBoxBigEndian.Text = "";
                    textBoxLittleEndian.Text = "";
                }
                textChanging = false;
            }
        }

        // Detect key press for input of base converter.
        private void HexValueKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^a-f^+^A-F^+^\b^]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        // Detect key press for input of base converter.
        private void DecValueKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\b^]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        // Set texts for starter textbox. 
        private void ShowStarter()
        {
            textBoxStarter.Text = "" + bios.ByteArray[0].ToString("X2") + bios.ByteArray[1].ToString("X2");
        }
    }
}
