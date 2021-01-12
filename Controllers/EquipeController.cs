using System;
using Eplayers_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eplayers_AspNetCore.Controllers
{   
    // http://localhost:5001/Equipe/Listar
    [Route("Equipe")]
    public class EquipeController : Controller
    {
        // Criamos uma instância equipeModel com a estrutura Equipe
        Equipe equipeModel = new Equipe();

        [Route("Listar")]

        public IActionResult Index()
        {   
            // Listando todas as equipes e enviando para a view, através da ViewBag
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }
        
        // http://localhost:5001/Equipe/Cadastrar       
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            // Criamos uma nova instância de Equipe
            // e armazenamos os dados enviados pelo usuário
            // através do formulário
            // e salvamos no objeto novaEquipe
            Equipe novaEquipe   = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse( form["IdEquipe"]);
            novaEquipe.Nome     = form["Nome"];
            novaEquipe.Imagem   = form["Imagem"];

            // Chamamos o método Create para salvar
            // a novaEquipe no CSV
            equipeModel.Create(novaEquipe);
            ViewBag.Equipes = equipeModel.ReadAll();
            
            return LocalRedirect("~/Equipe/Listar");
        }
    }
}