using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace SensorJoy
{
    public partial class Form1 : Form
    {
        private PortHelper portHelper;
        private Boolean isOpen = false;
        private KeyHook keyhook;
        private ActionMatcher matcher;

        public Form1()
        {
            InitializeComponent();
            //初始化，绑定数据
            portHelper = new PortHelper(serialPort);
            portHelper.setComboBox(comboBox1);
            portHelper.checkSerialPort();
            keyhook = new KeyHook();
            matcher = new ActionMatcher(keyhook);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //在这里添加接收串口数据并处理的代码
            byte data = portHelper.recvData();

            matcher.match(data);
        }

        private void connectLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!isOpen)
            {
                portHelper.open();
                isOpen = true;
                button1.Text = "关闭";
            }
            else
            {
                portHelper.close();
                isOpen = false;
                button1.Text = "打开";
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            portHelper.setPortInfo();
            connectLabel.Text = comboBox1.Text;
        }

    }
}
