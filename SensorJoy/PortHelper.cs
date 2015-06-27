using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text;

namespace SensorJoy
{

    class PortHelper
    {
        private SerialPort com;
        private ComboBox cb;
        
        public PortHelper(SerialPort com)
        {
            this.com = com;
        }

        public void setComboBox(ComboBox cb)
        {
            this.cb = cb;
        }

        public void checkSerialPort()
        {
            String[] ports = SerialPort.GetPortNames();
            if(ports == null || ports.Length == 0)
            {
                //add code here
            }
            foreach(String port in ports)
            {
                cb.Items.Add(port);
                cb.SelectedIndex = 0;
            }
        }

        public void setPortInfo()
        {
            com.PortName = cb.Text;
            com.BaudRate = 9600;
            com.Parity = Parity.None;
            com.StopBits = StopBits.One;
            com.DataBits = 8;
        }

        public byte recvData()
        {
            int n = com.BytesToRead;
            byte[] buf = new byte[n];
            com.Read(buf, 0, n);
            return buf[0];
        }

        public void open()
        {
            if(!com.IsOpen)
            {
                com.Open();
            }
        }

        public void close()
        {
            if(com.IsOpen)
            {
                com.Close();
            }
        }

    }
}
