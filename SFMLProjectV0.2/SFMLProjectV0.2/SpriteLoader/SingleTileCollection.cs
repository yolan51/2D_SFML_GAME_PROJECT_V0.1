using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpiteBaseClass;
namespace SysTextureLoader
{
    public class SingleTileCollection : List<Tile>
    {
        private string _name;
        public SingleTileCollection()
        {

        }

        public SingleTileCollection(string _name)
        {
            this._name = _name;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
