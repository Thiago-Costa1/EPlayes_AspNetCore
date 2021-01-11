using System.IO;

namespace Eplayers_AspNetCore.Models
{
    public class EPlayersBase
    {
        public void CreateFolderAndFile(string path)
        {
            // Database/Equipe.csv
            string folder = path.Split("/")[0];

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(path))
            {
                
                File.Create(path);
            }

            

        }
    }
}