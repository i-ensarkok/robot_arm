namespace robotArm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.setup_panel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.disconnButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.control_panel = new System.Windows.Forms.Panel();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.login_panel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.setup_panel.SuspendLayout();
            this.control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.save_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setup_panel
            // 
            this.setup_panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.setup_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setup_panel.Controls.Add(this.progressBar1);
            this.setup_panel.Controls.Add(this.disconnButton);
            this.setup_panel.Controls.Add(this.label8);
            this.setup_panel.Controls.Add(this.connect_button);
            this.setup_panel.Controls.Add(this.label4);
            this.setup_panel.Controls.Add(this.port_box);
            this.setup_panel.Controls.Add(this.label3);
            this.setup_panel.Enabled = false;
            this.setup_panel.Location = new System.Drawing.Point(12, 155);
            this.setup_panel.Name = "setup_panel";
            this.setup_panel.Size = new System.Drawing.Size(166, 146);
            this.setup_panel.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(144, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // disconnButton
            // 
            this.disconnButton.BackColor = System.Drawing.Color.White;
            this.disconnButton.Location = new System.Drawing.Point(84, 105);
            this.disconnButton.Name = "disconnButton";
            this.disconnButton.Size = new System.Drawing.Size(69, 28);
            this.disconnButton.TabIndex = 12;
            this.disconnButton.Text = "Disconnect";
            this.disconnButton.UseVisualStyleBackColor = false;
            this.disconnButton.Click += new System.EventHandler(this.disconnButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.White;
            this.connect_button.Location = new System.Drawing.Point(9, 105);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(69, 28);
            this.connect_button.TabIndex = 11;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.Connect_button_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "SETUP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // port_box
            // 
            this.port_box.FormattingEnabled = true;
            this.port_box.Location = new System.Drawing.Point(57, 33);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(75, 21);
            this.port_box.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port :";
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.SlateGray;
            this.control_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.control_panel.Controls.Add(this.trackBar4);
            this.control_panel.Controls.Add(this.trackBar3);
            this.control_panel.Controls.Add(this.trackBar2);
            this.control_panel.Controls.Add(this.trackBar1);
            this.control_panel.Controls.Add(this.label7);
            this.control_panel.Controls.Add(this.label6);
            this.control_panel.Controls.Add(this.label5);
            this.control_panel.Controls.Add(this.label2);
            this.control_panel.Controls.Add(this.label1);
            this.control_panel.Enabled = false;
            this.control_panel.Location = new System.Drawing.Point(184, 27);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(362, 174);
            this.control_panel.TabIndex = 6;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(100, 128);
            this.trackBar4.Maximum = 180;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(251, 45);
            this.trackBar4.TabIndex = 13;
            this.trackBar4.TickFrequency = 10;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(100, 98);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(251, 45);
            this.trackBar3.TabIndex = 12;
            this.trackBar3.TickFrequency = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(100, 67);
            this.trackBar2.Maximum = 90;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar2.Size = new System.Drawing.Size(251, 45);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Value = 90;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(100, 39);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(251, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gripper      :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Shoulder   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Elbow        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base         :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANUEL CONTROL";
            // 
            // save_panel
            // 
            this.save_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.save_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.save_panel.Controls.Add(this.label11);
            this.save_panel.Controls.Add(this.label10);
            this.save_panel.Controls.Add(this.label9);
            this.save_panel.Controls.Add(this.button1);
            this.save_panel.Controls.Add(this.textBox3);
            this.save_panel.Controls.Add(this.textBox2);
            this.save_panel.Controls.Add(this.textBox1);
            this.save_panel.Enabled = false;
            this.save_panel.Location = new System.Drawing.Point(184, 207);
            this.save_panel.Name = "save_panel";
            this.save_panel.Size = new System.Drawing.Size(362, 94);
            this.save_panel.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "z(mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "y(mm)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "x(mm)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.login_panel.Controls.Add(this.label15);
            this.login_panel.Controls.Add(this.label14);
            this.login_panel.Controls.Add(this.label13);
            this.login_panel.Controls.Add(this.label12);
            this.login_panel.Controls.Add(this.textBox5);
            this.login_panel.Controls.Add(this.textBox4);
            this.login_panel.Controls.Add(this.button2);
            this.login_panel.Location = new System.Drawing.Point(12, 27);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(166, 122);
            this.login_panel.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(55, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "LOGIN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Location = new System.Drawing.Point(7, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Remaining password retry:  3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Location = new System.Drawing.Point(5, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(3, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Username";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 311);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.save_panel);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.setup_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Robot Arm Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.setup_panel.ResumeLayout(false);
            this.setup_panel.PerformLayout();
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.save_panel.ResumeLayout(false);
            this.save_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel setup_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox port_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel save_panel;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button disconnButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
    }
}

