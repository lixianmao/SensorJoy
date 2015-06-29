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
        public Boolean isComConn;
        public Boolean isComOpen;
        
        public PortHelper(SerialPort com)
        {
            this.com = com;
        }

        public void checkSerialPort()
        {
            String[] ports = SerialPort.GetPortNames();
            if(ports == null || ports.Length == 0)
            {
                isComConn = false;
            }
            else
            {
                isComConn = true;
                setPortInfo(ports[0]);
            }
        }

        public void setPortInfo(string portName)
        {
            com.PortName = portName;
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
            byte data = (byte)(buf[0] & 0x0F);
            return data;
        }

        public void open()
        {
            if(!com.IsOpen)
            {
                isComOpen = true;
                com.Open();
            }
        }

        public void close()
        {
            if(com.IsOpen)
            {
                isComOpen = false;
                com.Close();               
            }
        }
    }
}
