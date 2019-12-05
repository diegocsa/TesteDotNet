using Microsoft.AspNetCore.Mvc;
using System;
using TesteDotNet.InterfacesEEntidades.Entidades;
using TesteDotNet.InterfacesEEntidades.Interfaces.Aplicacao;
using TesteDotNet.Web.Models;

namespace TesteDotNet.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICaminhaoAplicacao _caminhaoAplicacao { get; }
        public HomeController(ICaminhaoAplicacao caminhaoAplicacao)
        {
            _caminhaoAplicacao = caminhaoAplicacao;
        }

        public IActionResult Index()
        {
            return View(new CaminhoesIndexViewModel() { CaminhoesCadastrados = _caminhaoAplicacao.RecuperarCaminhoes() });
        }

        public IActionResult Cadastro()
        {
            ViewData["Method"] = "POST";

            return View("Caminhao", new CaminhaoItemViewModel());
        }

        [HttpPost]
        public IActionResult Cadastro(CaminhaoItemViewModel model)
        {
            ViewData["Title"] = "Novo Caminhão";
            try
            {

                var caminhao = new Caminhao()
                {
                    Descricao = model.Descricao,
                    Modelo = model.Modelo,
                    AnoFabricacao = model.AnoFabricacao,
                    AnoModelo = model.AnoModelo
                };
                _caminhaoAplicacao.InserirCaminhao(caminhao);

            }
            catch (ArgumentException ex)
            {
                ViewBag.ErroProcesso = ex.ParamName;
                return View("Caminhao", model);

            }
            return Redirect("/");

        }

        [Route("home/alterar/{id}")]
        public IActionResult Alterar(Guid id)
        {
            ViewData["Title"] = "Alterar Caminhão";
            ViewData["Method"] = "PUT";
            return View("Caminhao", new CaminhaoItemViewModel(_caminhaoAplicacao.RecuperarCaminhao(id)));
        }

        [HttpPost("home/alterar/{id}")]
        public IActionResult Alterar(Guid id, CaminhaoItemViewModel model)
        {
            try
            {
                var caminhao = new Caminhao()
                {
                    Id = id,
                    Descricao = model.Descricao,
                    Modelo = model.Modelo,
                    AnoFabricacao = model.AnoFabricacao,
                    AnoModelo = model.AnoModelo
                };
                _caminhaoAplicacao.AlterarCaminhao(caminhao);

            }
            catch (ArgumentException ex)
            {
                ViewBag.ErroProcesso = ex.ParamName;
                return View("Caminhao", model);

            }
            return Redirect("/");

        }

        [HttpPost("home/Excluir/{id}")]
        public IActionResult Excluir(Guid id)
        {
            try
            {
                _caminhaoAplicacao.ExcluirCaminhao(id);

            }
            catch (ArgumentException ex)
            {
                ViewBag.ErroProcesso = ex.ParamName;
            }
            return Redirect("/");
        }

    }
}
