using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SysSpriteLoader;

namespace Util
{
    public static class FileLoader
    {
        public static void SpriteContainerLoader(string path)
        {
            // Open the stream and read it back.
            FileStream filereader = new FileStream(path, FileMode.Open);
            StreamReader streamreader = new StreamReader(path);

            SpriteLoader spriteloader = new SpriteLoader();
            List<string> listeOfcommande = new List<string>();
            while (!streamreader.EndOfStream)
            {
                string line = streamreader.ReadLine();
                line.Replace(" ", String.Empty);
                listeOfcommande.Add(line);
              

              
            }



            spriteloader.ProcessCommand(listeOfcommande);



        }

        
       






    }
}
