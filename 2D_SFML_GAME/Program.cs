
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using System.Runtime.InteropServices;




namespace SFML._2D_SFML_GAME
    {
        class Program
        {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        private static Boolean NoDebugMode = true;
        static void Main()
        {
            SwitchDebugMode(NoDebugMode);
            RenderWindow window = new RenderWindow(new Window.VideoMode(200, 200), "test");
            CircleShape cs = new CircleShape(100.0f);
            cs.FillColor = Color.Green;
            window.SetActive();

            while (window.IsOpen)
            {
                window.Clear();
                window.DispatchEvents();
                window.Draw(cs);
                window.Display();
            }
        }

        static private void SwitchDebugMode(Boolean NoDebugMode)
        {
            if (NoDebugMode)
            {
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);

            }
        }

    }
}

