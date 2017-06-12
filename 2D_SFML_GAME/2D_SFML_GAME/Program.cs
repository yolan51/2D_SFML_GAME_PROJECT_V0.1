﻿
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SFML.Graphics;
    using SFML.Window;


    namespace SFML._2D_SFML_GAME
    {
        class Program
        {
            static void Main()
            {
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
        }
    }

