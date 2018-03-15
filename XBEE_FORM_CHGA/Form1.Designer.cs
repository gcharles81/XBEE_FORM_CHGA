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
            this.TEXT_STRING_INPUT = new System.Windows.Forms.TextBox();
            this.OPEN_PORT = new System.Windows.Forms.Button();
            this.lblSend = new System.Windows.Forms.Label();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Frame_data_visualizer = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Options_byte_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Frame_type_byte_label = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Frame_ID_byte_label = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Receiver_ADD_LSB_byte_label = new System.Windows.Forms.Label();
            this.Receiver_ADD_MSB_byte_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Lenght_LSB_byte_label = new System.Windows.Forms.Label();
            this.Lenght_MSB_byte_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Start_byte_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Xbee_Serial_send_Button = new System.Windows.Forms.Button();
            this.FULL_XBEE_PACKET_label = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPortState = new System.Windows.Forms.Button();
            this.cboHandShaking = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Frame_data_visualizer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // TEXT_STRING_INPUT
            // 
            this.TEXT_STRING_INPUT.Location = new System.Drawing.Point(25, 603);
            this.TEXT_STRING_INPUT.Name = "TEXT_STRING_INPUT";
            this.TEXT_STRING_INPUT.Size = new System.Drawing.Size(707, 20);
            this.TEXT_STRING_INPUT.TabIndex = 1;
            this.TEXT_STRING_INPUT.Text = "A:16:255:25:110";
            this.TEXT_STRING_INPUT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OPEN_PORT
            // 
            this.OPEN_PORT.Location = new System.Drawing.Point(1099, 621);
            this.OPEN_PORT.Name = "OPEN_PORT";
            this.OPEN_PORT.Size = new System.Drawing.Size(75, 62);
            this.OPEN_PORT.TabIndex = 2;
            this.OPEN_PORT.Text = "OPEN PORT";
            this.OPEN_PORT.UseVisualStyleBackColor = true;
            this.OPEN_PORT.Click += new System.EventHandler(this.OPEN_PORT_Click);
            // 
            // lblSend
            // 
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(786, 643);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(61, 13);
            this.lblSend.TabIndex = 3;
            this.lblSend.Text = "Send &Data:";
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(25, 640);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(707, 20);
            this.txtSendData.TabIndex = 4;
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfTerminal.Location = new System.Drawing.Point(25, 253);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(710, 344);
            this.rtfTerminal.TabIndex = 5;
            this.rtfTerminal.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(741, 253);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 344);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Frame_data_visualizer
            // 
            this.Frame_data_visualizer.BackColor = System.Drawing.Color.Silver;
            this.Frame_data_visualizer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Frame_data_visualizer.Controls.Add(this.panel7);
            this.Frame_data_visualizer.Controls.Add(this.button4);
            this.Frame_data_visualizer.Controls.Add(this.panel8);
            this.Frame_data_visualizer.Controls.Add(this.panel10);
            this.Frame_data_visualizer.Controls.Add(this.panel3);
            this.Frame_data_visualizer.Controls.Add(this.panel6);
            this.Frame_data_visualizer.Controls.Add(this.panel4);
            this.Frame_data_visualizer.Controls.Add(this.button1);
            this.Frame_data_visualizer.Controls.Add(this.Xbee_Serial_send_Button);
            this.Frame_data_visualizer.Controls.Add(this.FULL_XBEE_PACKET_label);
            this.Frame_data_visualizer.Controls.Add(this.label31);
            this.Frame_data_visualizer.Controls.Add(this.panel2);
            this.Frame_data_visualizer.Controls.Add(this.panel5);
            this.Frame_data_visualizer.Location = new System.Drawing.Point(25, 27);
            this.Frame_data_visualizer.Name = "Frame_data_visualizer";
            this.Frame_data_visualizer.Size = new System.Drawing.Size(1048, 206);
            this.Frame_data_visualizer.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Options_byte_label);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(389, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(40, 81);
            this.panel7.TabIndex = 49;
            // 
            // Options_byte_label
            // 
            this.Options_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Options_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Options_byte_label.Location = new System.Drawing.Point(3, 42);
            this.Options_byte_label.Name = "Options_byte_label";
            this.Options_byte_label.Size = new System.Drawing.Size(32, 22);
            this.Options_byte_label.TabIndex = 44;
            this.Options_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(-1, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "OPT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 32);
            this.button4.TabIndex = 48;
            this.button4.Text = "LOAD STRING & CONVERT TEST";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.Frame_type_byte_label);
            this.panel8.Controls.Add(this.label36);
            this.panel8.Location = new System.Drawing.Point(180, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(54, 81);
            this.panel8.TabIndex = 46;
            // 
            // Frame_type_byte_label
            // 
            this.Frame_type_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Frame_type_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame_type_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Frame_type_byte_label.Location = new System.Drawing.Point(3, 42);
            this.Frame_type_byte_label.Name = "Frame_type_byte_label";
            this.Frame_type_byte_label.Size = new System.Drawing.Size(46, 22);
            this.Frame_type_byte_label.TabIndex = 44;
            this.Frame_type_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(-1, -1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 37);
            this.label36.TabIndex = 38;
            this.label36.Text = "FR TYPE";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.Frame_ID_byte_label);
            this.panel10.Controls.Add(this.label38);
            this.panel10.Location = new System.Drawing.Point(236, 19);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(55, 81);
            this.panel10.TabIndex = 47;
            // 
            // Frame_ID_byte_label
            // 
            this.Frame_ID_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Frame_ID_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame_ID_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Frame_ID_byte_label.Location = new System.Drawing.Point(3, 42);
            this.Frame_ID_byte_label.Name = "Frame_ID_byte_label";
            this.Frame_ID_byte_label.Size = new System.Drawing.Size(47, 22);
            this.Frame_ID_byte_label.TabIndex = 44;
            this.Frame_ID_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(-1, -1);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(55, 37);
            this.label38.TabIndex = 38;
            this.label38.Text = "FR ID";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Receiver_ADD_LSB_byte_label);
            this.panel3.Controls.Add(this.Receiver_ADD_MSB_byte_label);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(297, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 81);
            this.panel3.TabIndex = 45;
            // 
            // Receiver_ADD_LSB_byte_label
            // 
            this.Receiver_ADD_LSB_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Receiver_ADD_LSB_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_ADD_LSB_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Receiver_ADD_LSB_byte_label.Location = new System.Drawing.Point(3, 43);
            this.Receiver_ADD_LSB_byte_label.Name = "Receiver_ADD_LSB_byte_label";
            this.Receiver_ADD_LSB_byte_label.Size = new System.Drawing.Size(36, 22);
            this.Receiver_ADD_LSB_byte_label.TabIndex = 44;
            this.Receiver_ADD_LSB_byte_label.Text = "--";
            this.Receiver_ADD_LSB_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Receiver_ADD_MSB_byte_label
            // 
            this.Receiver_ADD_MSB_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Receiver_ADD_MSB_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_ADD_MSB_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Receiver_ADD_MSB_byte_label.Location = new System.Drawing.Point(45, 43);
            this.Receiver_ADD_MSB_byte_label.Name = "Receiver_ADD_MSB_byte_label";
            this.Receiver_ADD_MSB_byte_label.Size = new System.Drawing.Size(36, 22);
            this.Receiver_ADD_MSB_byte_label.TabIndex = 44;
            this.Receiver_ADD_MSB_byte_label.Text = "--";
            this.Receiver_ADD_MSB_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Rec ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.Lenght_LSB_byte_label);
            this.panel6.Controls.Add(this.Lenght_MSB_byte_label);
            this.panel6.Location = new System.Drawing.Point(64, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 81);
            this.panel6.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(62, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 12);
            this.label20.TabIndex = 48;
            this.label20.Text = "MSB";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(6, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "LSB";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(-1, -1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 21);
            this.label19.TabIndex = 38;
            this.label19.Text = "LENGTH";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lenght_LSB_byte_label
            // 
            this.Lenght_LSB_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Lenght_LSB_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lenght_LSB_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lenght_LSB_byte_label.Location = new System.Drawing.Point(3, 42);
            this.Lenght_LSB_byte_label.Name = "Lenght_LSB_byte_label";
            this.Lenght_LSB_byte_label.Size = new System.Drawing.Size(50, 22);
            this.Lenght_LSB_byte_label.TabIndex = 46;
            this.Lenght_LSB_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lenght_MSB_byte_label
            // 
            this.Lenght_MSB_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Lenght_MSB_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lenght_MSB_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lenght_MSB_byte_label.Location = new System.Drawing.Point(59, 42);
            this.Lenght_MSB_byte_label.Name = "Lenght_MSB_byte_label";
            this.Lenght_MSB_byte_label.Size = new System.Drawing.Size(50, 22);
            this.Lenght_MSB_byte_label.TabIndex = 45;
            this.Lenght_MSB_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Start_byte_label);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(7, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(55, 81);
            this.panel4.TabIndex = 45;
            // 
            // Start_byte_label
            // 
            this.Start_byte_label.BackColor = System.Drawing.Color.Silver;
            this.Start_byte_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_byte_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start_byte_label.Location = new System.Drawing.Point(2, 41);
            this.Start_byte_label.Name = "Start_byte_label";
            this.Start_byte_label.Size = new System.Drawing.Size(48, 22);
            this.Start_byte_label.TabIndex = 44;
            this.Start_byte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "START";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 32);
            this.button1.TabIndex = 43;
            this.button1.Text = "LOAD STRING TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Xbee_Serial_send_Button
            // 
            this.Xbee_Serial_send_Button.BackColor = System.Drawing.Color.Red;
            this.Xbee_Serial_send_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xbee_Serial_send_Button.Image = ((System.Drawing.Image)(resources.GetObject("Xbee_Serial_send_Button.Image")));
            this.Xbee_Serial_send_Button.Location = new System.Drawing.Point(7, 125);
            this.Xbee_Serial_send_Button.Name = "Xbee_Serial_send_Button";
            this.Xbee_Serial_send_Button.Size = new System.Drawing.Size(170, 42);
            this.Xbee_Serial_send_Button.TabIndex = 19;
            this.Xbee_Serial_send_Button.Text = "SEND XBEE PACKET";
            this.Xbee_Serial_send_Button.UseVisualStyleBackColor = false;
            this.Xbee_Serial_send_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // FULL_XBEE_PACKET_label
            // 
            this.FULL_XBEE_PACKET_label.BackColor = System.Drawing.Color.Black;
            this.FULL_XBEE_PACKET_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FULL_XBEE_PACKET_label.ForeColor = System.Drawing.Color.Lime;
            this.FULL_XBEE_PACKET_label.Location = new System.Drawing.Point(209, 175);
            this.FULL_XBEE_PACKET_label.Name = "FULL_XBEE_PACKET_label";
            this.FULL_XBEE_PACKET_label.Size = new System.Drawing.Size(832, 22);
            this.FULL_XBEE_PACKET_label.TabIndex = 34;
            this.FULL_XBEE_PACKET_label.Text = "EMPTY";
            this.FULL_XBEE_PACKET_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(4, 180);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(157, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Formatted Last Sent Value";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(455, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 81);
            this.panel2.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(17, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(503, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "--";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(17, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(503, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "--";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Text = "PAYLOAD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-323, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(996, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 81);
            this.panel5.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(4, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 22);
            this.label16.TabIndex = 44;
            this.label16.Text = "--";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(-1, -1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 21);
            this.label15.TabIndex = 38;
            this.label15.Text = "CKS";
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
            this.label23.Location = new System.Drawing.Point(739, 643);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "HEX";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(739, 606);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "TEXT";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(784, 606);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Send &Data:";
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
            this.panel9.Controls.Add(this.label26);
            this.panel9.Controls.Add(this.label29);
            this.panel9.Location = new System.Drawing.Point(1079, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 206);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1187, 643);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1207, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "COMM PORT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(968, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 62);
            this.button2.TabIndex = 50;
            this.button2.Text = "LOAD COMM SETTINGS ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(1203, 296);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(75, 23);
            this.btnPortState.TabIndex = 58;
            this.btnPortState.Text = "Closed";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(1293, 404);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(121, 21);
            this.cboHandShaking.TabIndex = 57;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(1293, 377);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 21);
            this.cboParity.TabIndex = 56;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(1293, 350);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 55;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(1293, 323);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboDataBits.TabIndex = 54;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(1293, 296);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 53;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(1293, 269);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 52;
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(1203, 267);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 51;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 695);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.cboHandShaking);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.cboDataBits);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Frame_data_visualizer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtfTerminal);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.OPEN_PORT);
            this.Controls.Add(this.TEXT_STRING_INPUT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Frame_data_visualizer.ResumeLayout(false);
            this.Frame_data_visualizer.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TEXT_STRING_INPUT;
        private System.Windows.Forms.Button OPEN_PORT;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.RichTextBox rtfTerminal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel Frame_data_visualizer;
        private System.Windows.Forms.Button Xbee_Serial_send_Button;
        private System.Windows.Forms.Label FULL_XBEE_PACKET_label;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Start_byte_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Receiver_ADD_MSB_byte_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Lenght_MSB_byte_label;
        private System.Windows.Forms.Label Lenght_LSB_byte_label;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label Frame_ID_byte_label;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Frame_type_byte_label;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label Receiver_ADD_LSB_byte_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Options_byte_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.ComboBox cboHandShaking;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

