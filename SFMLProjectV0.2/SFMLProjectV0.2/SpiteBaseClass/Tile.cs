using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;

namespace SpiteBaseClass
{
    public class Tile
    {
        private String  _Name;
        private Texture _TextureTile;

        public Tile( string Name, Texture TextureTile)
        {
            _Name = Name;
            _TextureTile = TextureTile;
        }

        public string Name { get => _Name; set => _Name = value; }
        public Texture TextureTile { get => _TextureTile; set => _TextureTile = value; }
    }
}
