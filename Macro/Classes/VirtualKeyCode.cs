using System.Windows.Forms;

namespace Macro
{
    class VirtualKeyCode
    {
        public static string GetKeyData(int keyCode)
        {
            KeysConverter KC = new KeysConverter();
            return KC.ConvertToString(keyCode).ToString();
        }
    }
}
