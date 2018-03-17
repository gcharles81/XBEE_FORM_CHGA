using System;
using System.Collections.Generic;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

using Ini;
using System.IO;
using System.IO.Ports;       // used to access the SerialPort Class
namespace XBEE_FORM_CHGA
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();

        public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        // Temp holder for whether a key was pressed
        private bool maskOutput = false;

        internal List<Byte> portBuffer = new List<Byte>();



        byte[] start = { 0x0000, 0x0000, 0x001E, 0x0001, 0x0001, 0x0000, 0x0000, 0x0000 };

        const byte cmd_StartDelimiter = 0x7E;
        const byte Address_Node1 = 0x02;

        String newMessage;
       // SerialPort ComPort = new SerialPort();
        public Form1()
        {
             // Various colors for logging info
       

            InitializeComponent();
            FOLDERS(); /// Create folders if not found
            Xbee_Serial_send_Button.Visible = false;

        }
        public void FOLDERS()
        {

            String path18 = "test_folder";

            if (Directory.Exists(path18))
            {

            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path18);
            }


            String path19 = "config";

            if (Directory.Exists(path19))
            {

            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path19);
            }

            
            path18 = "config/COM_Settings.ini";

            if (File.Exists(path18))
            {


            }

            else//create it 
            {

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
                IniFile ini = new IniFile("config/COM_Settings.ini");

                ini.IniWriteValue("Info Serial", "File info ", "//File format created by Charles Galea 2018.");
                ini.IniWriteValue("Info Serial", "File Created ", DateTime.Now.ToString());

                ini.IniWriteValue("COMM SETTINGS", "PORT_NUMBER", "COM1");
                ini.IniWriteValue("COMM SETTINGS", "BAUD_RATE", "9600");
                ini.IniWriteValue("COMM SETTINGS", "PARITY", "None");
                ini.IniWriteValue("COMM SETTINGS", "DATA_BITS", "8");
               

                MessageBox.Show("Please make sure you setup COM Port for the first time");
            }
        }

        public void Send_XBEE_packet()
        {
            byte[] data = HexStringToByteArray(FULL_XBEE_PACKET_label.Text);

            //serialPort1.Write(data, 0, data.Length);
            ComPort.Write(data, 0, data.Length);

            Log(LogMsgType.Outgoing, ByteArrayToHexString(data) + "\n");
        }
        public void button1_Click(object sender, EventArgs e)
        {

            byte[] data = HexStringToByteArray(FULL_XBEE_PACKET_label.Text);

            //serialPort1.Write(data, 0, data.Length);
            
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
            //serialPort1.Open();
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
            if (Test_string_Combo.SelectedItem == null)
            {
                Test_string_Combo.SelectedIndex = 0;
            }

            String TEST_FILE_CHOOSE;
            TEST_FILE_CHOOSE = Test_string_Combo.SelectedItem.ToString();
            load_TXTfile(TEST_FILE_CHOOSE);
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

        private void Load_COM_PORT_config()
        {


            IniParser parser = new IniParser("config/COM_Settings.ini");
            String newMessage;
            String newMessageB;
            String newMessageD;

            newMessage = parser.GetSetting("COMM SETTINGS", "PORT_NUMBER");
           // toolStripStatusLabel1.Text = ("COM PORT");
          //  toolStripStatusLabel2.Text = Convert.ToString(newMessage);
         //   //serialPort1.PortName = Convert.ToString(newMessage);

            newMessageB = parser.GetSetting("COMM SETTINGS", "BAUD_RATE");
       //     //serialPort1.BaudRate = Convert.ToInt32(newMessageB);

            ////CHGA 26/09/2016 parity load is not supported yet to be implimented in the future 

            newMessageD = parser.GetSetting("COMM SETTINGS", "DATA_BITS");
      //      //serialPort1.DataBits = Convert.ToInt16(newMessageD);

            newMessage += parser.GetSetting("punctuation", "ex");

            
        }

        private void load_TXTfile(String Name)
        {
            
        IniParser parser = new IniParser("Test_UDP_XBEE_FILE.ini");
        
            newMessage = parser.GetSetting(Name, "UDP_PACKET");//// Load Sunrise hourOn1 Stored values in timers.ini file 
            //Parameters_test1 = Convert.ToInt32(newMessage);
            label7.Text = (newMessage);

        }

      

    public void Generate_XBEE_PACKET_AFTER_LOAD()
    {
        start[0] = cmd_StartDelimiter;
        start[6] = Address_Node1;

        byte[] Converted_input_payload = Encoding.Default.GetBytes(label7.Text);

        //////////////////////////////////////////////////////////////////
        var TEST_HEX_array1 = BitConverter.ToString(Converted_input_payload);


        TEST_HEX_array1 = TEST_HEX_array1.Replace("-", " ");
        label8.Text = TEST_HEX_array1.ToString();
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

                hh++;
            }



            int intValue = hh;
            byte[] intBytes = BitConverter.GetBytes(intValue);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(intBytes);
            byte[] result = intBytes;

            merged[2] = result[3];

            Lenght_MSB_byte_label.Text = result[3].ToString();
            //lets calc checksum

            int decimalSum = 0;                         // Checksum calculus concept : http://knowledge.digi.com/articles/Knowledge_Base_Article/Calculating-the-Checksum-of-an-API-Packet
            for (int i = 3; i < merged.Length; i++)
            {
                int theElementInInt = Convert.ToInt32(merged[i]);                              //We convert each element of the array to int (because it's impossible to make operation that have higher result than 0xFF ( 255 in decimal) in C#. 


                decimalSum += theElementInInt;                                                    //xbeeFrame is the array where are stored the bytes' frame
            }


            string decimalSumHexByte = decimalSum.ToString("X");

            char[] decimalSumHexByteExploded = decimalSumHexByte.ToCharArray();
            string last2Bytes = decimalSumHexByteExploded[decimalSumHexByteExploded.Length - 2] + "" + decimalSumHexByteExploded[decimalSumHexByteExploded.Length - 1];

            int last2BytesDeciValue = Convert.ToInt32(last2Bytes, 16);


            int finalIntValue = 255 - last2BytesDeciValue;
            string finalHexValue = finalIntValue.ToString("X");
            if (finalHexValue.Length == 1)
            {

                finalHexValue.Insert(0, "0");

            }


            finalHexValue.Insert(0, "0x");
            byte finalChecksumByte = Convert.ToByte(finalHexValue, 16);


            byte[] GHD = { 0x00 };
            GHD[0] = finalChecksumByte;
            var merged2 = new byte[merged.Length + 1];

            merged.CopyTo(merged2, 0);

            GHD.CopyTo(merged2, merged.Length);




            //////////////////////////////////////////////////////////////////
            var HEX_array1 = BitConverter.ToString(merged2);
            var calculated_lenght_by_charles = BitConverter.ToString(result);
            calculated_lenght_by_charles = calculated_lenght_by_charles.Replace("-", " ");

            HEX_array1 = HEX_array1.Replace("-", " ");

            // update frame data visualizer
            label33.Text = finalHexValue.ToString();
            label16.Text = finalHexValue.ToString();///checksum value 
            Start_byte_label.Text = merged2[0].ToString("X2");

            Lenght_LSB_byte_label.Text = merged2[1].ToString("X2");
            Lenght_MSB_byte_label.Text = merged2[2].ToString("X2");

            Frame_type_byte_label.Text = merged2[3].ToString("X2");
            Frame_ID_byte_label.Text = merged2[4].ToString("X2");

            Receiver_ADD_LSB_byte_label.Text = merged2[5].ToString("X2");
            Receiver_ADD_MSB_byte_label.Text = merged2[6].ToString("X2");
            Options_byte_label.Text = merged2[7].ToString("X2");
            //

            ///update conversion data window

            FULL_XBEE_PACKET_label.Text = HEX_array1.ToString();///Converted combined Array still without Checksum 
            label27.Text = calculated_lenght_by_charles;
            label26.Text = hh.ToString();
            ///
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (Test_string_Combo.SelectedItem == null)
            {
                Test_string_Combo.SelectedIndex = 0;
            }

            String TEST_FILE_CHOOSE;
            TEST_FILE_CHOOSE = Test_string_Combo.SelectedItem.ToString();
            load_TXTfile(TEST_FILE_CHOOSE);

            Generate_XBEE_PACKET_AFTER_LOAD();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Send_XBEE_packet();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Load_COM_PORT_config();
        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);


            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }


            IniParser parser = new IniParser("config/COM_Settings.ini");
            String newMessage;
            String newMessageB;
            String newMessageD;

            newMessage = parser.GetSetting("COMM SETTINGS", "PORT_NUMBER");
            // toolStripStatusLabel1.Text = ("COM PORT");
            //  toolStripStatusLabel2.Text = Convert.ToString(newMessage);
            //   //serialPort1.PortName = Convert.ToString(newMessage);

            newMessageB = parser.GetSetting("COMM SETTINGS", "BAUD_RATE");
            //     //serialPort1.BaudRate = Convert.ToInt32(newMessageB);

            ////CHGA 26/09/2016 parity load is not supported yet to be implimented in the future 

            newMessageD = parser.GetSetting("COMM SETTINGS", "DATA_BITS");
            //      //serialPort1.DataBits = Convert.ToInt16(newMessageD);

            newMessage += parser.GetSetting("punctuation", "ex");


            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];
            //Baud Rate
            cboBaudRate.Items.Add(newMessageB);

            cboBaudRate.Items.ToString();
            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[0].ToString();
            //Data Bits
            cboDataBits.Items.Add(newMessageD);
        
            //get the first item print it in the text 
            cboDataBits.Text = cboDataBits.Items[0].ToString();

           
        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                ComPort.Open();
                Xbee_Serial_send_Button.Visible = true;
            }
            else if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Closed";
                ComPort.Close();
                Xbee_Serial_send_Button.Visible = false;

            }
        }
    }
}
