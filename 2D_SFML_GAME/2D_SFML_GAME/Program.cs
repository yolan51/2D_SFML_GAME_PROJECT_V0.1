using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using System.Runtime.InteropServices;
using _2D_SFML_GAME;

namespace Controler
{
    class program
    {
        static void Main(string[] args)
        {
            ImpGame mygame = new ImpGame();
            mygame.Run();
        }

    }
    
}
    