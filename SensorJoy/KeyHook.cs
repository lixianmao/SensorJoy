using System;


namespace SensorJoy
{
    class KeyHook
    {
        public void pressKey(String key)
        {
            byte keyCode = getKeyCode(key);
            Global.keybd_event(keyCode, Global.MapVirtualKey(keyCode, 0), 0, 0);
        }

        public void releaseKey(String key)
        {
            byte keyCode = getKeyCode(key);
            Global.keybd_event(keyCode, Global.MapVirtualKey(keyCode, 0), 2, 0);
        }

        public byte getKeyCode(String key)
        {
            byte wCode = 0;
            switch (key)
            {
                case "LEFT":
                    wCode = 37;
                    break;
                case "RIGHT":
                    wCode = 39;
                    break;
                case "UP":
                    wCode = 38;
                    break;
                case "X":
                    wCode = 88;
                    break;
                case "Q":
                    wCode = 81;
                    break;
                case "S":
                    wCode = 83;
                    break;
                case "C":
                    wCode = 67;
                    break;
                default:
                    break;
            }
            return wCode;
        }

    }
}
