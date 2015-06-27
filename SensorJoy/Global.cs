using System;
using System.Runtime.InteropServices;

namespace SensorJoy
{
    enum KeyState : uint { Released, Pressed };

    internal sealed class Global
    {

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk, //虚拟键值
            byte bScan,// 一般为0
            int dwFlags, //这里是整数类型 0 为按下，2为释放
            int dwExtraInfo //这里是整数类型 一般情况下设成为0
        );

        [DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
        public static extern byte MapVirtualKey(byte wCode, int wMap);



        //以下没用到
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short GetKeyState(int nVirtKey);

        /**
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint SendInput(uint nInputs, NativeMethods.INPUT[] pInputs,
            int cbSize);
         * **/

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

    }
}
