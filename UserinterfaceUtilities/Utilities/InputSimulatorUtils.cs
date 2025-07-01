using WindowsInput;
using WindowsInput.Native;

namespace UserinterfaceUtilities.Utilities
{
    public static class InputSimulatorUtils
    {
        private static InputSimulator InputSimulator => new();

        public static void SendText(string text) => InputSimulator.Keyboard.TextEntry(text);

        public static void PressEnter() => InputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
    }
}
