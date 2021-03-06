using System.Collections.Generic;
using E_Players_AspNetCore.Models;

namespace E_Players_AspNetCore.Interfaces
{
    public interface IJogador 
    {
        //Criar
        void Create(Jogador j);
        
        //Ler
        List<Jogador> ReadAll();

        //Alterar
        void Update(Jogador j);
        
        //Excluir
        void Delete(int id);
         
         
    }
}