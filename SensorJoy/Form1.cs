using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;

namespace SensorJoy
{
    public partial class Form1 : Form
    {
        private PortHelper portHelper;
        private KeyHook keyhook;
        private ActionMatcher matcher;

        public Form1()
        {
            InitializeComponent();
            //初始化，绑定数据
            portHelper = new PortHelper(serialPort);
            portHelper.checkSerialPort();
            if (portHelper.isComConn)
                bluetooth.Visible = true;
  
            Form1Move();    //设置窗口可拖动

            keyhook = new KeyHook();
            matcher = new ActionMatcher(keyhook);

        }

       

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //在这里添加接收串口数据并处理的代码
            byte data = portHelper.recvData();
            matcher.match(data);
        }

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void Form1Move()
        {
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.MouseDown += Form1_MouseDown;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            portHelper.close();
            Application.Exit();
        }

        private void arrow1_Click(object sender, EventArgs e)
        {
            if(portHelper.isComConn)
            {
                matcher.mode = ActionMatcher.MODE_EASY;
                portHelper.open();
                this.bluetooth.Image = global::SensorJoy.Properties.Resources.bluetooth;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("请连接蓝牙串口");
            }
            
        }

        private void arrow2_Click(object sender, EventArgs e)
        {
            if (portHelper.isComConn)
            {
                matcher.mode = ActionMatcher.MODE_HARD;
                matcher.gear = 0;
                matcher.GEARER = ActionMatcher.GEAR_UP;
                portHelper.open();
                this.bluetooth.Image = global::SensorJoy.Properties.Resources.bluetooth;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("请连接蓝牙串口");
            }
            
        }

        private void bluetooth_Click(object sender, EventArgs e)
        {
            if(portHelper.isComOpen)
            {
                this.bluetooth.Image = global::SensorJoy.Properties.Resources.bluetooth2;
                portHelper.close();
            }
            else
            {
                this.bluetooth.Image = global::SensorJoy.Properties.Resources.bluetooth;
                portHelper.open();
            }
        }

      
    }
}
