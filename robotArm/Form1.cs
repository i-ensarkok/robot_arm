using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;              //Installed.
using System.IO;

namespace robotArm
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            
            

            string[] ports = SerialPort.GetPortNames();             //Decleration ports as a string array
            foreach (string port in ports) {                        //Reading connected ports.
                port_box.Items.Add(port);                           //Adding ports to "port_box". 
            }                      
        }     
                       
        private void Connect_button_Click_1(object sender, EventArgs e)
        {
            string x = port_box.SelectedItem.ToString();    //Our selected port convert to string and set up
            serialPort1.PortName = x;                       
            serialPort1.BaudRate = 9600;                    //Same arduino baudrate.
            timer1.Enabled = true;
            
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int channel = 1;
                int angle = trackBar1.Value;
                string data = channel.ToString() + "!" + angle.ToString() + "/";
                serialPort1.Write(data);
                this.Text = "Base angle: " + angle;
            }
            else
                MessageBox.Show("There is no connection!");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int channel = 2;
                int angle = (180- trackBar2.Value);
                string data = channel.ToString() + "!" + angle.ToString() + "/";
                serialPort1.Write(data);
                this.Text = "Shoulder angle: " + (180-angle);
            }
            else
                MessageBox.Show("There is no connection!");
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int channel = 3;
                int angle = trackBar3.Value;
                string data = channel.ToString() + "!" + angle.ToString() + "/";
                serialPort1.Write(data);
                this.Text = "Elbow angle: " + angle;
            }
            else
                MessageBox.Show("There is no connection!");
        }
                             
        private void disconnButton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataObj.Close();
            Form1 newOne = new Form1();
            newOne.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value += 10;
            label8.Text = "Please wait while connecting";
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Enabled = false;
                timer1.Enabled = false;
                try
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        label8.Visible = true;
                        label8.Text = "Connected.";
                    }

                }
                catch
                {
                    MessageBox.Show("Please select port!");
                    progressBar1.Value = 0;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label8.Text = "Please wait while disconnecting";
            progressBar1.Value -= 10;
            if(progressBar1.Value == 0)
            {
                timer2.Enabled = false;
                serialPort1.Close();
                label8.Text = "Disconnected";
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int channel = 4;
                int angle = trackBar4.Value;
                string data = channel.ToString() + "!" + angle.ToString() + "/";
                serialPort1.Write(data);
            }
            else
                MessageBox.Show("There is no connection!");
        }

        int row = 0;
        //StreamWriter dataObj = new StreamWriter(@"C:\Users\iensarkok\Desktop\Data.txt");
        private void button1_Click(object sender, EventArgs e)
        {           
          /*  if (row == 0)
            {
                dataObj.WriteLine("  X  " + "  Y  " + "  Z  " + "  Base Motor  " + "  Shoulder Motor  " + "  Elbow Motor  ");
                row++;
            }
            dataObj.WriteLine("  "+textBox1.Text+"   "+textBox2.Text+"   "+textBox3.Text+"      "+trackBar1.Value+
            "             "+ trackBar2.Value+"                "+trackBar3.Value);
            dataObj.Flush();
          */
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int test = 3;
        private void button2_Click(object sender, EventArgs e)
        {
            char[] specialCharacters = {' ','!','"','^','+','%','&','/','(',')','=','?',
'<','>',';',',','.','@','*','#','[',']','?','_','{','}'};
            string USERNAME = "admin";
            string PASSWORD = "robot+arm";
            string text1 = textBox4.Text;
            string text2 = textBox5.Text;
            bool entering = true;
            bool special = false;


            if (!Equals(USERNAME, text1))             //Controlling USERNAME.
            {
                entering = false;
            }
            if (!Equals(PASSWORD, text2))            //Controlling PASSWORD.
            {
                entering = false;
            }

            foreach (char character in specialCharacters)     //Controlling special characters.
            {
                for (int i = 0; i < text2.Length; i++)
                {
                    if (Equals(character, text2[i].ToString()))
                    {
                        special = true;
                    }
                }
            }
            //foreach(string character in specialCharacters)        This code block can also controls 
            //{                                                     special characters.
            //    if (text2.Contains(character))
            //    {
            //        special = true;
            //    }
            //}

            if (entering)                                          //Main process
            {
                MessageBox.Show("Entering is successful !");
                setup_panel.Enabled = true;
                control_panel.Enabled = true;
                save_panel.Enabled = true;
                
            }
            else
            {
                test--;              //To do it 3 times      
                label14.Text = "Remaining password retry:  "+test.ToString();
                if (test == 0)
                {
                    MessageBox.Show("3 invalid login attempts. Please try again later.");
                    Application.Exit();
                }
                else if (text2.Length < 8)
                {
                    MessageBox.Show("Your password is shorter than 8 characters!");
                }
                else if (!special)
                {
                    MessageBox.Show("Required at least one special character!");
                }
                else
                    MessageBox.Show("Your username or password is false!");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }
    }
}

