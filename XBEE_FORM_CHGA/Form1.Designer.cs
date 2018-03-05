namespace XBEE_FORM_CHGA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SEND_Button = new System.Windows.Forms.Button();
            this.TEXT_STRING_INPUT = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.OPEN_PORT = new System.Windows.Forms.Button();
            this.lblSend = new System.Windows.Forms.Label();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SEND_Button
            // 
            this.SEND_Button.Location = new System.Drawing.Point(146, 601);
            this.SEND_Button.Name = "SEND_Button";
            this.SEND_Button.Size = new System.Drawing.Size(128, 23);
            this.SEND_Button.TabIndex = 0;
            this.SEND_Button.Text = "SEND";
            this.SEND_Button.UseVisualStyleBackColor = true;
            this.SEND_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEXT_STRING_INPUT
            // 
            this.TEXT_STRING_INPUT.Location = new System.Drawing.Point(86, 538);
            this.TEXT_STRING_INPUT.Name = "TEXT_STRING_INPUT";
            this.TEXT_STRING_INPUT.Size = new System.Drawing.Size(707, 20);
            this.TEXT_STRING_INPUT.TabIndex = 1;
            this.TEXT_STRING_INPUT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // OPEN_PORT
            // 
            this.OPEN_PORT.Location = new System.Drawing.Point(12, 601);
            this.OPEN_PORT.Name = "OPEN_PORT";
            this.OPEN_PORT.Size = new System.Drawing.Size(128, 23);
            this.OPEN_PORT.TabIndex = 2;
            this.OPEN_PORT.Text = "OPEN PORT";
            this.OPEN_PORT.UseVisualStyleBackColor = true;
            this.OPEN_PORT.Click += new System.EventHandler(this.OPEN_PORT_Click);
            // 
            // lblSend
            // 
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(846, 578);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(61, 13);
            this.lblSend.TabIndex = 3;
            this.lblSend.Text = "Send &Data:";
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(86, 575);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(707, 20);
            this.txtSendData.TabIndex = 4;
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfTerminal.Location = new System.Drawing.Point(25, 382);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(735, 130);
            this.rtfTerminal.TabIndex = 5;
            this.rtfTerminal.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(769, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 273);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(25, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 206);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(32, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 42);
            this.button3.TabIndex = 19;
            this.button3.Text = "SEND";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Lime;
            this.label32.Location = new System.Drawing.Point(167, 175);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(832, 22);
            this.label32.TabIndex = 34;
            this.label32.Text = "EMPTY";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(4, 180);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(157, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Fotmatted Last Sent Value";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkRed;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(95, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 42);
            this.button8.TabIndex = 36;
            this.button8.Text = "SEND";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.comboBox8);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(377, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 81);
            this.panel2.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-323, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 23;
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.comboBox8.Location = new System.Drawing.Point(446, 44);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(56, 21);
            this.comboBox8.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M"});
            this.comboBox1.Location = new System.Drawing.Point(12, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(74, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(56, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(93, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(465, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "8";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.comboBox3.Location = new System.Drawing.Point(136, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(56, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(155, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(403, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "7";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.comboBox4.Location = new System.Drawing.Point(198, 44);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(56, 21);
            this.comboBox4.TabIndex = 24;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.comboBox7.Location = new System.Drawing.Point(384, 44);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(56, 21);
            this.comboBox7.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(217, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(341, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "6";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.comboBox5.Location = new System.Drawing.Point(260, 44);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(56, 21);
            this.comboBox5.TabIndex = 26;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.comboBox6.Location = new System.Drawing.Point(322, 44);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(56, 21);
            this.comboBox6.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(279, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "5";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(918, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 81);
            this.panel5.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 21);
            this.label15.TabIndex = 38;
            this.label15.Text = "CHECKSUM";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(121, 59);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "empty";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(799, 578);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "HEX";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(799, 541);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "TEXT";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(844, 541);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Send &Data:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(351, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 44;
            this.button2.Text = "Convert TXT to HEX";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(121, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "empty";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(14, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 13);
            this.label28.TabIndex = 46;
            this.label28.Text = "Length in Bytes";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.label30);
            this.panel9.Controls.Add(this.label33);
            this.panel9.Controls.Add(this.label28);
            this.panel9.Controls.Add(this.label27);
            this.panel9.Controls.Add(this.label34);
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.label26);
            this.panel9.Controls.Add(this.label29);
            this.panel9.Location = new System.Drawing.Point(25, 240);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(487, 136);
            this.panel9.TabIndex = 47;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(14, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(108, 13);
            this.label30.TabIndex = 52;
            this.label30.Text = "Calculated Cksum";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(121, 82);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 51;
            this.label33.Text = "empty";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(14, 59);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 13);
            this.label34.TabIndex = 50;
            this.label34.Text = "Length in value";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(14, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "CONVERSION DATA";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(14, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 22);
            this.label16.TabIndex = 44;
            this.label16.Text = "EMPTY";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "CHECKSUM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "CHECKSUM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(275, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 81);
            this.panel3.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "EMPTY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "START";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(7, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 81);
            this.panel4.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "EMPTY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 630);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtfTerminal);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.OPEN_PORT);
            this.Controls.Add(this.TEXT_STRING_INPUT);
            this.Controls.Add(this.SEND_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SEND_Button;
        private System.Windows.Forms.TextBox TEXT_STRING_INPUT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button OPEN_PORT;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.RichTextBox rtfTerminal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
    }
}

