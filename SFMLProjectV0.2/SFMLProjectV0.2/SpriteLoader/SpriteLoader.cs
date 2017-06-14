using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SFML.Graphics;
using SpiteBaseClass;

namespace SysTextureLoader
{
    public class SpriteLoader
    {
        public static SingleTileCollection SingleTileListe = new SingleTileCollection("MainTileCollection");
        public static GroupTileCollection GroupTileListe = new GroupTileCollection();

        internal void ProcessCommand(List<string> listeOfcommande)
        {
            foreach(string CommandParametter in listeOfcommande)
            {
                // Command  : AllProprities
                //  SingleTile: ImgPath, StartPoxX, StartingPosY, Width, Height,Name
                string[] token = CommandParametter.Split(new Char[] { ',', ':' });
                CmdChecker(token); ;

                
            }
        }
       
        private void CmdChecker(string[] token)
        {

            IntRect TextureInfo = new IntRect(Convert.ToInt32(token[2]), Convert.ToInt32(token[3]), Convert.ToInt32(token[4]), Convert.ToInt32(token[5]));

            if (token[0].Equals("Tile", StringComparison.OrdinalIgnoreCase))
            {
                // Going to Single tile Collection with name


                

                LoadUniqueTile(token[1], TextureInfo, token[6]);








            }
            else if (token[0].Equals("GroupTile", StringComparison.OrdinalIgnoreCase))
            {
                //Special Case Multi-loading

                //load into temp singletilelist

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

        private void LoadUniqueTile(string imgPath, IntRect TextureInfo,string name)
        {

            
            Tile singletile = new Tile(name, new Texture(imgPath, TextureInfo));
            SingleTileListe.Add(singletile);
    
        }
        private void LoadGroupTile(string imgPath, IntRect TextureInfo, string HorizontalFrameCounter,string VerticalFrameCounter, string name)
        {


            SingleTileCollection templiste = new SingleTileCollection(name);

            for (int cpt = 0; cpt < Convert.ToInt32(HorizontalFrameCounter); cpt++)
            {
                for (int cpt2 = 0; cpt2 < Convert.ToInt32(VerticalFrameCounter); cpt2++)
                {
                    TextureInfo.Left = TextureInfo.Left+(cpt * TextureInfo.Width);
                    TextureInfo.Top = TextureInfo.Top + (cpt2 * TextureInfo.Height);
                    Tile singletile = new Tile(name, new Texture(imgPath, TextureInfo));
                    templiste.Add(singletile);

                }

            }


        }

    }
}
