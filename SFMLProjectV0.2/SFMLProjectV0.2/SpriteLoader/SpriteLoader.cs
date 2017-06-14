using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SpiteBaseClass;

namespace SysSpriteLoader
{
    public class SpriteLoader
    {
        public static List<Tile> SingleTileListe = new List<Tile>();
        

        internal void ProcessCommand(List<string> listeOfcommande)
        {
            foreach(string CommandParametter in listeOfcommande)
            {
                //  SingleTile: ImgPath, StartPoxX, StartingPosY, Width, Height
                string[] token = CommandParametter.Split(new Char[] { ',', ':' });
                CmdChecker(token); ;

                
            }
        }
       
        private void CmdChecker(string[] token)
        {
            if (token[0].Equals("Tile", StringComparison.OrdinalIgnoreCase))
            {
                // Going to Single tile Collection with name

                //LoadUniqueSprite();

            }
            else if (token[0].Equals("GroupTile", StringComparison.OrdinalIgnoreCase))
            {
                //Special Case Multi-loading

            }
            else if (token[0].Equals("AnimationLeftToRight", StringComparison.OrdinalIgnoreCase))
            {


            }
            else if (token[0].Equals("AnimationTopToBottom", StringComparison.OrdinalIgnoreCase))
            {


            }
            else if (token[0].Equals("ObjectLeftToRight", StringComparison.OrdinalIgnoreCase))
            {


            }
            else if (token[0].Equals("ObjectTopToBottom", StringComparison.OrdinalIgnoreCase))
            {


            }
            else if (token[0].Equals("EffectLeftToRight", StringComparison.OrdinalIgnoreCase))
            {


            }
            else if (token[0].Equals("EffectTopToBottom", StringComparison.OrdinalIgnoreCase))
            {


            }
            else if (token[0].Equals("Object", StringComparison.OrdinalIgnoreCase))
            {


            }
        }
    }
}
