using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;

namespace Principal_Space
{
    abstract class Game
    {
        protected RenderWindow window;
        protected Color clearColor;
       



        public Game(uint width, uint height, string title, Color color) 
        {
            window = new RenderWindow(new VideoMode(width, height), title, Styles.Close);
            clearColor = color;

            window.Closed += OnClosed;
        }

   

        public void Run()
        {
            LoadContent();
            Initialize();
            while (window.IsOpen)
            {
                window.DispatchEvents();
                Tick();

                window.Clear(clearColor);
                Render();
                window.Display();
            }
        }

        private void OnClosed(object sender, EventArgs e)
        {
            window.Close();
        }



        protected abstract void LoadContent();
        protected abstract void Initialize();
        protected abstract void Render();
        protected abstract void Tick();
    }
}
