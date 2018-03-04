using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace XBEE_FORM_CHGA
{
    public partial class Form1 : Form
    {
        public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        // Temp holder for whether a key was pressed
        private bool maskOutput = false;

        internal List<Byte> portBuffer = new List<Byte>();

        const byte cmd_StartDelimiter = 0x7E;
        const byte cmd_Zero = 0x00;
        const byte cmd_4Length = 0x04;
        const byte cmd_8Length = 0x08;
        const byte cmd_ATAPIIdentifier = 0x08;
        const byte cmd_FrameId = 0x52;


        public Form1()
        {
             // Various colors for logging info
       

            InitializeComponent();

        
    }

        public void button1_Click(object sender, EventArgs e)
        {
            //7E 00 07 01 01 00 02 00 66 65 30
            //7e 00 14 01 01 50 01 00 08 00 04 42 6f 62 20 54 68 65 20 58 42 65 65 c8

          //  byte[] buffer = { 0x7e, 0x00, 0x07, 0x01, 0x01, 0x00, 0x02, 0x00, 0x66, 0x65, 0x30};
            // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
            byte[] data = HexStringToByteArray(label32.Text);

            // Send the binary data out the port
            serialPort1.Write(data, 0, data.Length);
            // serialPort1.Write(buffer, 0, buffer.Length);

            // serialPort1.Close();
            Log(LogMsgType.Outgoing, ByteArrayToHexString(data) + "\n");
        }
        private void Log(LogMsgType msgtype, string msg)
        {
            rtfTerminal.BeginInvoke(new EventHandler(delegate
            {
                rtfTerminal.SelectedText = string.Empty;
                rtfTerminal.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
                rtfTerminal.SelectionColor = LogMsgTypeColor[(int)msgtype];
                rtfTerminal.AppendText(msg);
                rtfTerminal.ScrollToCaret();
            }));
        }
        private void Log2(LogMsgType msgtype, string msg)
        {
            richTextBox1.BeginInvoke(new EventHandler(delegate
            {
                richTextBox1.SelectedText = string.Empty;
                richTextBox1.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
                richTextBox1.SelectionColor = LogMsgTypeColor[(int)msgtype];
                richTextBox1.AppendText(msg);
                richTextBox1.ScrollToCaret();
            }));
        }
        private void OPEN_PORT_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Obtain the number of bytes waiting in the port's buffer
            int bytes = serialPort1.BytesToRead;

            // Create a byte array buffer to hold the incoming data
            byte[] buffer = new byte[bytes];

            // Read the data from the port and store it in our buffer
            serialPort1.Read(buffer, 0, bytes);

            // Show the user the incoming data in hex format
            if (!maskOutput)
                Log2(LogMsgType.Incoming, ByteArrayToHexString(buffer) + "\n");

            // Adds the elements of the specified collection to the end of the List(Of T)
            portBuffer.AddRange(buffer);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }


        private string CalculateChecksum(string dataToCalculate)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(dataToCalculate);
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xff;
            return checksum.ToString("X2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte []start = { 0x007E, 0x0000, 0x001E, 0x0001, 0x0001, 0x0000, 0x0002, 0x0000 } ;
            
            byte[] Converted_input_payload = Encoding.Default.GetBytes(TEXT_STRING_INPUT.Text);
        

           /// lets combine Start of packet and payload * ShowWithoutActivation checksum 
           /// 
            var merged = new byte[start.Length + Converted_input_payload.Length];
                                  
            start.CopyTo(merged, 0);

            Converted_input_payload.CopyTo(merged, start.Length);

            /// done combine  Start of packet and payload * ShowWithoutActivation checksum 
            /// 
            //now lets calculate the lenght 

            int hh = 0;//merged.Length;

            /*
            Start delimiter
            The start delimiter is the first byte of a frame consisting of a special sequence of bits that indicate the beginning of a data frame. Its value is always 0x7E. This allows for easy detection of a new incoming frame.

            Length
            The length field specifies the total number of bytes included in the frame data field. Its two-byte value excludes the start delimiter, the length, and the checksum.

            Frame data
            This field contains the information received or to be transmitted. Frame data is structured based on the purpose of the API frame:
            */

            //Calculating Frame lenght 

            for (int i = 3; i < merged.Length; i++) //We start from add3 because for the package lenght calculation excludes the start delimiter, the length, and the checksum.
            {
                /*
                if (merged[i] == 00)
                {
                    hh--;
                }
                */
                hh++;
            }

           

            int intValue = hh;
            byte[] intBytes = BitConverter.GetBytes(intValue);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(intBytes);
            byte[] result = intBytes;

            merged[2] = result[3];
            // byte[]calculated_lenght_by_charles = Encoding.Default.GetBytes(hh);

            //lets calc checksum

            int decimalSum = 0;                         // Checksum calculus concept : http://knowledge.digi.com/articles/Knowledge_Base_Article/Calculating-the-Checksum-of-an-API-Packet
            for (int i = 3; i <  merged.Length; i++)
            {
                int theElementInInt = Convert.ToInt32(merged[i]);                              //We convert each element of the array to int (because it's impossible to make operation that have higher result than 0xFF ( 255 in decimal) in C#. 
              //  Console.WriteLine(xbeeFrame[i].ToString("X") + "=" + theElementInInt);            // So , the easiest way is to make calculus in decimal domain and switch to hexa when needed

                decimalSum += theElementInInt;                                                    //xbeeFrame is the array where are stored the bytes' frame
            }

            rtfTerminal.AppendText (Environment.NewLine + "The sum is :" + decimalSum);
            rtfTerminal.AppendText(Environment.NewLine + "sadfsafsf :" + decimalSum);
            string decimalSumHexByte = decimalSum.ToString("X");
            rtfTerminal.AppendText(Environment.NewLine + "The hex value of this sum is :" + decimalSumHexByte + " . I'll only take the two last bytes");  // cf calculus concept for why only the two last bytes
            char[] decimalSumHexByteExploded = decimalSumHexByte.ToCharArray();
            string last2Bytes = decimalSumHexByteExploded[decimalSumHexByteExploded.Length - 2] + "" + decimalSumHexByteExploded[decimalSumHexByteExploded.Length - 1];
            rtfTerminal.AppendText(Environment.NewLine + "The two last bytes are:" + last2Bytes);
            int last2BytesDeciValue = Convert.ToInt32(last2Bytes, 16);
            rtfTerminal.AppendText(Environment.NewLine + "Its decimal value is:" + last2BytesDeciValue);

            int finalIntValue = 255 - last2BytesDeciValue;
            string finalHexValue = finalIntValue.ToString("X");
            if (finalHexValue.Length == 1)
            {

                finalHexValue.Insert(0, "0");

            }

            rtfTerminal.AppendText(Environment.NewLine + "The checksum is :" + finalHexValue);
            finalHexValue.Insert(0, "0x");
            byte finalChecksumByte = Convert.ToByte(finalHexValue, 16);
            richTextBox1.Text = finalHexValue.ToString();

            byte[] GHD = { 0x00};
            GHD[0] = finalChecksumByte;
            var merged2 = new byte[merged.Length + 1];

            merged.CopyTo(merged2, 0);

            GHD.CopyTo(merged2, merged.Length);




            //////////////////////////////////////////////////////////////////
            var HEX_array1 = BitConverter.ToString(merged2);
            var calculated_lenght_by_charles = BitConverter.ToString(result);
            calculated_lenght_by_charles = calculated_lenght_by_charles.Replace("-", " ");

            HEX_array1 = HEX_array1.Replace("-", " ");

            label27.Text = calculated_lenght_by_charles;

            label32.Text = HEX_array1.ToString();///Converted combined Array still without Checksum 

            label26.Text = hh.ToString();


        }

        public byte CalcCheckSum(byte[] res)
        {
            int cs = (byte)0xFF - (res[3] + res[4] + res[5] + res[6]);

            byte[] css = BitConverter.GetBytes(cs);

            return css[0];

        }

        public byte[] ConvertTextToHex(string str)
        {
            byte[] Hex;

            System.Text.UTF8Encoding strC = new System.Text.UTF8Encoding();

            Hex = strC.GetBytes(str);

            return Hex;

        }
    }
}
