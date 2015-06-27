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
                case "DOWN":
                    wCode = 40;
                    break;
                case "W":
                    wCode = 87;
                    break;
                case "A":
                    wCode = 65;
                    break;
                case "S":
                    wCode = 83;
                    break;
                case "D":
                    wCode = 68;
                    break;
                case "SHIFT":
                    wCode = 16;
                    break;
                case "SPACE":
                    wCode = 32;
                    break;
                default:
                    break;
            }
            return wCode;
        }

    }
}
