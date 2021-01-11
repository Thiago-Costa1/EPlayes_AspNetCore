using System.Collections.Generic;
using Eplayers_AspNetCore.Interfaces;

namespace Eplayers_AspNetCore.Models
{
    public class Equipe : EPlayersBase , IEquipe 
    {
        // ID - Identificador único
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        private const string PATH = "Database/Equipe.csv";
        
        void IEquipe.Create(Equipe e)
        {
            throw new System.NotImplementedException();
        }

        void IEquipe.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        List<Equipe> IEquipe.ReadAll()
        {
            throw new System.NotImplementedException();
        }

        void IEquipe.Update(Equipe e)
        {
            throw new System.NotImplementedException();
        }
    }
}