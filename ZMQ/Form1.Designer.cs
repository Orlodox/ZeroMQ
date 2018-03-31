namespace ZMQ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReqRep = new System.Windows.Forms.Button();
            this.PubSub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SyncSyb = new System.Windows.Forms.Button();
            this.Panel_ReqRep = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Go_ReqRep = new System.Windows.Forms.Button();
            this.Menu_ReqRep = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answer_ReqRep = new System.Windows.Forms.TextBox();
            this.message_ReqRep = new System.Windows.Forms.TextBox();
            this.address_ReqRep = new System.Windows.Forms.TextBox();
            this.Panel_PubSub = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Go_PubSub = new System.Windows.Forms.Button();
            this.Menu_PubSub = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.message_PubSub = new System.Windows.Forms.TextBox();
            this.address_PubSub = new System.Windows.Forms.TextBox();
            this.Panel_WU = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Go_WU = new System.Windows.Forms.Button();
            this.Menu_WU = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.textBox_ZipCode = new System.Windows.Forms.TextBox();
            this.address_WU = new System.Windows.Forms.TextBox();
            this.Panel_SS = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.Go_SS = new System.Windows.Forms.Button();
            this.Menu_SS = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_endKeyword = new System.Windows.Forms.TextBox();
            this.address2_SS = new System.Windows.Forms.TextBox();
            this.address1_SS = new System.Windows.Forms.TextBox();
            this.Panel_ReqRep.SuspendLayout();
            this.Panel_PubSub.SuspendLayout();
            this.Panel_WU.SuspendLayout();
            this.Panel_SS.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReqRep
            // 
            this.ReqRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReqRep.Location = new System.Drawing.Point(12, 12);
            this.ReqRep.Name = "ReqRep";
            this.ReqRep.Size = new System.Drawing.Size(228, 64);
            this.ReqRep.TabIndex = 0;
            this.ReqRep.Text = "REQ - REP \r\n(client)";
            this.ReqRep.UseVisualStyleBackColor = true;
            this.ReqRep.Click += new System.EventHandler(this.ReqRep_Click);
            // 
            // PubSub
            // 
            this.PubSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PubSub.Location = new System.Drawing.Point(12, 82);
            this.PubSub.Name = "PubSub";
            this.PubSub.Size = new System.Drawing.Size(228, 64);
            this.PubSub.TabIndex = 1;
            this.PubSub.Text = "PUB - SUB \r\n(server)";
            this.PubSub.UseVisualStyleBackColor = true;
            this.PubSub.Click += new System.EventHandler(this.PubSub_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "WEATHER UPDATE\r\n(server)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SyncSyb
            // 
            this.SyncSyb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SyncSyb.Location = new System.Drawing.Point(12, 222);
            this.SyncSyb.Name = "SyncSyb";
            this.SyncSyb.Size = new System.Drawing.Size(228, 64);
            this.SyncSyb.TabIndex = 3;
            this.SyncSyb.Text = "SYNC SUBSCRIBER";
            this.SyncSyb.UseVisualStyleBackColor = true;
            this.SyncSyb.Click += new System.EventHandler(this.SyncSub_Click);
            // 
            // Panel_ReqRep
            // 
            this.Panel_ReqRep.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel_ReqRep.Controls.Add(this.label5);
            this.Panel_ReqRep.Controls.Add(this.Go_ReqRep);
            this.Panel_ReqRep.Controls.Add(this.Menu_ReqRep);
            this.Panel_ReqRep.Controls.Add(this.label3);
            this.Panel_ReqRep.Controls.Add(this.label4);
            this.Panel_ReqRep.Controls.Add(this.label2);
            this.Panel_ReqRep.Controls.Add(this.label1);
            this.Panel_ReqRep.Controls.Add(this.answer_ReqRep);
            this.Panel_ReqRep.Controls.Add(this.message_ReqRep);
            this.Panel_ReqRep.Controls.Add(this.address_ReqRep);
            this.Panel_ReqRep.Location = new System.Drawing.Point(246, 12);
            this.Panel_ReqRep.Name = "Panel_ReqRep";
            this.Panel_ReqRep.Size = new System.Drawing.Size(228, 276);
            this.Panel_ReqRep.TabIndex = 4;
            this.Panel_ReqRep.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "REQUEST-REPLY (client)";
            // 
            // Go_ReqRep
            // 
            this.Go_ReqRep.Location = new System.Drawing.Point(11, 204);
            this.Go_ReqRep.Name = "Go_ReqRep";
            this.Go_ReqRep.Size = new System.Drawing.Size(206, 29);
            this.Go_ReqRep.TabIndex = 3;
            this.Go_ReqRep.Text = "GO";
            this.Go_ReqRep.UseVisualStyleBackColor = true;
            this.Go_ReqRep.Click += new System.EventHandler(this.Go_ReqRep_Click);
            // 
            // Menu_ReqRep
            // 
            this.Menu_ReqRep.Location = new System.Drawing.Point(11, 239);
            this.Menu_ReqRep.Name = "Menu_ReqRep";
            this.Menu_ReqRep.Size = new System.Drawing.Size(206, 29);
            this.Menu_ReqRep.TabIndex = 3;
            this.Menu_ReqRep.Text = "MENU";
            this.Menu_ReqRep.UseVisualStyleBackColor = true;
            this.Menu_ReqRep.Click += new System.EventHandler(this.Menu_ReqRep_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "tcp://";
            // 
            // answer_ReqRep
            // 
            this.answer_ReqRep.Location = new System.Drawing.Point(22, 161);
            this.answer_ReqRep.Name = "answer_ReqRep";
            this.answer_ReqRep.ReadOnly = true;
            this.answer_ReqRep.Size = new System.Drawing.Size(188, 22);
            this.answer_ReqRep.TabIndex = 0;
            this.answer_ReqRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // message_ReqRep
            // 
            this.message_ReqRep.Location = new System.Drawing.Point(22, 108);
            this.message_ReqRep.Name = "message_ReqRep";
            this.message_ReqRep.Size = new System.Drawing.Size(188, 22);
            this.message_ReqRep.TabIndex = 0;
            this.message_ReqRep.Text = "Hello";
            this.message_ReqRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address_ReqRep
            // 
            this.address_ReqRep.Location = new System.Drawing.Point(59, 58);
            this.address_ReqRep.Name = "address_ReqRep";
            this.address_ReqRep.Size = new System.Drawing.Size(151, 22);
            this.address_ReqRep.TabIndex = 0;
            this.address_ReqRep.Text = "127.0.0.1:5559";
            // 
            // Panel_PubSub
            // 
            this.Panel_PubSub.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel_PubSub.Controls.Add(this.label6);
            this.Panel_PubSub.Controls.Add(this.Go_PubSub);
            this.Panel_PubSub.Controls.Add(this.Menu_PubSub);
            this.Panel_PubSub.Controls.Add(this.label7);
            this.Panel_PubSub.Controls.Add(this.label9);
            this.Panel_PubSub.Controls.Add(this.label10);
            this.Panel_PubSub.Controls.Add(this.message_PubSub);
            this.Panel_PubSub.Controls.Add(this.address_PubSub);
            this.Panel_PubSub.Location = new System.Drawing.Point(480, 12);
            this.Panel_PubSub.Name = "Panel_PubSub";
            this.Panel_PubSub.Size = new System.Drawing.Size(228, 276);
            this.Panel_PubSub.TabIndex = 4;
            this.Panel_PubSub.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "PUBLISHER-SUBSCRIBER\r\n(server)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Go_PubSub
            // 
            this.Go_PubSub.Location = new System.Drawing.Point(11, 204);
            this.Go_PubSub.Name = "Go_PubSub";
            this.Go_PubSub.Size = new System.Drawing.Size(206, 29);
            this.Go_PubSub.TabIndex = 3;
            this.Go_PubSub.Text = "GO";
            this.Go_PubSub.UseVisualStyleBackColor = true;
            this.Go_PubSub.Click += new System.EventHandler(this.Go_PubSub_Click);
            // 
            // Menu_PubSub
            // 
            this.Menu_PubSub.Location = new System.Drawing.Point(11, 239);
            this.Menu_PubSub.Name = "Menu_PubSub";
            this.Menu_PubSub.Size = new System.Drawing.Size(206, 29);
            this.Menu_PubSub.TabIndex = 3;
            this.Menu_PubSub.Text = "MENU";
            this.Menu_PubSub.UseVisualStyleBackColor = true;
            this.Menu_PubSub.Click += new System.EventHandler(this.Menu_PubSub_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Message";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "tcp://";
            // 
            // message_PubSub
            // 
            this.message_PubSub.Location = new System.Drawing.Point(22, 132);
            this.message_PubSub.Name = "message_PubSub";
            this.message_PubSub.Size = new System.Drawing.Size(188, 22);
            this.message_PubSub.TabIndex = 0;
            this.message_PubSub.Text = "Hello";
            this.message_PubSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address_PubSub
            // 
            this.address_PubSub.Location = new System.Drawing.Point(59, 82);
            this.address_PubSub.Name = "address_PubSub";
            this.address_PubSub.Size = new System.Drawing.Size(151, 22);
            this.address_PubSub.TabIndex = 0;
            this.address_PubSub.Text = "127.0.0.1:5559";
            // 
            // Panel_WU
            // 
            this.Panel_WU.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel_WU.Controls.Add(this.label8);
            this.Panel_WU.Controls.Add(this.Go_WU);
            this.Panel_WU.Controls.Add(this.Menu_WU);
            this.Panel_WU.Controls.Add(this.label11);
            this.Panel_WU.Controls.Add(this.label12);
            this.Panel_WU.Controls.Add(this.label13);
            this.Panel_WU.Controls.Add(this.label15);
            this.Panel_WU.Controls.Add(this.label14);
            this.Panel_WU.Controls.Add(this.textBox_temp);
            this.Panel_WU.Controls.Add(this.textBox_ZipCode);
            this.Panel_WU.Controls.Add(this.address_WU);
            this.Panel_WU.Location = new System.Drawing.Point(714, 12);
            this.Panel_WU.Name = "Panel_WU";
            this.Panel_WU.Size = new System.Drawing.Size(228, 276);
            this.Panel_WU.TabIndex = 5;
            this.Panel_WU.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "WEATHER UPDATE (server)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Go_WU
            // 
            this.Go_WU.Location = new System.Drawing.Point(11, 204);
            this.Go_WU.Name = "Go_WU";
            this.Go_WU.Size = new System.Drawing.Size(206, 29);
            this.Go_WU.TabIndex = 3;
            this.Go_WU.Text = "GO";
            this.Go_WU.UseVisualStyleBackColor = true;
            this.Go_WU.Click += new System.EventHandler(this.Go_WU_Click);
            // 
            // Menu_WU
            // 
            this.Menu_WU.Location = new System.Drawing.Point(11, 239);
            this.Menu_WU.Name = "Menu_WU";
            this.Menu_WU.Size = new System.Drawing.Size(206, 29);
            this.Menu_WU.TabIndex = 3;
            this.Menu_WU.Text = "MENU";
            this.Menu_WU.UseVisualStyleBackColor = true;
            this.Menu_WU.Click += new System.EventHandler(this.Menu_WU_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Temperature";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "ZipCode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(157, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Celsius";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "tcp://";
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(22, 160);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(129, 22);
            this.textBox_temp.TabIndex = 0;
            this.textBox_temp.Text = "15";
            this.textBox_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ZipCode
            // 
            this.textBox_ZipCode.Location = new System.Drawing.Point(22, 108);
            this.textBox_ZipCode.Name = "textBox_ZipCode";
            this.textBox_ZipCode.Size = new System.Drawing.Size(188, 22);
            this.textBox_ZipCode.TabIndex = 0;
            this.textBox_ZipCode.Text = "198504";
            this.textBox_ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address_WU
            // 
            this.address_WU.Location = new System.Drawing.Point(59, 58);
            this.address_WU.Name = "address_WU";
            this.address_WU.Size = new System.Drawing.Size(151, 22);
            this.address_WU.TabIndex = 0;
            this.address_WU.Text = "127.0.0.1:5559";
            // 
            // Panel_SS
            // 
            this.Panel_SS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel_SS.Controls.Add(this.label16);
            this.Panel_SS.Controls.Add(this.Go_SS);
            this.Panel_SS.Controls.Add(this.Menu_SS);
            this.Panel_SS.Controls.Add(this.label22);
            this.Panel_SS.Controls.Add(this.label17);
            this.Panel_SS.Controls.Add(this.label18);
            this.Panel_SS.Controls.Add(this.label20);
            this.Panel_SS.Controls.Add(this.label19);
            this.Panel_SS.Controls.Add(this.label21);
            this.Panel_SS.Controls.Add(this.textBox_endKeyword);
            this.Panel_SS.Controls.Add(this.address2_SS);
            this.Panel_SS.Controls.Add(this.address1_SS);
            this.Panel_SS.Location = new System.Drawing.Point(948, 12);
            this.Panel_SS.Name = "Panel_SS";
            this.Panel_SS.Size = new System.Drawing.Size(228, 276);
            this.Panel_SS.TabIndex = 5;
            this.Panel_SS.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(38, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "SYNC SUBSCRIBER";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Go_SS
            // 
            this.Go_SS.Location = new System.Drawing.Point(11, 204);
            this.Go_SS.Name = "Go_SS";
            this.Go_SS.Size = new System.Drawing.Size(206, 29);
            this.Go_SS.TabIndex = 3;
            this.Go_SS.Text = "GO";
            this.Go_SS.UseVisualStyleBackColor = true;
            this.Go_SS.Click += new System.EventHandler(this.Go_SS_Click);
            // 
            // Menu_SS
            // 
            this.Menu_SS.Location = new System.Drawing.Point(11, 239);
            this.Menu_SS.Name = "Menu_SS";
            this.Menu_SS.Size = new System.Drawing.Size(206, 29);
            this.Menu_SS.TabIndex = 3;
            this.Menu_SS.Text = "MENU";
            this.Menu_SS.UseVisualStyleBackColor = true;
            this.Menu_SS.Click += new System.EventHandler(this.Menu_SS_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(79, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Address 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(79, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Address 1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Complete Reception";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(69, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "end keyword";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "tcp://";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "tcp://";
            // 
            // textBox_endKeyword
            // 
            this.textBox_endKeyword.Location = new System.Drawing.Point(22, 160);
            this.textBox_endKeyword.Name = "textBox_endKeyword";
            this.textBox_endKeyword.Size = new System.Drawing.Size(188, 22);
            this.textBox_endKeyword.TabIndex = 0;
            this.textBox_endKeyword.Text = "END";
            this.textBox_endKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address2_SS
            // 
            this.address2_SS.Location = new System.Drawing.Point(59, 111);
            this.address2_SS.Name = "address2_SS";
            this.address2_SS.Size = new System.Drawing.Size(151, 22);
            this.address2_SS.TabIndex = 0;
            this.address2_SS.Text = "127.0.0.1:5559";
            // 
            // address1_SS
            // 
            this.address1_SS.Location = new System.Drawing.Point(59, 58);
            this.address1_SS.Name = "address1_SS";
            this.address1_SS.Size = new System.Drawing.Size(151, 22);
            this.address1_SS.TabIndex = 0;
            this.address1_SS.Text = "127.0.0.1:5558";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 299);
            this.Controls.Add(this.Panel_SS);
            this.Controls.Add(this.Panel_PubSub);
            this.Controls.Add(this.Panel_WU);
            this.Controls.Add(this.SyncSyb);
            this.Controls.Add(this.Panel_ReqRep);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PubSub);
            this.Controls.Add(this.ReqRep);
            this.Name = "Form1";
            this.Text = "ZeroMQ";
            this.Panel_ReqRep.ResumeLayout(false);
            this.Panel_ReqRep.PerformLayout();
            this.Panel_PubSub.ResumeLayout(false);
            this.Panel_PubSub.PerformLayout();
            this.Panel_WU.ResumeLayout(false);
            this.Panel_WU.PerformLayout();
            this.Panel_SS.ResumeLayout(false);
            this.Panel_SS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReqRep;
        private System.Windows.Forms.Button PubSub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SyncSyb;
        private System.Windows.Forms.Panel Panel_ReqRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_ReqRep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox message_ReqRep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Go_ReqRep;
        private System.Windows.Forms.Button Menu_ReqRep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox answer_ReqRep;
        private System.Windows.Forms.Panel Panel_PubSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Go_PubSub;
        private System.Windows.Forms.Button Menu_PubSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox message_PubSub;
        private System.Windows.Forms.TextBox address_PubSub;
        private System.Windows.Forms.Panel Panel_WU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Go_WU;
        private System.Windows.Forms.Button Menu_WU;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_ZipCode;
        private System.Windows.Forms.TextBox address_WU;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.Panel Panel_SS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Go_SS;
        private System.Windows.Forms.Button Menu_SS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_endKeyword;
        private System.Windows.Forms.TextBox address1_SS;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox address2_SS;
    }
}

